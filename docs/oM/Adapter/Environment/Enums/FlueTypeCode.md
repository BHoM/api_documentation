---
title: FlueTypeCode
---

# <small>BH.oM.Environment.SAP.</small>**FlueTypeCode**

Code which indicates the type of flue.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| OpenFlue |  -  |
| BalancedFlue |  -  |
| Chimney |  -  |
| Omitted |  -  |
| Unknown |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum FlueTypeCode : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: SAP_oM.dll

The C# enum definition is available on github:

- [FlueTypeCode.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Enums\FlueTypeCode.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/FlueTypeCode.json"
}
```

The JSON Schema is available on github here:

- [FlueTypeCode.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/FlueTypeCode.json)
