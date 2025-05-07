---
title: ValueConditionReportingConfig
---

# <small>BH.oM.Verification.Reporting.</small>**ValueConditionReportingConfig**

Config object containing settings for reporting results of checks against value conditions.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ValueConditionReportingConfig is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Verification.Reporting.[IValueConditionReportingConfig](/api/oM/Framework/Verification/Reporting/Interfaces/IValueConditionReportingConfig)
    -  BH.oM.Verification.Reporting.[IConditionReportingConfig](/api/oM/Framework/Verification/Reporting/Interfaces/IConditionReportingConfig)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes inheriting from this class

???+ bhom "The following classes are inheriting from this class:"

    - BH.oM.Verification.Reporting.[NumberConditionReportingConfig](/api/oM/Framework/Verification/Reporting/NumberConditionReportingConfig)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ValueSourceLabelOverride | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Override text to be used as a label for value source. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ValueConditionReportingConfig : BH.oM.Verification.Reporting.IValueConditionReportingConfig,
BH.oM.Verification.Reporting.IConditionReportingConfig,
BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The C# class definition is available on github:

- [ValueConditionReportingConfig.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Reporting\ValueConditionReportingConfig.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Verification_oM/Reporting/ValueConditionReportingConfig.json"
}
```

The JSON Schema is available on github here:

- [ValueConditionReportingConfig.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Verification_oM/Reporting/ValueConditionReportingConfig.json)
