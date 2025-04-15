---
title: FormulaConditionReportingConfig
---

# Verification.Reporting.FormulaConditionReportingConfig

Config object containing settings for reporting results of checks against formula conditions.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FormulaConditionReportingConfig in inheriting from the following base type(s) and implements the following interfaces:"

    -  Verification.Reporting.[IConditionReportingConfig](/documentation/oM/Framework/Verification/Reporting/IConditionReportingConfig)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ComponentConfigs | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [IValueConditionReportingConfig](/documentation/oM/Framework/Verification/Reporting/IValueConditionReportingConfig)&gt; | Dictionary of reporting configs (values) bound to the components, which values they are meant to format (keys). | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [FormulaConditionReportingConfig.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Reporting\FormulaConditionReportingConfig.cs)

All history and changes of the class can be found by inspection the history.
