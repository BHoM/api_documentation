---
title: PanelAutoMeshByCookieCutPoints
---

# Adapters.SAP2000.Fragments.PanelAutoMeshByCookieCutPoints

Divide the panel based on points in the meshing group.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PanelAutoMeshByCookieCutPoints in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapters.SAP2000.Fragments.[IPanelAutoMesh](/om_documentation/oM/Adapter/Adapters/SAP2000/Fragments/IPanelAutoMesh)
    -  Base.[IFragment](/om_documentation/oM/Framework/Base/IFragment)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Rotation | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | This is an angle in radians that the meshing lines are rotated from their default orientation.By default these lines align with the area object local 1 and 2 axes. | [Angle](/om_documentation/oM/Dimensional/Quantities/Attributes/Angle) [rad] |
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

- [PanelAutoMeshByCookieCutPoints.cs](https://github.com/BHoM/SAP2000_Toolkit/blob/develop/SAP2000_oM/Fragments/PanelAutoMeshByCookieCutPoints.cs)

All history and changes of the class can be found by inspection the history.
