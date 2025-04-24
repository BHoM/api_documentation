---
title: Overview
---

# <small>BH.oM.</small>**Overview**



## Class structure

### Implemented interfaces and base types

???+ bhom "The Overview is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKopObject](/api/oM/Physical/dKoP/IdKopObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PartName | [PartName](/api/oM/Physical/dKoP/AdministrativeInformation/Enums/PartNames) | - | - |
| PathReference | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| PartDataTemplateVersion | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| DFMACategory | [DFMACategory](/api/oM/Physical/dKoP/AdministrativeInformation/Enums/DFMACategory) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Overview : BH.oM.dKoP.IdKopObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [Overview.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/AdministrativeInformation\Overview.cs)

All history and changes of the class can be found by inspection the history.
