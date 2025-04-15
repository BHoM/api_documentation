---
title: IConditionBasedFilter
---

# Verification.Extraction.IConditionBasedFilter

Interface for all extraction workflows based on 'filter by' modes.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IConditionBasedFilter in inheriting from the following base type(s) and implements the following interfaces:"

    -  Verification.Extraction.[IExtraction](/om_documentation/oM/Framework/Verification/Extraction/IExtraction)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Verification.Extraction.[ConditionBasedFilter](/om_documentation/oM/Framework/Verification/Extraction/ConditionBasedFilter)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Condition | [ICondition](/om_documentation/oM/Framework/Verification/Conditions/ICondition) | Filtering condition to be met for objects to be returned. | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IConditionBasedFilter.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Extraction/Interfaces/IConditionBasedFilter.cs)

All history and changes of the class can be found by inspection the history.
