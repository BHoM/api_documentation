---
title: IConditionResult
---

# Verification.Results.IConditionResult

Top interface for all condition results.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IConditionResult in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IImmutable](/documentation/oM/Framework/Base/IImmutable)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Verification.Results.[FormulaConditionResult](/documentation/oM/Framework/Verification/Results/FormulaConditionResult)
    - Verification.Results.[IsNotNullResult](/documentation/oM/Framework/Verification/Results/IsNotNullResult)
    - Verification.Results.[IsOfTypeResult](/documentation/oM/Framework/Verification/Results/IsOfTypeResult)
    - Verification.Results.[LogicalCollectionConditionResult](/documentation/oM/Framework/Verification/Results/LogicalCollectionConditionResult)
    - Verification.Results.[SingleLogicalConditionResult](/documentation/oM/Framework/Verification/Results/SingleLogicalConditionResult)
    - Verification.Results.[ValueConditionResult](/documentation/oM/Framework/Verification/Results/ValueConditionResult)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Passed | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Information whether the object passed or failed the condition. Null means inconclusive result. | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IConditionResult.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Results/Conditions/IConditionResult.cs)

All history and changes of the class can be found by inspection the history.
