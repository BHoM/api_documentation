---
title: EmitterTemperatureCode
---

# <small>BH.oM.Environment.SAP.</small>**EmitterTemperatureCode**

Code which specifies the emitter temperature.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Unknown |  -  |
| Over45 |  -  |
| Over35 |  -  |
| Over35LessThanOrEqual45 |  -  |
| LessThanOrEqual35 |  -  |
| NotApplicable |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum EmitterTemperatureCode : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: SAP_oM.dll

The enum is defined in C#. The class definition is available on github:

- [EmitterTemperatureCode.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Enums\EmitterTemperatureCode.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/EmitterTemperatureCode.json}
```

The JSON Schema is available on github here:

- [EmitterTemperatureCode.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/EmitterTemperatureCode.json)
