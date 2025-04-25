---
title: Window
---

# <small>BH.oM.dKoP.</small>**Window**



## Class structure

### Implemented interfaces and base types

???+ bhom "The Window is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IWallOpening](/api/oM/Physical/dKoP/Geometry/Openings/IWallOpening)
    -  BH.oM.dKoP.[IdKopObject](/api/oM/Physical/dKoP/IdKopObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| StructuralWidth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| StructuralHeight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| PositionAlongWall | [ParameterPoint](/api/oM/Physical/dKoP/Geometry/ParameterPoint) | - | - |
| ConfirmationGeometryRequirementsAreMet | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| Fire | [DoorAndWindowFire](/api/oM/Physical/dKoP/Geometry/Openings/DoorAndWindowFire) | - | - |
| AcousticPerformance | [DoorAndWindowAcoustics](/api/oM/Physical/dKoP/Geometry/Openings/DoorAndWindowAcoustics) | - | - |
| ThermalPerformance | [DoorAndWindowThermalPerformance](/api/oM/Physical/dKoP/Geometry/Openings/DoorAndWindowThermalPerformance) | - | - |
| WindowStyle | [WindowStyle](/api/oM/Physical/dKoP/Geometry/Enums/WindowStyle) | - | - |
| OpeningType | [WindowOpeningType](/api/oM/Physical/dKoP/Geometry/Enums/WindowOpeningType) | - | - |
| InsideFinish | [OpeningPartFinish](/api/oM/Physical/dKoP/Geometry/Openings/OpeningPartFinish) | - | - |
| OutsideFinish | [OpeningPartFinish](/api/oM/Physical/dKoP/Geometry/Openings/OpeningPartFinish) | - | - |
| WindowFurniture | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| FinishesStyleAndOpeningDirection | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Product | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Window : BH.oM.dKoP.IWallOpening, BH.oM.dKoP.IdKopObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [Window.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Geometry\Openings\Window.cs)

All history and changes of the class can be found by inspection the history.
