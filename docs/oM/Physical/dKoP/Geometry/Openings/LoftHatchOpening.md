---
title: LoftHatchOpening
---

# <small>BH.oM.</small>**LoftHatchOpening**



## Class structure

### Implemented interfaces and base types

???+ bhom "The LoftHatchOpening is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IFloorAndRoofOpening](/api/oM/Physical/dKoP/Geometry/Openings/IFloorAndRoofOpening)
    -  BH.oM.dKoP.[IdKopObject](/api/oM/Physical/dKoP/IdKopObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ClearWidth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| ClearLength | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| SettingOut | [ParameterPoint](/api/oM/Physical/dKoP/Geometry/ParameterPoint) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class LoftHatchOpening : BH.oM.dKoP.IFloorAndRoofOpening, BH.oM.dKoP.IdKopObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [LoftHatchOpening.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Geometry\Openings\LoftHatchOpening.cs)

All history and changes of the class can be found by inspection the history.
