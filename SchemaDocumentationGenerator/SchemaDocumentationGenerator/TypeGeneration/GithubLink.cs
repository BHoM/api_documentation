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

        private static string Links(this Type type)
        {
            string classWord = type.TypeWord();

            string markdown = "## Code and Schema\n\n";
            markdown += "### C# implementation\n\n";

            markdown += "``` C# title=\"C#\"\n";

            markdown += $"public {classWord} {type.Name}";
            List<Type> baseTypes = type.GetBaseTypes();
            if (baseTypes.Count > 0)
            {
                List<string> names = baseTypes.Select(x => x.TypeNameBaseTypes()).ToList();
                int charCount = names.Sum(x => x.Length);
                string split = charCount > 120? ",\n" : ", ";
                markdown += $" : {string.Join(split, names)}";
            }
            markdown += "\n";
            markdown += "```\n\n";
            markdown += $"Assembly: {type.Assembly.GetName().Name}.dll\n\n";

            string link = type.GithubLink();
            if (!string.IsNullOrEmpty(link))
            {
                markdown += $"The {classWord} is defined in C#. The class definition is available on github:\n\n";
                markdown += $"- {link}\n";
                markdown += "\nAll history and changes of the class can be found by inspection the history.\n";
            }
            return markdown;

            markdown += "### JSON Schema implementation\n\n";
            markdown += "The object is defined as a JSON schema, available on github:";
        }

        /***************************************************/

        private static string TypeWord(this Type type)
        {
            if (type.IsEnum)
                return "enum";
            if (type.IsInterface)
                return "interface";
            if (type.IsAbstract)
                return "abstract class";

            return "class";
        }

        /***************************************************/

        private static string TypeNameBaseTypes(this Type type)
        {
            if (type.IsGenericType)
            {
                string genType = type.GetGenericTypeDefinition().FullName.Split('`')[0];

                List<string> args = new List<string>();

                foreach (Type t in type.GetGenericArguments())
                {
                    args.Add(t.TypeNameBaseTypes());
                }

                return $"{genType}<{string.Join(", ", args)}>";
            }
            else
                return type.FullName;
        }

        /***************************************************/

        private static string GithubLink(this Type type)
        {

            if (Settings.AssemblyLink.TryGetValue(type.Assembly.GetName().Name, out string repoLink) && TryGetFileLink(type, out string objectLink))
            {
                string link = $"{repoLink}/blob/develop/{type.Assembly.GetName().Name}/{objectLink}";    //Skip the first three parts of the namespace
                return $"[{type.Name.Split('`')[0]}.cs]({link})";
            }
            return "";
        }

        /***************************************************/

    }
}
