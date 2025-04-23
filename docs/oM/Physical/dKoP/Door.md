---
title: Door
---

# dKoP.Door



## Class structure

### Implemented interfaces and base types

???+ bhom "The Door in inheriting from the following base type(s) and implements the following interfaces:"

    -  dKoP.[IWallOpening](/api/oM/Physical/dKoP/IWallOpening)
    -  dKoP.[IdKopObject](/api/oM/Physical/dKoP/IdKopObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| StructuralWidth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| StructuralHeight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| PositionAlongWall | [ParameterPoint](/api/oM/Physical/dKoP/ParameterPoint) | - | - |
| ConfirmationGeometryRequirementsAreMet | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| Fire | [DoorAndWindowFire](/api/oM/Physical/dKoP/DoorAndWindowFire) | - | - |
| AcousticPerformance | [DoorAndWindowAcoustics](/api/oM/Physical/dKoP/DoorAndWindowAcoustics) | - | - |
| ThermalPerformance | [DoorAndWindowThermalPerformance](/api/oM/Physical/dKoP/DoorAndWindowThermalPerformance) | - | - |
| DoorFinish | [DoorFinish](/api/oM/Physical/dKoP/DoorFinish) | - | - |
| FrameFinish | [OpeningPartFinish](/api/oM/Physical/dKoP/OpeningPartFinish) | - | - |
| DoorFurniture | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| ArchitraveSpecification | [Architrave](/api/oM/Physical/dKoP/Architrave) | - | - |
| DirectionOfOpening | [Direction](/api/oM/Physical/dKoP/Direction) | - | - |
| FinishesStyleAndOpeningDirection | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Product | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Door.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Geometry/Openings/Door.cs)

All history and changes of the class can be found by inspection the history.
