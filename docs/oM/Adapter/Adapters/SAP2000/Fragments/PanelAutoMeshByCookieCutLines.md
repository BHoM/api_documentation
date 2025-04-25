---
title: PanelAutoMeshByCookieCutLines
---

# <small>BH.oM.Adapters.SAP2000.Fragments.</small>**PanelAutoMeshByCookieCutLines**

Divide the panel based on lines in the meshing group.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PanelAutoMeshByCookieCutLines is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapters.SAP2000.Fragments.[IPanelAutoMesh](/api/oM/Adapter/Adapters/SAP2000/Fragments/IPanelAutoMesh)
    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ExtendCookieCutLines | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If this item is True, all straight line objects included in the group specified by the Group item are extended to intersect the area object edges for the purpose of meshing the area object. | - |
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
public class PanelAutoMeshByCookieCutLines : BH.oM.Adapters.SAP2000.Fragments.IPanelAutoMesh, BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: SAP2000_oM.dll

The class is defined in C#. The class definition is available on github:

- [PanelAutoMeshByCookieCutLines.cs](https://github.com/BHoM/SAP2000_Toolkit/blob/develop/SAP2000_oM/Fragments\PanelAutoMeshByCookieCutLines.cs)

All history and changes of the class can be found by inspection the history.
