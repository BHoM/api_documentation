---
title: IReinforcingBar
---

# Physical.Reinforcement.IReinforcingBar

Base interface for all reinforcement bars.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IReinforcingBar in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Physical.Reinforcement.[PrimaryReinforcingBar](/api_documentation/oM/Physical/Physical/Reinforcement/PrimaryReinforcingBar)
    - Physical.Reinforcement.[Stirrup](/api_documentation/oM/Physical/Physical/Reinforcement/Stirrup)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| CentreCurve | [ICurve](/api_documentation/oM/Dimensional/Geometry/ICurve) | Centreline of the reinforcement bar in three-dimensional space. When the BendRadius is sufficient for any kinks in the rebar, this can be defined as a polyline, ommiting any arcs in corners. | - |
| Diameter | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Material | [Material](/api_documentation/oM/Physical/Physical/Materials/Material) | - | - |
| BendRadius | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Bend radius used for any discontinuities in the CentreCurve. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IReinforcingBar.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/Reinforcement\IReinforcingBar.cs)

All history and changes of the class can be found by inspection the history.
