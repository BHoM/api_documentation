---
title: ILogicalCondition
---

# Verification.Conditions.ILogicalCondition

Interface for all logical conditions (AND, OR, NOT etc.).

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ILogicalCondition in inheriting from the following base type(s) and implements the following interfaces:"

    -  Verification.Conditions.[ICondition](/api_documentation/oM/Framework/Verification/Conditions/ICondition)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Verification.Conditions.[ILogicalCollectionCondition](/api_documentation/oM/Framework/Verification/Conditions/ILogicalCollectionCondition)
    - Verification.Conditions.[ISingleLogicalCondition](/api_documentation/oM/Framework/Verification/Conditions/ISingleLogicalCondition)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Verification.Conditions.[LogicalAndCondition](/api_documentation/oM/Framework/Verification/Conditions/LogicalAndCondition)
    - Verification.Conditions.[LogicalNotCondition](/api_documentation/oM/Framework/Verification/Conditions/LogicalNotCondition)
    - Verification.Conditions.[LogicalOrCondition](/api_documentation/oM/Framework/Verification/Conditions/LogicalOrCondition)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| INestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/api_documentation/oM/Framework/Verification/Conditions/ICondition)&gt; | Extracts the conditions nested inside a given condition, e.g. conditions nested inside logical conditions. | - | Verification_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [ILogicalCondition.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Conditions/Interfaces/ILogicalCondition.cs)

All history and changes of the class can be found by inspection the history.
