---
title: PanelAutoMeshByMaximumSize
---

# Adapters.SAP2000.Fragments.PanelAutoMeshByMaximumSize

Divide the panel so that elements do not exceed a maximum size.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PanelAutoMeshByMaximumSize in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapters.SAP2000.Fragments.[IPanelAutoMesh](/om_documentation/oM/Adapter/Adapters/SAP2000/Fragments/IPanelAutoMesh)
    -  Base.[IFragment](/om_documentation/oM/Framework/Base/IFragment)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| MaxSize1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | This is the maximum size of objects created along the edge of the meshed area object that runs from point 1 to point 2. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| MaxSize2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | This is the maximum size of objects created along the edge of the meshed area object that runs from point 1 to point 3. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
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

- [PanelAutoMeshByMaximumSize.cs](https://github.com/BHoM/SAP2000_Toolkit/blob/develop/SAP2000_oM/Fragments/PanelAutoMeshByMaximumSize.cs)

All history and changes of the class can be found by inspection the history.
