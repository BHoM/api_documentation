---
title: RAMNodeForceData
---

# <small>BH.oM.Adapters.</small>**RAMNodeForceData**



## Class structure

### Implemented interfaces and base types

???+ bhom "The RAMNodeForceData is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Axial | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Member Force axial at node per RAM | - |
| Location | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Node distance location along member per RAM | - |
| MomMaj | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Member Force moment maximum at node per RAM | - |
| MomMin | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Member Force moment minimum at node per RAM | - |
| ShearMaj | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Member Force shear maximum at node per RAM | - |
| ShearMin | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Member Force shear minimum at node per RAM | - |
| Torsion | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Member Force Torsion at node per RAM | - |
| LoadcaseID | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Represents Loadcase ID as per RAM | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RAMNodeForceData : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: RAM_oM.dll

The class is defined in C#. The class definition is available on github:

- [RAMNodeForceData.cs](https://github.com/BHoM/RAM_Toolkit/blob/develop/RAM_oM/Fragments\RAMNodeForceData.cs)

All history and changes of the class can be found by inspection the history.
