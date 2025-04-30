---
title: RevitFilePreview
---

# <small>BH.oM.Adapters.Revit.</small>**RevitFilePreview**

Wrapper for Revit family file (.rfa) that stores basic information about it such as family category, familiy type names etc.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RevitFilePreview is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Path | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Path to the Revit family file wrapped by this object. | - |
| CategoryName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the Revit category, to which belongs the family wrapped by this object. | - |
| FamilyName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the Revit family wrapped by this object. | - |
| FamilyTypeNames | [ReadOnlyCollection](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Names of the family types contained within the Revit family wrapped by this object. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Family | [Family](/api/oM/Adapter/Adapters/Revit/Elements/Family) | Returns BHoM family wrapper based on RevitFilePreview. | - | Revit_Engine |
| OmniClass | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns OmniClass assigned to Revit family represented by RevitFilePreview. | - | Revit_Engine |
| XDocument | [XDocument](https://learn.microsoft.com/en-us/dotnet/api/System.Xml.Linq.XDocument?view=netstandard-2.0) | Retrieves XDocument from header of a Revit family file (.rfa) wrapped by RevitFilePreview. | - | Revit_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RevitFilePreview : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Base.IImmutable
```

Assembly: Revit_oM.dll

The class is defined in C#. The class definition is available on github:

- [RevitFilePreview.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Misc\RevitFilePreview.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Revit_oM/RevitFilePreview.json}
```

The JSON Schema is available on github here:

- [RevitFilePreview.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Revit_oM/RevitFilePreview.json)
