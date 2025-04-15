---
title: PullGeometryConfig
---

# Adapters.Revit.PullGeometryConfig

Configuration used to specify which geometry should be pulled and passed to RevitGeometry fragment.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PullGeometryConfig in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PullEdges | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, edges of elements will be pulled and stored under Revit_edges in RevitGeometry fragment. | - |
| PullSurfaces | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, surfaces of elements will be pulled and stored under Revit_surfaces in RevitGeometry fragment. | - |
| PullMeshes | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, meshed surfaces of elements will be pulled and stored under Revit_meshes in RevitGeometry fragment. | - |
| MeshDetailLevel | [DetailLevel](/om_documentation/oM/Adapter/Adapters/Revit/Enums/DetailLevel) | Detail level of mesh to be pulled, correspondent to level of detail in Revit. | - |
| IncludeNonVisible | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Invisible element parts will be pulled and passed to RevitGeometry fragment if true. PullEdges or PullSurfaces switched to true needed for this to activate. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [PullGeometryConfig.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Config/PullGeometryConfig.cs)

All history and changes of the class can be found by inspection the history.
