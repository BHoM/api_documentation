---
title: MaterialComposition
---

# Physical.Materials.MaterialComposition

Defines the make up of an object through a list of Materials as relative proportions of the total solid volume.
There must be the same number of items in both lists, assigning a single Ratio for each Material.

## Class structure

### Implemented interfaces and base types

???+ bhom "The MaterialComposition in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Physical.[IPhysical](/api_documentation/oM/Physical/Physical/IPhysical)
    -  Base.[IImmutable](/api_documentation/oM/Framework/Base/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Materials | [IReadOnlyList](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1?view=netstandard-2.0)&lt;[Material](/api_documentation/oM/Physical/Physical/Materials/Material)&gt; | The Materials that form an object's make up, the order of which corresponds to the order of the Ratios. | - |
| Ratios | [IReadOnlyList](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1?view=netstandard-2.0)&lt;[double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt; | The list of Material volumetric Ratios. The sum of which must equate to one. | [Ratio](/api_documentation/oM/Dimensional/Quantities/Attributes/Ratio) [-] |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| ExternalPolyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api_documentation/oM/Dimensional/Geometry/Polyline)&gt; | Returns the External Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| InternalPolyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api_documentation/oM/Dimensional/Geometry/Polyline)&gt; | Returns the Internal Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| Polyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api_documentation/oM/Dimensional/Geometry/Polyline)&gt; | Returns a Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [MaterialComposition.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/Materials\MaterialComposition.cs)

All history and changes of the class can be found by inspection the history.
