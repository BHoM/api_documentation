---
title: TheatronFullProfile
---

# Architecture.Theatron.TheatronFullProfile



## Class structure

### Implemented interfaces and base types

???+ bhom "The TheatronFullProfile in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/om_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BaseTierProfiles | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[TierProfile](/om_documentation/oM/Analytical/Architecture/Theatron/TierProfile)&gt; | The set of tier profiles orientated in the world xz plane, the origin is the focal point for Cvalue calculations | - |
| MappedProfiles | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[TierProfile](/om_documentation/oM/Analytical/Architecture/Theatron/TierProfile)&gt; | The set of tier profiles orientated to the plane closest to the focal curve | - |
| Rounding | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| FullProfileOrigin | [ProfileOrigin](/om_documentation/oM/Analytical/Architecture/Theatron/ProfileOrigin) | The plane at the first surface point, x axis is horizontal and points away from the playing area, y axis points up | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/om_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Geometry | [CompositeGeometry](/om_documentation/oM/Dimensional/Geometry/CompositeGeometry) | Extracts geometry of the given TheatronFullProfile. | - | Architecture_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [TheatronFullProfile.cs](https://github.com/BHoM/BHoM/blob/develop/Architecture_oM/Theatron/Elements/TheatronFullProfile.cs)

All history and changes of the class can be found by inspection the history.
