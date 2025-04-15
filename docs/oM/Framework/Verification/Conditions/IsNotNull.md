---
title: IsNotNull
---

# Verification.Conditions.IsNotNull

Condition that verifies whether an object is null.

## Class structure

### Implemented interfaces and base types

???+ bhom "The IsNotNull in inheriting from the following base type(s) and implements the following interfaces:"

    -  Verification.Conditions.[ICondition](/om_documentation/oM/Framework/Verification/Conditions/ICondition)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| INestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/om_documentation/oM/Framework/Verification/Conditions/ICondition)&gt; | Extracts the conditions nested inside a given condition, e.g. conditions nested inside logical conditions. | - | Verification_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [IsNotNull.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Conditions\IsNotNull.cs)

All history and changes of the class can be found by inspection the history.
