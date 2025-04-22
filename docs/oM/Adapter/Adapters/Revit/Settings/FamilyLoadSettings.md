---
title: FamilyLoadSettings
---

# Adapters.Revit.Settings.FamilyLoadSettings

Revit family load settings for Revit Adapter. Prototype, currently with limited functionality.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FamilyLoadSettings in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| FamilyLibrary | [FamilyLibrary](/api_documentation/oM/Adapter/Adapters/Revit/FamilyLibrary) | Library of Revit families that can be loaded to the model. | - |
| OverwriteFamily | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, Revit family will be overwritten on load, if false it will not be changed. | - |
| OverwriteParameterValues | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, Revit family parameters will be overwritten on load, if false they will not be changed. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [FamilyLoadSettings.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Settings/FamilyLoadSettings.cs)

All history and changes of the class can be found by inspection the history.
