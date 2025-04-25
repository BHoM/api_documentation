---
title: PanelAutoMeshByMaximumSize
---

# <small>BH.oM.Adapters.SAP2000.Fragments.</small>**PanelAutoMeshByMaximumSize**

Divide the panel so that elements do not exceed a maximum size.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PanelAutoMeshByMaximumSize is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapters.SAP2000.Fragments.[IPanelAutoMesh](/api/oM/Adapter/Adapters/SAP2000/Fragments/IPanelAutoMesh)
    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| MaxSize1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | This is the maximum size of objects created along the edge of the meshed area object that runs from point 1 to point 2. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| MaxSize2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | This is the maximum size of objects created along the edge of the meshed area object that runs from point 1 to point 3. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
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
public class PanelAutoMeshByMaximumSize : BH.oM.Adapters.SAP2000.Fragments.IPanelAutoMesh, BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: SAP2000_oM.dll

The class is defined in C#. The class definition is available on github:

- [PanelAutoMeshByMaximumSize.cs](https://github.com/BHoM/SAP2000_Toolkit/blob/develop/SAP2000_oM/Fragments\PanelAutoMeshByMaximumSize.cs)

All history and changes of the class can be found by inspection the history.
