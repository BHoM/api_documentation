---
title: ICondition
---

# Verification.Conditions.ICondition

Top level interface for conditions: lightweight objects describing a yes/no question to be asked against another object.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ICondition in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/api/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Verification.Conditions.[ILogicalCollectionCondition](/api/oM/Framework/Verification/Conditions/ILogicalCollectionCondition)
    - Verification.Conditions.[ILogicalCondition](/api/oM/Framework/Verification/Conditions/ILogicalCondition)
    - Verification.Conditions.[ISingleLogicalCondition](/api/oM/Framework/Verification/Conditions/ISingleLogicalCondition)
    - Verification.Conditions.[IValueCondition](/api/oM/Framework/Verification/Conditions/IValueCondition)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Verification.Conditions.[FormulaCondition](/api/oM/Framework/Verification/Conditions/FormulaCondition)
    - Verification.Conditions.[HasId](/api/oM/Framework/Verification/Conditions/HasId)
    - Verification.Conditions.[HasValue](/api/oM/Framework/Verification/Conditions/HasValue)
    - Verification.Conditions.[IsInDomain](/api/oM/Framework/Verification/Conditions/IsInDomain)
    - Verification.Conditions.[IsInSet](/api/oM/Framework/Verification/Conditions/IsInSet)
    - Verification.Conditions.[IsNotNull](/api/oM/Framework/Verification/Conditions/IsNotNull)
    - Verification.Conditions.[IsOfType](/api/oM/Framework/Verification/Conditions/IsOfType)
    - Verification.Conditions.[LogicalAndCondition](/api/oM/Framework/Verification/Conditions/LogicalAndCondition)
    - Verification.Conditions.[LogicalNotCondition](/api/oM/Framework/Verification/Conditions/LogicalNotCondition)
    - Verification.Conditions.[LogicalOrCondition](/api/oM/Framework/Verification/Conditions/LogicalOrCondition)
    - Verification.Conditions.[ValueCondition](/api/oM/Framework/Verification/Conditions/ValueCondition)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| INestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/api/oM/Framework/Verification/Conditions/ICondition)&gt; | Extracts the conditions nested inside a given condition, e.g. conditions nested inside logical conditions. | - | Verification_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [ICondition.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Conditions/Interfaces/ICondition.cs)

All history and changes of the class can be found by inspection the history.
