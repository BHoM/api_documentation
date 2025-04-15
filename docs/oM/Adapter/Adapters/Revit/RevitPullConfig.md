---
title: RevitPullConfig
---

# Adapters.Revit.RevitPullConfig

Configuration used for adapter interaction with Revit on Pull action.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RevitPullConfig in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapter.[ActionConfig](/documentation/oM/Framework/Adapter/ActionConfig)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Discipline | [Discipline](/documentation/oM/Adapter/Adapters/Revit/Enums/Discipline) | Discipline used on pull action. Default is Physical. | - |
| IncludeClosedWorksets | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Elements from closed worksets will be processed if true. | - |
| IncludeNestedElements | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Elements nested within families will be processed if true. | - |
| GeometryConfig | [PullGeometryConfig](/documentation/oM/Adapter/Adapters/Revit/PullGeometryConfig) | Configuration specifying which geometry should be pulled and passed to RevitGeometry fragment. | - |
| RepresentationConfig | [PullRepresentationConfig](/documentation/oM/Adapter/Adapters/Revit/PullRepresentationConfig) | Configuration specifying representation to be pulled and passed to RevitRepresentation fragment. | - |
| PullMaterialTakeOff | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Material take offs of each pulled element will be attached to resultant BHoMObjects as fragments if true. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| WrapNonBHoMObjects | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, the Push action wraps any non-BHoM type into a BH.oM.Adapter.ObjectWrapper, allowing them to make use of the full Adapter workflow. | - |
| AllowHashForComparing | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true and if no specific EqualityComparer is found for the type, Diffing hashes are computed and used to compare the objects. | - |
| DiffingConfig | [DiffingConfig](/documentation/oM/Framework/Diffing/DiffingConfig) | Configurations for the Diffing hashing. Requires `AllowHashForComparing` to be set to true. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [RevitPullConfig.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Config/RevitPullConfig.cs)

All history and changes of the class can be found by inspection the history.
