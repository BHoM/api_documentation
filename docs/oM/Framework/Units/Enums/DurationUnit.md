---
title: DurationUnit
---

# <small>BH.oM.Units.</small>**DurationUnit**



## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| Millisecond |  -  |
| Second |  -  |
| Minute |  -  |
| Hour |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum DurationUnit : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Units_oM.dll

The enum is defined in C#. The class definition is available on github:

- [DurationUnit.cs](https://github.com/BHoM/Localisation_Toolkit/blob/develop/Units_oM/Enums\DurationUnit.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Units_oM/DurationUnit.json}
```

The JSON Schema is available on github here:

- [DurationUnit.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Units_oM/DurationUnit.json)
