---
title: PumpAge
---

# <small>BH.oM.Environment.SAP.</small>**PumpAge**

Code which indicates the pump age.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Unknown |  -  |
| Earlier2012 |  -  |
| Later2013 |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum PumpAge : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: SAP_oM.dll

The C# enum definition is available on github:

- [PumpAge.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Enums\PumpAge.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/PumpAge.json"
}
```

The JSON Schema is available on github here:

- [PumpAge.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/PumpAge.json)
