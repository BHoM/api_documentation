---
title: Buildup
---

# <small>BH.oM.dKoP.</small>**Buildup**



## Class structure

### Implemented interfaces and base types

???+ bhom "The Buildup is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKopObject](/api/oM/Physical/dKoP/IdKopObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PrimaryStructuralMaterial | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| BuildupDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| ExternalFinishesInstalledOffsite | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| ExternalComponentsInstalledOnSite | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| InternalFinishesInstalledOffsite | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| InternalComponentsInstalledOnSite | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Buildup : BH.oM.dKoP.IdKopObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [Buildup.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/ProductInformation\Buildup.cs)

All history and changes of the class can be found by inspection the history.
