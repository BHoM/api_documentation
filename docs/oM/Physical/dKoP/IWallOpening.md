---
title: IWallOpening
---

# dKoP.IWallOpening



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IWallOpening in inheriting from the following base type(s) and implements the following interfaces:"

    -  dKoP.[IdKopObject](/api/oM/Physical/dKoP/IdKopObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - dKoP.[Door](/api/oM/Physical/dKoP/Door)
    - dKoP.[Window](/api/oM/Physical/dKoP/Window)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| StructuralWidth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| StructuralHeight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| PositionAlongWall | [ParameterPoint](/api/oM/Physical/dKoP/ParameterPoint) | - | - |
| ConfirmationGeometryRequirementsAreMet | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| Fire | [DoorAndWindowFire](/api/oM/Physical/dKoP/DoorAndWindowFire) | - | - |
| AcousticPerformance | [DoorAndWindowAcoustics](/api/oM/Physical/dKoP/DoorAndWindowAcoustics) | - | - |
| ThermalPerformance | [DoorAndWindowThermalPerformance](/api/oM/Physical/dKoP/DoorAndWindowThermalPerformance) | - | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IWallOpening.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Geometry/Openings/IWallOpening.cs)

All history and changes of the class can be found by inspection the history.
