---
title: ProjectTeam
---

# <small>BH.oM.</small>**ProjectTeam**



## Class structure

### Implemented interfaces and base types

???+ bhom "The ProjectTeam is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKopObject](/api/oM/Physical/dKoP/IdKopObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Client | [ContactDetails](/api/oM/Physical/dKoP/AdministrativeInformation/ContactDetails) | - | - |
| Architect | [ContactDetails](/api/oM/Physical/dKoP/AdministrativeInformation/ContactDetails) | - | - |
| StructuralEngineer | [ContactDetails](/api/oM/Physical/dKoP/AdministrativeInformation/ContactDetails) | - | - |
| SeriveEngineer | [ContactDetails](/api/oM/Physical/dKoP/AdministrativeInformation/ContactDetails) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ProjectTeam : BH.oM.dKoP.IdKopObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [ProjectTeam.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/AdministrativeInformation\ProjectTeam.cs)

All history and changes of the class can be found by inspection the history.
