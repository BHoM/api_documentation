---
title: MaterialImportSources
---

# EmbodiedSuffering.Elements.MaterialImportSources

An Embodied Suffering object used for defining the import ratios per country for a particular material, utilised in a specific country (e.g. the United States gets all of its timber from Brazil, or that it is 50% from Brazil and 50% from Vietnam.)

## Class structure

### Implemented interfaces and base types

???+ bhom "The MaterialImportSources in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Material | [Material](/documentation/oM/Analytical/EmbodiedSuffering/Elements/Material) | The name of the material that is imported to a particular country from other countries. | - |
| ExportCountries | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Country](/documentation/oM/Analytical/EmbodiedSuffering/Elements/Country)&gt; | List of countries from which the material was imported. Count should match the import ratios. | - |
| ImportRatios | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt; | List of material import ratios from each country. For example, if Brazil is the sole country of import for timber the value would be 1.0, if the United Kingdom is responsible for 50% of the imports of steel to a particular country that value would be 0.5. The values do not necessarily need to add to 1.0. Count should match the ExportCountries. | - |
| ImportCountry | [Country](/documentation/oM/Analytical/EmbodiedSuffering/Elements/Country) | The name of the country in which the imported materials are utilised. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [MaterialImportSources.cs](https://github.com/BHoM/EmbodiedSuffering_Toolkit/blob/develop/EmbodiedSuffering_oM/Elements\MaterialImportSources.cs)

All history and changes of the class can be found by inspection the history.
