---
title: NumberConditionReportingConfig
---

# Verification.Reporting.NumberConditionReportingConfig

Config object containing settings for reporting results of checks against numerical value conditions.

## Class structure

### Implemented interfaces and base types

???+ bhom "The NumberConditionReportingConfig in inheriting from the following base type(s) and implements the following interfaces:"

    -  Verification.Reporting.[ValueConditionReportingConfig](/api/oM/Framework/Verification/Reporting/ValueConditionReportingConfig)
    -  Verification.Reporting.[IValueConditionReportingConfig](/api/oM/Framework/Verification/Reporting/IValueConditionReportingConfig)
    -  Verification.Reporting.[IConditionReportingConfig](/api/oM/Framework/Verification/Reporting/IConditionReportingConfig)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| UnitLabel | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Text to be used as a label for units expressing the extracted value. | - |
| ValueMultiplier | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Multiplier to be applied to the extracted value prior to reporting. | - |
| RoundingAccuracy | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Rounding accuracy to be used when reporting the extracted value. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ValueSourceLabelOverride | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Override text to be used as a label for value source. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [NumberConditionReportingConfig.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Reporting\NumberConditionReportingConfig.cs)

All history and changes of the class can be found by inspection the history.
