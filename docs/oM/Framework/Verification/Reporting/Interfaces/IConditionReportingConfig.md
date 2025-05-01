---
title: IConditionReportingConfig
---

# <small>BH.oM.Verification.Reporting.</small>**IConditionReportingConfig**

Top interface for all condition reporting config objects.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IConditionReportingConfig is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Verification.Reporting.[IValueConditionReportingConfig](/api/oM/Framework/Verification/Reporting/Interfaces/IValueConditionReportingConfig)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Verification.Reporting.[FormulaConditionReportingConfig](/api/oM/Framework/Verification/Reporting/FormulaConditionReportingConfig)
    - BH.oM.Verification.Reporting.[LogicalCollectionConditionReportingConfig](/api/oM/Framework/Verification/Reporting/LogicalCollectionConditionReportingConfig)
    - BH.oM.Verification.Reporting.[NumberConditionReportingConfig](/api/oM/Framework/Verification/Reporting/NumberConditionReportingConfig)
    - BH.oM.Verification.Reporting.[SingleLogicalConditionReportingConfig](/api/oM/Framework/Verification/Reporting/SingleLogicalConditionReportingConfig)
    - BH.oM.Verification.Reporting.[ValueConditionReportingConfig](/api/oM/Framework/Verification/Reporting/ValueConditionReportingConfig)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IConditionReportingConfig : BH.oM.Base.IObject
```

Assembly: Verification_oM.dll

The C# interface definition is available on github:

- [IConditionReportingConfig.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Reporting\Interfaces\IConditionReportingConfig.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Verification_oM/Reporting/IConditionReportingConfig.json"
}
```

The JSON Schema is available on github here:

- [IConditionReportingConfig.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Verification_oM/Reporting/IConditionReportingConfig.json)
