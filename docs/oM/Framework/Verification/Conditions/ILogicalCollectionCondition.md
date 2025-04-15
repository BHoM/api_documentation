---
title: ILogicalCollectionCondition
---

# Verification.Conditions.ILogicalCollectionCondition

Interface for logical conditions consisting of a collection of nested conditions to be evaluated in combination (AND, OR etc.).

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ILogicalCollectionCondition in inheriting from the following base type(s) and implements the following interfaces:"

    -  Verification.Conditions.[ILogicalCondition](/documentation/oM/Framework/Verification/Conditions/ILogicalCondition)
    -  Verification.Conditions.[ICondition](/documentation/oM/Framework/Verification/Conditions/ICondition)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Verification.Conditions.[LogicalAndCondition](/documentation/oM/Framework/Verification/Conditions/LogicalAndCondition)
    - Verification.Conditions.[LogicalOrCondition](/documentation/oM/Framework/Verification/Conditions/LogicalOrCondition)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Conditions | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICondition](/documentation/oM/Framework/Verification/Conditions/ICondition)&gt; | A collection of conditions to be evaluated in combination. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| INestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/documentation/oM/Framework/Verification/Conditions/ICondition)&gt; | Extracts the conditions nested inside a given condition, e.g. conditions nested inside logical conditions. | - | Verification_Engine |
| NestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/documentation/oM/Framework/Verification/Conditions/ICondition)&gt; | Extracts the conditions nested inside a given logical condition. | - | Verification_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [ILogicalCollectionCondition.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Conditions/Interfaces/ILogicalCollectionCondition.cs)

All history and changes of the class can be found by inspection the history.
