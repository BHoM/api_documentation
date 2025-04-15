---
title: IIteration
---

# Environment.SAP.IIteration

Interface to group iteration objects together for producing parametric studies within the SAP context.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IIteration in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Environment.SAP.[IOpeningTypeIteration](/documentation/oM/Adapter/Environment/SAP/IOpeningTypeIteration)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Environment.SAP.[OpeningIteration](/documentation/oM/Adapter/Environment/SAP/OpeningIteration)
    - Environment.SAP.[OpeningTypeGValueIteration](/documentation/oM/Adapter/Environment/SAP/OpeningTypeGValueIteration)
    - Environment.SAP.[OpeningTypeUValueIteration](/documentation/oM/Adapter/Environment/SAP/OpeningTypeUValueIteration)
    - Environment.SAP.[OrientationIteration](/documentation/oM/Adapter/Environment/SAP/OrientationIteration)
    - Environment.SAP.[RoofIteration](/documentation/oM/Adapter/Environment/SAP/RoofIteration)
    - Environment.SAP.[ThermalBridgeIteration](/documentation/oM/Adapter/Environment/SAP/ThermalBridgeIteration)
    - Environment.SAP.[WallIteration](/documentation/oM/Adapter/Environment/SAP/WallIteration)
    - Environment.SAP.XML.[AirPermeabilityIteration](/documentation/oM/Adapter/Environment/SAP/XML/AirPermeabilityIteration)
    - Environment.SAP.XML.[FloorIteration](/documentation/oM/Adapter/Environment/SAP/XML/FloorIteration)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Prefix | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IIteration.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Iteration/IIteration.cs)

All history and changes of the class can be found by inspection the history.
