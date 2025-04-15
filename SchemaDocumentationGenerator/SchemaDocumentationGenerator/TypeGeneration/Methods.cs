using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using BH.oM.Base;
using BH.oM.Base.Attributes;
using BH.oM.Quantities.Attributes;

namespace SchemaDocumentationGenerator
{
    public static partial class TypeToMarkdown
    {
        /***************************************************/

        private static List<MethodInfo> GetExtensionMethods(this Type type, List<Type> baseTypes, List<Type> ignoredTargetTypes, Dictionary<Type, List<MethodInfo>> extensionMethods)
        {
            List<MethodInfo> methods;
            if (!extensionMethods.TryGetValue(type, out methods))
                methods = new List<MethodInfo>();

            if (baseTypes != null)
            {
                List<Type> methodBaseTypes;
                if (!ignoredTargetTypes.Contains(type))
                    methodBaseTypes = baseTypes.Except(ignoredTargetTypes).ToList();    //Skip methods targeting base types to avoid flooding the docs with methods acceptiong IObejct, BHoMObject etc, except for thos types
                else
                    methodBaseTypes = baseTypes;

                foreach (Type baseType in methodBaseTypes)
                {
                    if (extensionMethods.TryGetValue(baseType, out List<MethodInfo> baseExtensionMethod))
                        methods.AddRange(baseExtensionMethod);
                }
            }
            methods = methods.Distinct().ToList();
            methods.Sort((a, b) => a.CompareMethods(b, type));


            return methods;
        }

        /***************************************************/

        private static int CompareMethods(this MethodInfo a, MethodInfo b, Type type)
        {
            //Check if adapter method if so, put after
            //bool aIsAdapter = a.IsAdapterNamespaceMethod();
            //bool bIsAdapter = b.IsAdapterNamespaceMethod();
            //if (aIsAdapter && !bIsAdapter)
            //    return 1;

            //if (bIsAdapter && !aIsAdapter)
            //    return -1;

            ////Check if on of the methods come from an engine with matching namespace
            //string omNameSpace = type.MainNameSpace();
            //string aNameSpace = a.MainNameSpace();
            //string bNameSpace = b.MainNameSpace();

            //if (aNameSpace == omNameSpace && bNameSpace != omNameSpace)
            //    return -1;

            //if (bNameSpace == omNameSpace && aNameSpace != omNameSpace)
            //    return 1;

            ////Check if type is matching provided type
            //bool aMatchingType = a.GetParameters()[0].ParameterType == type;
            //bool bMatchingType = a.GetParameters()[0].ParameterType == type;

            //if (aMatchingType && !bMatchingType)
            //    return -1;

            //if (bMatchingType && !aMatchingType)
            //    return 1;

            ////Compare namespace
            //int nameSpaceCompare = aNameSpace.CompareTo(bNameSpace);
            //if (nameSpaceCompare != 0)
            //    return nameSpaceCompare;

            //Compare method name
            return a.Name.CompareTo(b.Name);
        }

        /***************************************************/

        private static bool IsAdapterNamespaceMethod(this MethodInfo method)
        {
            return method.DeclaringType.Namespace.StartsWith("BH.Engine.Adapters");
        }

        /***************************************************/

        private static string MainNameSpace(this MethodInfo method)
        {
            return method.DeclaringType.MainNameSpace();
        }

        /***************************************************/

        private static string MainNameSpace(this Type type)
        {
            string[] split = type.Namespace.Split('.');
            if (split.Length < 3)
                return "";

            if (split.Length > 3 && split[3] == "Adapters")
                return split[3];

            return split[2];
        }

        /***************************************************/
    }
}
