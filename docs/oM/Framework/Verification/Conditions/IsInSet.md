---
title: IsInSet
---

# Verification.Conditions.IsInSet

Condition that verifies if a value extracted from an object is included in the given set of values.

## Class structure

### Implemented interfaces and base types

???+ bhom "The IsInSet in inheriting from the following base type(s) and implements the following interfaces:"

    -  Verification.Conditions.[IValueCondition](/api_documentation/oM/Framework/Verification/Conditions/IValueCondition)
    -  Verification.Conditions.[ICondition](/api_documentation/oM/Framework/Verification/Conditions/ICondition)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ValueSource | [IValueSource](/api_documentation/oM/Framework/Verification/Conditions/IValueSource) | Object defining the source of a value to evaluate. | - |
| Set | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | Set of values for the extracted value to compare against. | - |
| ComparisonConfig | [ComparisonConfig](/api_documentation/oM/Framework/Base/ComparisonConfig) | Options as per how the comparison is computed. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| INestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/api_documentation/oM/Framework/Verification/Conditions/ICondition)&gt; | Extracts the conditions nested inside a given condition, e.g. conditions nested inside logical conditions. | - | Verification_Engine |
| ValueSourceLabel | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a human readable label for a value source embedded in a value condition, based on provided value condition reporting config. | - | Verification_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [IsInSet.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Conditions\IsInSet.cs)

All history and changes of the class can be found by inspection the history.
