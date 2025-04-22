---
title: IBarReinforcement
---

# Structure.Reinforcement.IBarReinforcement

Base interface for any reinforcement within a BarRebarIntent.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IBarReinforcement in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Structure.Reinforcement.[LongitudinalReinforcement](/api_documentation/oM/Analytical/Structure/Reinforcement/LongitudinalReinforcement)
    - Structure.Reinforcement.[TransverseReinforcement](/api_documentation/oM/Analytical/Structure/Reinforcement/TransverseReinforcement)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Diameter | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Diameter of a single rebar. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Material | [IMaterialFragment](/api_documentation/oM/Analytical/Structure/MaterialFragments/IMaterialFragment) | - | - |
| StartLocation | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Normalised length (0 means start, 1 means end) along the element where the rebars start. | - |
| EndLocation | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Normalised length (0 means start, 1 means end) along the element where the rebars ends. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a BarReinforcement is null and outputs relevant error message. | - | Structure_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IBarReinforcement.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Reinforcement\IBarReinforcement.cs)

All history and changes of the class can be found by inspection the history.
