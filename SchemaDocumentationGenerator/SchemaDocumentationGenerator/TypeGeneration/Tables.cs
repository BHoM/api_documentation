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
        /**** Table methods                             ****/
        /***************************************************/

        private static string PropertyTable(this IEnumerable<PropertyInfo> props, bool includeQuantities = true)
        {
            string markdown;
            if (includeQuantities)
            {
                markdown = "| Name             | Type             | Description      | Quantity         |\n";
                markdown += "|------------------|------------------|------------------|------------------|\n";
            }
            else
            {
                markdown = "| Name             | Type             | Description      |\n";
                markdown += "|------------------|------------------|------------------|\n";
            }
            foreach (PropertyInfo property in props)
            {
                markdown += PropertyTableString(property, includeQuantities);
            }
            return markdown;
        }

        /***************************************************/

        private static string PropertyTable(this IEnumerable<MethodInfo> methods, bool includeQuantities = true)
        {
            string markdown;
            if (includeQuantities)
            {
                markdown = "| Name             | Type             | Description      | Quantity         | Engine           |\n";
                markdown += "|------------------|------------------|------------------|------------------|------------------|\n";
            }
            else
            {
                markdown = "| Name             | Type             | Description      |  Engine           |\n";
                markdown += "|------------------|------------------|------------------|------------------|\n";

            }
            foreach (MethodInfo method in methods)
            {
                markdown += PropertyTableString(method, includeQuantities);
            }

            return markdown;
        }

        /***************************************************/

        private static string EnumTable(this IEnumerable<FieldInfo> enumFields)
        {
            string markdown = "| Name            | Description                                                    |\n";
            markdown +=       "|-----------------|----------------------------------------------------------------|\n";


            foreach (FieldInfo enumValue in enumFields)
            {
                if (enumValue.Name == "value__")
                    continue;
                markdown += EnumTableString(enumValue);
            }
            return markdown;
        }

        /***************************************************/

        private static string QuantityTable(this QuantityAttribute quantity, List<PropertyInfo> dimensions)
        {
            string markdown = "| Measure        | Dimension symbol | Quantity |\n";
            markdown += "|------------------|--------|----------|\n";


            foreach (PropertyInfo property in dimensions)
            {
                markdown += QuantityTableString(quantity, property);
            }
            return markdown;
        }

        /***************************************************/
        /**** Row methods                               ****/
        /***************************************************/

        private static string PropertyTableString(PropertyInfo property, bool includeQuantities)
        {
            string desc = property.SafeDescString();
            if (includeQuantities)
            {
                QuantityAttribute quant = property.GetCustomAttribute<QuantityAttribute>();
                string quantString = quant.QuantityString();
                return $"| {property.Name} | {property.PropertyType.GetNameAsLink(false)} | {desc} | {quantString} |\n";
            }
            else
            {
                return $"| {property.Name} | {property.PropertyType.GetNameAsLink(false)} | {desc} |\n";

            }

        }

        /***************************************************/

        private static string PropertyTableString(MethodInfo method, bool includeQuantities)
        {
            string desc = method.SafeDescString();
            if (includeQuantities)
            {
                QuantityAttribute quant = method.GetCustomAttribute<OutputAttribute>()?.Classification as QuantityAttribute;
                string quantString = quant.QuantityString();
                return $"| {method.Name} | {method.ReturnType.GetNameAsLink(false)} | {desc} | {quantString} | {method.DeclaringType.Assembly.GetName().Name} |\n";
            }
            else
            {
                return $"| {method.Name} | {method.ReturnType.GetNameAsLink(false)} | {desc} | {method.DeclaringType.Assembly.GetName().Name} |\n";

            }
        }

        /***************************************************/

        private static string EnumTableString(FieldInfo enumValue)
        {
            string desc = enumValue.SafeDescString();
            int value = (int)enumValue.GetValue(null);
            return $"| {enumValue.Name} |  {desc}  |\n";
        }

        /***************************************************/

        private static string QuantityTableString(QuantityAttribute quantity, PropertyInfo property)
        {
            string dim = property.Name;
            string meassure = property.SafeDescString();
            string value = property.GetValue(quantity).ToString();
            return $"| {meassure} |  {dim}  |{value}  |\n";
        }

        /***************************************************/
    }
}
