---
title: RevitGeometry
---

# Adapters.Revit.RevitGeometry

Fragment containing the geometry extracted from Revit element represented by the BHoM object.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RevitGeometry in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IFragment](/api/oM/Framework/Base/IFragment)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  Base.[IImmutable](/api/oM/Framework/Base/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Edges | [ReadOnlyCollection](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/ICurve)&gt; | Edge curves of Revit element represented by the BHoM object carrying this fragment. | - |
| Surfaces | [ReadOnlyCollection](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1?view=netstandard-2.0)&lt;[ISurface](/api/oM/Dimensional/Geometry/ISurface)&gt; | Surface geometry of Revit element represented by the BHoM object carrying this fragment. | - |
| Meshes | [ReadOnlyCollection](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1?view=netstandard-2.0)&lt;[Mesh](/api/oM/Dimensional/Geometry/Mesh)&gt; | Meshed surfaces of Revit element represented by the BHoM object carrying this fragment. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [RevitGeometry.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Misc/RevitGeometry.cs)

All history and changes of the class can be found by inspection the history.
