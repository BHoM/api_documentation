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

The enum is defined in C#. The class definition is available on github:

- [EvalueViewEnum.cs](https://github.com/BHoM/BHoM/blob/develop/Humans_oM/ViewQuality\EvalueViewEnum.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Humans_oM/ViewQuality/EvalueViewEnum.json}
```

The JSON Schema is available on github here:

- [EvalueViewEnum.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Humans_oM/ViewQuality/EvalueViewEnum.json)
