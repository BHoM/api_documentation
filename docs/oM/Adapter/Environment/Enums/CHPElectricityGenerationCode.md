---
title: CHPElectricityGenerationCode
---

# <small>BH.oM.Environment.SAP.</small>**CHPElectricityGenerationCode**

Code which indicates the CHP Electricity generation option (table 12f).

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| NewCHPExportOnly |  -  |
| NewCHPFlexibleOperation |  -  |
| NewCHPStandard |  -  |
| ExistingCHP2015ExportOnly |  -  |
| ExistingCHP2015FlexibleOperation |  -  |
| ExistingCHP2015Standard |  -  |
| ExistingCHPPre2015ExportOnly |  -  |
| ExistingCHPPre2015FlexibleOperation |  -  |
| ExistingCHPPre2015Standard |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum CHPElectricityGenerationCode : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: SAP_oM.dll

The C# enum definition is available on github:

- [CHPElectricityGenerationCode.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Enums\CHPElectricityGenerationCode.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/CHPElectricityGenerationCode.json"
}
```

The JSON Schema is available on github here:

- [CHPElectricityGenerationCode.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/CHPElectricityGenerationCode.json)
