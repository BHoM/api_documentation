---
title: RunType
---

# <small>BH.oM.Ground.</small>**RunType**

Run type description based on the AGS schema v4.1.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Initial |  -  |
| Reanalysis |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum RunType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Ground_oM.dll

The enum is defined in C#. The class definition is available on github:

- [RunType.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/eNums\RunType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Ground_oM/RunType.json}
```

The JSON Schema is available on github here:

- [RunType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Ground_oM/RunType.json)
