---
title: PullType
---

# <small>BH.oM.Adapter.</small>**PullType**



## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| AdapterDefault |  If this is chosen, then the m_AdapterSettings.DefaultPullType is picked.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum PullType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Adapter_oM.dll

The enum is defined in C#. The class definition is available on github:

- [PullType.cs](https://github.com/BHoM/BHoM_Adapter/blob/develop/Adapter_oM/Enums\PullType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Adapter_oM/PullType.json}
```

The JSON Schema is available on github here:

- [PullType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Adapter_oM/PullType.json)
