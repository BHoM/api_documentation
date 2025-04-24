---
title: PanelAutoMeshByCookieCutPoints
---

# <small>BH.oM.Adapters.SAP2000.</small>**PanelAutoMeshByCookieCutPoints**

Divide the panel based on points in the meshing group.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PanelAutoMeshByCookieCutPoints is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapters.SAP2000.Fragments.[IPanelAutoMesh](/api/oM/Adapter/Adapters.SAP2000/Fragments/IPanelAutoMesh)
    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Rotation | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | This is an angle in radians that the meshing lines are rotated from their default orientation.By default these lines align with the area object local 1 and 2 axes. | [Angle](/api/oM/Dimensional/Quantities/Attributes/Angle) [rad] |
| LocalAxesOnEdge | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| LocalAxesOnFace | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| RestraintsOnEdge | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| RestraintsOnFace | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| Group | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| SubMesh | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| SubMeshSize | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PanelAutoMeshByCookieCutPoints : BH.oM.Adapters.SAP2000.Fragments.IPanelAutoMesh, BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: SAP2000_oM.dll

The class is defined in C#. The class definition is available on github:

- [PanelAutoMeshByCookieCutPoints.cs](https://github.com/BHoM/SAP2000_Toolkit/blob/develop/SAP2000_oM/Fragments\PanelAutoMeshByCookieCutPoints.cs)

All history and changes of the class can be found by inspection the history.
