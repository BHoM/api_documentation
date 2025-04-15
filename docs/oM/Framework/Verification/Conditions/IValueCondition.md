---
title: IValueCondition
---

# Verification.Conditions.IValueCondition

Interface for conditions that evaluate a value derived from an object against certain criteria.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IValueCondition in inheriting from the following base type(s) and implements the following interfaces:"

    -  Verification.Conditions.[ICondition](/documentation/oM/Framework/Verification/Conditions/ICondition)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Verification.Conditions.[HasValue](/documentation/oM/Framework/Verification/Conditions/HasValue)
    - Verification.Conditions.[IsInDomain](/documentation/oM/Framework/Verification/Conditions/IsInDomain)
    - Verification.Conditions.[IsInSet](/documentation/oM/Framework/Verification/Conditions/IsInSet)
    - Verification.Conditions.[ValueCondition](/documentation/oM/Framework/Verification/Conditions/ValueCondition)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ValueSource | [IValueSource](/documentation/oM/Framework/Verification/Conditions/IValueSource) | Object defining how to extract a value from an object. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| INestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/documentation/oM/Framework/Verification/Conditions/ICondition)&gt; | Extracts the conditions nested inside a given condition, e.g. conditions nested inside logical conditions. | - | Verification_Engine |
| ValueSourceLabel | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a human readable label for a value source embedded in a value condition, based on provided value condition reporting config. | - | Verification_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IValueCondition.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Conditions/Interfaces/IValueCondition.cs)

All history and changes of the class can be found by inspection the history.
