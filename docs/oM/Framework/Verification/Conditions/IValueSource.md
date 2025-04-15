---
title: IValueSource
---

# Verification.Conditions.IValueSource

Interface for objects defining how to extract a value from an object.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IValueSource in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.Revit.Parameters.[ParameterValueSource](/om_documentation/oM/Adapter/Adapters/Revit/Parameters/ParameterValueSource)
    - Verification.Conditions.[PropertyValueSource](/om_documentation/oM/Framework/Verification/Conditions/PropertyValueSource)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IValueSourceLabel | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a human readable label for a value source based on provided value condition reporting config. | - | Verification_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IValueSource.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Conditions/Interfaces/IValueSource.cs)

All history and changes of the class can be found by inspection the history.
