---
title: SingleLogicalConditionResult
---

# Verification.Results.SingleLogicalConditionResult

Object representing result of ISingleLogicalCondition.

## Class structure

### Implemented interfaces and base types

???+ bhom "The SingleLogicalConditionResult in inheriting from the following base type(s) and implements the following interfaces:"

    -  Verification.Results.[IConditionResult](/documentation/oM/Framework/Verification/Results/IConditionResult)
    -  Base.[IImmutable](/documentation/oM/Framework/Base/IImmutable)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Passed | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Information whether the object passed or failed the condition. Null means inconclusive result. | - |
| Result | [IConditionResult](/documentation/oM/Framework/Verification/Results/IConditionResult) | Results of the nested condition. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [SingleLogicalConditionResult.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Results/Conditions/SingleLogicalConditionResult.cs)

All history and changes of the class can be found by inspection the history.
