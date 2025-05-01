---
title: EvalueViewEnum
---

# <small>BH.oM.Humans.ViewQuality.</small>**EvalueViewEnum**



## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| ToPoint |  Specifies the direction used to evalaute Evalue, ToPoint uses the ActivivtyArea FocalPoint to define view direction  |
| PerpendicularToRow |  -  |
| Undefined |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum EvalueViewEnum : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Humans_oM.dll

The C# enum definition is available on github:

- [EvalueViewEnum.cs](https://github.com/BHoM/BHoM/blob/develop/Humans_oM/ViewQuality\EvalueViewEnum.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Humans_oM/ViewQuality/EvalueViewEnum.json"
}
```

The JSON Schema is available on github here:

- [EvalueViewEnum.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Humans_oM/ViewQuality/EvalueViewEnum.json)
