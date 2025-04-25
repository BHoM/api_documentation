---
title: IFloorAndRoofOpening
---

# <small>BH.oM.dKoP.</small>**IFloorAndRoofOpening**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IFloorAndRoofOpening is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKopObject](/api/oM/Physical/dKoP/IdKopObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.dKoP.[LoftHatchOpening](/api/oM/Physical/dKoP/Geometry/Openings/LoftHatchOpening)
    - BH.oM.dKoP.[Staircase](/api/oM/Physical/dKoP/Geometry/Openings/Staircase)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ClearWidth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| ClearLength | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| SettingOut | [ParameterPoint](/api/oM/Physical/dKoP/Geometry/ParameterPoint) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IFloorAndRoofOpening : BH.oM.dKoP.IdKopObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IFloorAndRoofOpening.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Geometry\Openings\IFloorAndRoofOpening.cs)

All history and changes of the class can be found by inspection the history.
