---
title: PartyWall
---

# <small>BH.oM.dKoP.</small>**PartyWall**



## Class structure

### Implemented interfaces and base types

???+ bhom "The PartyWall is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKopObject](/api/oM/Physical/dKoP/IdKopObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| AdministrativeInformation | [AdministrativeInformation](/api/oM/Physical/dKoP/AdministrativeInformation/AdministrativeInformation) | - | - |
| QualityAndCertification | [QualityAndCertification](/api/oM/Physical/dKoP/QualityAndCertification/QualityAndCertification) | - | - |
| HealthAndSafety | [HealthAndSafety](/api/oM/Physical/dKoP/HealthAndSafety/HealthAndSafety) | - | - |
| Geometry | [WallGeometry](/api/oM/Physical/dKoP/Geometry/WallGeometry) | - | - |
| Performance | [PartyWallPerformance](/api/oM/Physical/dKoP/Perfomance/PartyWallPerformance) | - | - |
| Assembly | [Assembly](/api/oM/Physical/dKoP/Assembly/Assembly) | - | - |
| Interfaces | [WallInterfaces](/api/oM/Physical/dKoP/Interfaces/WallInterfaces) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PartyWall : BH.oM.dKoP.IdKopObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [PartyWall.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Schemas\PartyWall.cs)

All history and changes of the class can be found by inspection the history.
