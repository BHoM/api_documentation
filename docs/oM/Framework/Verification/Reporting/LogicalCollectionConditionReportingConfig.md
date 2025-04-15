---
title: LogicalCollectionConditionReportingConfig
---

# Verification.Reporting.LogicalCollectionConditionReportingConfig

Config object containing settings for reporting results of checks against logical conditions with a collection of nested conditions.

## Class structure

### Implemented interfaces and base types

???+ bhom "The LogicalCollectionConditionReportingConfig in inheriting from the following base type(s) and implements the following interfaces:"

    -  Verification.Reporting.[IConditionReportingConfig](/documentation/oM/Framework/Verification/Reporting/IConditionReportingConfig)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| NestedConfigs | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[ICondition](/documentation/oM/Framework/Verification/Conditions/ICondition), [IConditionReportingConfig](/documentation/oM/Framework/Verification/Reporting/IConditionReportingConfig)&gt; | Dictionary of reporting configs (values) bound to the conditions, which results they are meant to format (keys). | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [LogicalCollectionConditionReportingConfig.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Reporting\LogicalCollectionConditionReportingConfig.cs)

All history and changes of the class can be found by inspection the history.
