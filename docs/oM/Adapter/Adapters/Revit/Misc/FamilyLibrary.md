---
title: FamilyLibrary
---

# <small>BH.oM.Adapters.Revit.</small>**FamilyLibrary**

Library of Revit families that can be loaded to the model.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FamilyLibrary is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Files | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[RevitFilePreview](/api/oM/Adapter/Adapters/Revit/Misc/RevitFilePreview)&gt; | A list of Revit family files managed by the library. | - |


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
| FamilyTypeNames | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets Revit family type names available in FamilyLibrary for given names of Revit category and family. | - | Revit_Engine |
| Paths | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Returns all file paths in FamilyLibrary that meet given Revit category, family and family type requirements. | - | Revit_Engine |
| RevitFilePreviews | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[RevitFilePreview](/api/oM/Adapter/Adapters/Revit/Misc/RevitFilePreview)&gt; | Returns all RevitFilePreviews inside FamilyLibrary that meet Revit category, family and family type name requirements. | - | Revit_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class FamilyLibrary : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Revit_oM.dll

The class is defined in C#. The class definition is available on github:

- [FamilyLibrary.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Misc\FamilyLibrary.cs)

All history and changes of the class can be found by inspection the history.
