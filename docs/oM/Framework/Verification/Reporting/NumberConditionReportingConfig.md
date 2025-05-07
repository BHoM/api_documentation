---
title: NumberConditionReportingConfig
---

# <small>BH.oM.Verification.Reporting.</small>**NumberConditionReportingConfig**

Config object containing settings for reporting results of checks against numerical value conditions.

## Class structure

### Implemented interfaces and base types

???+ bhom "The NumberConditionReportingConfig is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Verification.Reporting.[ValueConditionReportingConfig](/api/oM/Framework/Verification/Reporting/ValueConditionReportingConfig)
    -  BH.oM.Verification.Reporting.[IValueConditionReportingConfig](/api/oM/Framework/Verification/Reporting/Interfaces/IValueConditionReportingConfig)
    -  BH.oM.Verification.Reporting.[IConditionReportingConfig](/api/oM/Framework/Verification/Reporting/Interfaces/IConditionReportingConfig)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


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

``` C# title="C#"
public class NumberConditionReportingConfig : BH.oM.Verification.Reporting.ValueConditionReportingConfig,
BH.oM.Verification.Reporting.IValueConditionReportingConfig,
BH.oM.Verification.Reporting.IConditionReportingConfig,
BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The C# class definition is available on github:

- [NumberConditionReportingConfig.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Reporting\NumberConditionReportingConfig.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Verification_oM/Reporting/NumberConditionReportingConfig.json"
}
```

The JSON Schema is available on github here:

- [NumberConditionReportingConfig.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Verification_oM/Reporting/NumberConditionReportingConfig.json)
