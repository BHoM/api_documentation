---
title: MaterialImportSources
---

# <small>BH.oM.EmbodiedSuffering.Elements.</small>**MaterialImportSources**

An Embodied Suffering object used for defining the import ratios per country for a particular material, utilised in a specific country (e.g. the United States gets all of its timber from Brazil, or that it is 50% from Brazil and 50% from Vietnam.)

## Class structure

### Implemented interfaces and base types

???+ bhom "The MaterialImportSources is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Material | [Material](/api/oM/Analytical/EmbodiedSuffering/Elements/Enums/Material) | The name of the material that is imported to a particular country from other countries. | - |
| ExportCountries | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Country](/api/oM/Analytical/EmbodiedSuffering/Elements/Enums/Country)&gt; | List of countries from which the material was imported. Count should match the import ratios. | - |
| ImportRatios | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt; | List of material import ratios from each country. For example, if Brazil is the sole country of import for timber the value would be 1.0, if the United Kingdom is responsible for 50% of the imports of steel to a particular country that value would be 0.5. The values do not necessarily need to add to 1.0. Count should match the ExportCountries. | - |
| ImportCountry | [Country](/api/oM/Analytical/EmbodiedSuffering/Elements/Enums/Country) | The name of the country in which the imported materials are utilised. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class MaterialImportSources : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: EmbodiedSuffering_oM.dll

The class is defined in C#. The class definition is available on github:

- [MaterialImportSources.cs](https://github.com/BHoM/EmbodiedSuffering_Toolkit/blob/develop/EmbodiedSuffering_oM/Elements\MaterialImportSources.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/EmbodiedSuffering_oM/Elements/MaterialImportSources.json"
}
```

The JSON Schema is available on github here:

- [MaterialImportSources.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/EmbodiedSuffering_oM/Elements/MaterialImportSources.json)
