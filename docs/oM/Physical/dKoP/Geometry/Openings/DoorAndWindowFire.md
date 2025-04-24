---
title: DoorAndWindowFire
---

# <small>BH.oM.</small>**DoorAndWindowFire**



## Class structure

### Implemented interfaces and base types

???+ bhom "The DoorAndWindowFire is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKopObject](/api/oM/Physical/dKoP/IdKopObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| FireResistance | [FireResistancePeriod](/api/oM/Physical/dKoP/Perfomance/Enums/FireResistancePeriod) | - | - |
| SurfaceSpreadOfFlame | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Reaction to fire, smoke propagation, flaming droplets and particles. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class DoorAndWindowFire : BH.oM.dKoP.IdKopObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [DoorAndWindowFire.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Geometry\Openings\DoorAndWindowFire.cs)

All history and changes of the class can be found by inspection the history.
