---
title: Construction
---

# <small>BH.oM.</small>**Construction**



## Class structure

### Implemented interfaces and base types

???+ bhom "The Construction is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKopObject](/api/oM/Physical/dKoP/IdKopObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Weight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | [Mass](/api/oM/Dimensional/Quantities/Attributes/Mass) [kg] |
| LiftingPoints | [LiftingPoints](/api/oM/Physical/dKoP/Assembly/LiftingPoints) | - | - |
| TemporaryWorks | [TemporaryWorks](/api/oM/Physical/dKoP/Assembly/TemporaryWorks) | - | - |
| WeatherProtection | [WeatherProtection](/api/oM/Physical/dKoP/Assembly/WeatherProtection) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Construction : BH.oM.dKoP.IdKopObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [Construction.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Assembly\Construction.cs)

All history and changes of the class can be found by inspection the history.
