using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SchemaDocumentationGenerator
{
    public static class ExtensionMethodsExtractor
    {
        [Description("Loads all .dll assemblies with names ending with oM, _Engine and _Adapter (with optional suffixes) from a given folder.")]
        public static Dictionary<Type, List<MethodInfo>> GetAllExtensionMethods(List<Assembly> engineAssemblies)
        {
            Dictionary<Type, List<MethodInfo>> extensionMethods = new Dictionary<Type, List<MethodInfo>>();

            foreach (Assembly assembly in engineAssemblies)
            {
                try
                {


                    foreach (Type type in assembly.GetTypes())
                    {
                        if (type.Name == "Query")
                        {
                            List<MethodInfo> allMethods = type.GetMethods(BindingFlags.Static | BindingFlags.Public).ToList();

                            List<MethodInfo> methods = allMethods.Where(x =>
                            {
                                var parameters = x.GetParameters();

                                if(parameters.Length == 0)  //Rule out methods with no parameters
                                    return false;

                                if (parameters.Length == 1) //Keep methods with exactly one parameter
                                    return true;

                                //ALso keep for which the only additional parameters are tolerance parameters
                                //Filtered as need to be double type with default value and name containing tol
                                //Doing this to get methods like Area included (currently has a tolerance to check if curves are closed
                                return parameters.Skip(1).All(x => x.HasDefaultValue);

                            }).ToList();

                            foreach (MethodInfo method in methods)
                            {
                                if (method.IsGenericMethod)
                                {
                                    //TODO
                                }
                                else
                                {
                                    Type paramType = method.GetParameters()[0].ParameterType;
                                    if (!extensionMethods.ContainsKey(paramType))
                                        extensionMethods[paramType] = new List<MethodInfo>();

                                    extensionMethods[paramType].Add(method);
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    
                }
            }

            return extensionMethods;
        }

    }
}
