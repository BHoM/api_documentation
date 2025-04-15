---
title: ICase
---

# Structure.Loads.ICase

Base interface for load cases and combinations.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ICase in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Structure.Loads.[ModalCase](/documentation/oM/Adapter/Structure/Loads/ModalCase)
    - Structure.Loads.[Loadcase](/documentation/oM/Analytical/Structure/Loads/Loadcase)
    - Structure.Loads.[LoadCombination](/documentation/oM/Analytical/Structure/Loads/LoadCombination)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Number | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Unique numeric identifier of the case. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Case is null and outputs relevant error message. | - | Structure_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [ICase.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Loads\ICase.cs)

All history and changes of the class can be found by inspection the history.
