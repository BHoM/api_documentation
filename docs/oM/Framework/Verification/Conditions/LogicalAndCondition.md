---
title: LogicalAndCondition
---

# Verification.Conditions.LogicalAndCondition

Condition that contains a collection of nested conditions, which all need to be met for an object to be considered a pass.

## Class structure

### Implemented interfaces and base types

???+ bhom "The LogicalAndCondition in inheriting from the following base type(s) and implements the following interfaces:"

    -  Verification.Conditions.[ILogicalCollectionCondition](/api_documentation/oM/Framework/Verification/Conditions/ILogicalCollectionCondition)
    -  Verification.Conditions.[ILogicalCondition](/api_documentation/oM/Framework/Verification/Conditions/ILogicalCondition)
    -  Verification.Conditions.[ICondition](/api_documentation/oM/Framework/Verification/Conditions/ICondition)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Conditions | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICondition](/api_documentation/oM/Framework/Verification/Conditions/ICondition)&gt; | A collection of conditions to be evaluated in combination. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| INestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/api_documentation/oM/Framework/Verification/Conditions/ICondition)&gt; | Extracts the conditions nested inside a given condition, e.g. conditions nested inside logical conditions. | - | Verification_Engine |
| NestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/api_documentation/oM/Framework/Verification/Conditions/ICondition)&gt; | Extracts the conditions nested inside a given logical condition. | - | Verification_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [LogicalAndCondition.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Conditions/Logical/LogicalAndCondition.cs)

All history and changes of the class can be found by inspection the history.
