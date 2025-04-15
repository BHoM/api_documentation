---
title: LogicalNotCondition
---

# Verification.Conditions.LogicalNotCondition

Condition that contains a nested condition that it inverses, i.e. the nested condition needs to fail for an object to be considered a pass.

## Class structure

### Implemented interfaces and base types

???+ bhom "The LogicalNotCondition in inheriting from the following base type(s) and implements the following interfaces:"

    -  Verification.Conditions.[ISingleLogicalCondition](/om_documentation/oM/Framework/Verification/Conditions/ISingleLogicalCondition)
    -  Verification.Conditions.[ILogicalCondition](/om_documentation/oM/Framework/Verification/Conditions/ILogicalCondition)
    -  Verification.Conditions.[ICondition](/om_documentation/oM/Framework/Verification/Conditions/ICondition)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Condition | [ICondition](/om_documentation/oM/Framework/Verification/Conditions/ICondition) | Condition to be inverted. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| INestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/om_documentation/oM/Framework/Verification/Conditions/ICondition)&gt; | Extracts the conditions nested inside a given condition, e.g. conditions nested inside logical conditions. | - | Verification_Engine |
| NestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/om_documentation/oM/Framework/Verification/Conditions/ICondition)&gt; | Extracts the conditions nested inside a given logical condition. | - | Verification_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [LogicalNotCondition.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Conditions/Logical/LogicalNotCondition.cs)

All history and changes of the class can be found by inspection the history.
