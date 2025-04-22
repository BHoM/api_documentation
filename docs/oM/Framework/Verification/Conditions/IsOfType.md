---
title: IsOfType
---

# Verification.Conditions.IsOfType

Condition that verifies whether an object is of a given type.

## Class structure

### Implemented interfaces and base types

???+ bhom "The IsOfType in inheriting from the following base type(s) and implements the following interfaces:"

    -  Verification.Conditions.[ICondition](/api_documentation/oM/Framework/Verification/Conditions/ICondition)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Type | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | Type specified as System.Type or string representing type full name. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| INestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/api_documentation/oM/Framework/Verification/Conditions/ICondition)&gt; | Extracts the conditions nested inside a given condition, e.g. conditions nested inside logical conditions. | - | Verification_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [IsOfType.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Conditions\IsOfType.cs)

All history and changes of the class can be found by inspection the history.
