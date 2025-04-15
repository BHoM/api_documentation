---
title: PanelAutoMeshByPointsOnEdges
---

# Adapters.SAP2000.Fragments.PanelAutoMeshByPointsOnEdges

Divide the panel based on points coincident with the panel edges.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PanelAutoMeshByPointsOnEdges in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapters.SAP2000.Fragments.[IPanelAutoMesh](/om_documentation/oM/Adapter/Adapters/SAP2000/Fragments/IPanelAutoMesh)
    -  Base.[IFragment](/om_documentation/oM/Framework/Base/IFragment)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PointOnEdgeFromLine | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If this is True, points on the area object edges are determined from intersections of straight line objects included in the group specified by the Group item with the area object edges. | - |
| PointOnEdgeFromPoint | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If this is True, points on the area object edges are determined from point objects included in the group specified by the Group item that lie on the area object edges. | - |
| LocalAxesOnEdge | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| LocalAxesOnFace | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| RestraintsOnEdge | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| RestraintsOnFace | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| Group | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| SubMesh | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| SubMeshSize | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [PanelAutoMeshByPointsOnEdges.cs](https://github.com/BHoM/SAP2000_Toolkit/blob/develop/SAP2000_oM/Fragments/PanelAutoMeshByPointsOnEdges.cs)

All history and changes of the class can be found by inspection the history.
