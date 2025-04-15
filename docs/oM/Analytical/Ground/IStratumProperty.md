---
title: IStratumProperty
---

# Ground.IStratumProperty

Base interface for stratum properties.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IStratumProperty in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Ground.[StratumReference](/om_documentation/oM/Analytical/Ground/StratumReference)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a IStratumProperties is valid and outputs relevant error message. | - | Ground_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IStratumProperty.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/StratumProperties/IStratumProperty.cs)

All history and changes of the class can be found by inspection the history.
