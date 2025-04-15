

using BH.oM.Base;
using SchemaDocumentationGenerator;
using System.Reflection;

Console.WriteLine("Loading Settings.");
Settings.LoadSettings(@"C:\Users\INaslund\Buro Happold\Design & Technology - Dev Docs\00756_oM_Documentation\oM_categorisation.csv");

Console.WriteLine("Loading Engine assemblies.");
List<Assembly> engineAssemblies = AssemblyLoader.LoadAllEngineAssemblies(new List<string> { "BHoM" });
Console.WriteLine("Extracting query methods.");
Dictionary<Type, List<MethodInfo>> methods = ExtensionMethodsExtractor.GetAllExtensionMethods(engineAssemblies);

Console.WriteLine("Loading oM Asseblies");
List<Assembly> oMAssemblies = AssemblyLoader.LoadAlloMAssemblies(new List<string> { "BHoM" });

Console.WriteLine("Mapping types");
foreach (Assembly assembly in oMAssemblies)
{
    foreach (Type type in assembly.GetTypes())
    {
        TypeToMarkdown.MapDependecies(type);
    }
}


TypeToMarkdown.SetupAssemblyFolders(@"C:\BHoMBot\Github", oMAssemblies);

foreach (Assembly assembly in oMAssemblies)
{
    Console.WriteLine($"Generating {assembly.GetName().Name} type docs");
    foreach (Type type in assembly.GetTypes())
    {
        if (!(type.IsAbstract && type.IsSealed) && (type.IsEnum || typeof(IObject).IsAssignableFrom(type)))
        {
            TypeToMarkdown.WriteTypeToMarkdown(@"C:\Github\schemaDocumentation\docs\", type, methods);
        }
    }
}
