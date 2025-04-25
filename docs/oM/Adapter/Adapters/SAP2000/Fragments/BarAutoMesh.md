---
title: BarAutoMesh
---

# <small>BH.oM.Adapters.SAP2000.Elements.</small>**BarAutoMesh**



## Class structure

### Implemented interfaces and base types

???+ bhom "The BarAutoMesh is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| AutoMesh | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | True if the frame object is to be automatically meshed by the program when the SAP analysis model is created. | - |
| AutoMeshAtPoints | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If AutoMesh is True, the frame object is automatically meshed at intermediate joints along its length. | - |
| AutoMeshAtLines | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If AutoMesh is True, the frame object is automatically meshed at intersections with other frames, area object edges, and solid object edges. | - |
| NumSegs | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | If AutoMesh is True, the minimum number of elements into which the frame object is automatically meshed. If zero, the number of elements is not checked when the automatic meshing is done. | - |
| AutoMeshMaxLength | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | If AutoMesh is True, the maximum length of auto meshed frame elements. If zero, the element length is not checked when automatic meshing is done. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class BarAutoMesh : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: SAP2000_oM.dll

The class is defined in C#. The class definition is available on github:

- [BarAutoMesh.cs](https://github.com/BHoM/SAP2000_Toolkit/blob/develop/SAP2000_oM/Fragments\BarAutoMesh.cs)

All history and changes of the class can be found by inspection the history.
