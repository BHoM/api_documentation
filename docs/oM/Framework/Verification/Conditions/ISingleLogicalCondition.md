---
title: ISingleLogicalCondition
---

# Verification.Conditions.ISingleLogicalCondition

Interface for logical conditions consisting of a single nested condition (e.g. NOT).

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISingleLogicalCondition in inheriting from the following base type(s) and implements the following interfaces:"

    -  Verification.Conditions.[ILogicalCondition](/api_documentation/oM/Framework/Verification/Conditions/ILogicalCondition)
    -  Verification.Conditions.[ICondition](/api_documentation/oM/Framework/Verification/Conditions/ICondition)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Verification.Conditions.[LogicalNotCondition](/api_documentation/oM/Framework/Verification/Conditions/LogicalNotCondition)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Condition | [ICondition](/api_documentation/oM/Framework/Verification/Conditions/ICondition) | Nested condition to be wrapped in the ISingleLogicalCondition. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| INestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/api_documentation/oM/Framework/Verification/Conditions/ICondition)&gt; | Extracts the conditions nested inside a given condition, e.g. conditions nested inside logical conditions. | - | Verification_Engine |
| NestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/api_documentation/oM/Framework/Verification/Conditions/ICondition)&gt; | Extracts the conditions nested inside a given logical condition. | - | Verification_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [ISingleLogicalCondition.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Conditions/Interfaces/ISingleLogicalCondition.cs)

All history and changes of the class can be found by inspection the history.
