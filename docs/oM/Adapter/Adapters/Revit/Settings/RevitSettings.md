---
title: RevitSettings
---

# Adapters.Revit.Settings.RevitSettings

General settings that are applicable to all actions performed by the instance of Revit adapter.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RevitSettings in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ConnectionSettings | [ConnectionSettings](/api/oM/Adapter/Adapters/Revit/Settings/ConnectionSettings) | Socket connection settings (ports, timeout) for the adapter. | - |
| FamilyLoadSettings | [FamilyLoadSettings](/api/oM/Adapter/Adapters/Revit/Settings/FamilyLoadSettings) | Revit family load settings for the adapter. | - |
| MappingSettings | [MappingSettings](/api/oM/Adapter/Adapters/Revit/Settings/MappingSettings) | An entity holding information about the enforced convert relationships between Revit families and BHoM types on Pull as well as mapping between Revit parameters and BHoM object properties on Push/Pull. | - |
| DistanceTolerance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Distance tolerance to be used in geometry processing. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| AngleTolerance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Angle tolerance to be used in geometry processing. | [Angle](/api/oM/Dimensional/Quantities/Attributes/Angle) [rad] |


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

The class is defined in C#. The class definition is available on github:

- [RevitSettings.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Settings/RevitSettings.cs)

All history and changes of the class can be found by inspection the history.
