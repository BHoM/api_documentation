---
title: IPanelAutoMesh
---

# Adapters.SAP2000.Fragments.IPanelAutoMesh

Base interface for panel auto mesh settings in SAP2000. Contains the type of auto mesh and the properties common to all types.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IPanelAutoMesh in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IFragment](/documentation/oM/Framework/Base/IFragment)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.SAP2000.Fragments.[PanelAutoMeshByCookieCutLines](/documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByCookieCutLines)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByCookieCutPoints](/documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByCookieCutPoints)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByGeneralDivide](/documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByGeneralDivide)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByMaximumSize](/documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByMaximumSize)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByNumberOfObjects](/documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByNumberOfObjects)
    - Adapters.SAP2000.Fragments.[PanelAutoMeshByPointsOnEdges](/documentation/oM/Adapter/Adapters/SAP2000/Fragments/PanelAutoMeshByPointsOnEdges)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| LocalAxesOnEdge | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If this item is True, and if both points along an edge of the original area object have the same local axes, the program makes the local axes for added points along the edge the same as the edge end points. | - |
| LocalAxesOnFace | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If this item is True, and if all points around the perimeter of the original area object have the same local axes, the program makes the local axes for all added points the same as the perimeter points. | - |
| RestraintsOnEdge | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If this item is True, and if both points along an edge of the original area object have the same restraint/constraint, then, if the added point and the adjacent corner points have the same local axes definition, the program includes the restraint/constraint for added points along the edge. | - |
| RestraintsOnFace | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If this item is True, and if all points around the perimeter of the original area object have the same restraint/constraint, then, if an added point and the perimeter points have the same local axes definition, the program includes the restraint/constraint for the added point. | - |
| Group | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The name of a defined group. Some of the meshing options make use of point and line objects included in this group. | - |
| SubMesh | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If this item is True, after initial meshing, the program further meshes any area objects that have an edge longer than the length specified by the SubMeshSize item. | - |
| SubMeshSize | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | This item applies when the SubMesh item is True. It is the maximum size of area objects to remain when the auto meshing is complete. | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IPanelAutoMesh.cs](https://github.com/BHoM/SAP2000_Toolkit/blob/develop/SAP2000_oM/Fragments/IPanelAutoMesh.cs)

All history and changes of the class can be found by inspection the history.
