---
title: PanelAutoMeshByGeneralDivide
---

# Adapters.SAP2000.Fragments.PanelAutoMeshByGeneralDivide

Divide the panel based on points and lines in the meshing group and a maximum size.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PanelAutoMeshByGeneralDivide in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapters.SAP2000.Fragments.[IPanelAutoMesh](/api/oM/Adapter/Adapters/SAP2000/Fragments/IPanelAutoMesh)
    -  Base.[IFragment](/api/oM/Framework/Base/IFragment)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| MaxSizeGeneral | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | This is the maximum size of objects created by the General Divide Tool. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
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

- [PanelAutoMeshByGeneralDivide.cs](https://github.com/BHoM/SAP2000_Toolkit/blob/develop/SAP2000_oM/Fragments/PanelAutoMeshByGeneralDivide.cs)

All history and changes of the class can be found by inspection the history.
