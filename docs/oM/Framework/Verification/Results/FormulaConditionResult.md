---
title: FormulaConditionResult
---

# Verification.Results.FormulaConditionResult

Object representing result of FormulaCondition.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FormulaConditionResult in inheriting from the following base type(s) and implements the following interfaces:"

    -  Verification.Results.[IConditionResult](/api_documentation/oM/Framework/Verification/Results/IConditionResult)
    -  Base.[IImmutable](/api_documentation/oM/Framework/Base/IImmutable)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Passed | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Information whether the object passed or failed the condition. Null means inconclusive result. | - |
| Components | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | Values of components (variables) calculated in the process of obtaining the final result. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [FormulaConditionResult.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Results/Conditions/FormulaConditionResult.cs)

All history and changes of the class can be found by inspection the history.
