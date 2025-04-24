---
title: RoofPerformance
---

# <small>BH.oM.</small>**RoofPerformance**



## Class structure

### Implemented interfaces and base types

???+ bhom "The RoofPerformance is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKopObject](/api/oM/Physical/dKoP/IdKopObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Sustainability | [Sustainability](/api/oM/Physical/dKoP/Perfomance/Sustainability) | - | - |
| Durability | [Durability](/api/oM/Physical/dKoP/Perfomance/Durability) | - | - |
| Acoustics | [AcousticsWallAndRoof](/api/oM/Physical/dKoP/Perfomance/AcousticsWallAndRoof) | - | - |
| Fire | [Fire](/api/oM/Physical/dKoP/Perfomance/Fire) | - | - |
| ThermalPerformance | [ThermalPerformance](/api/oM/Physical/dKoP/Perfomance/ThermalPerformance) | - | - |
| AirPermability | [AirPermeability](/api/oM/Physical/dKoP/Perfomance/AirPermeability) | - | - |
| Loading | [Loading](/api/oM/Physical/dKoP/Perfomance/Loading/Loading) | - | - |
| Services | [Services](/api/oM/Physical/dKoP/Perfomance/Services/Services) | - | - |
| Finishes | [FinishesRoof](/api/oM/Physical/dKoP/Perfomance/Finishes/FinishesRoof) | - | - |
| AdditionalFeatures | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RoofPerformance : BH.oM.dKoP.IdKopObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [RoofPerformance.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Perfomance\RoofPerformance.cs)

All history and changes of the class can be found by inspection the history.
