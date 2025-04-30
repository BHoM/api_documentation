---
title: ItemState
---

# <small>BH.oM.Planning.</small>**ItemState**



## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Open |  -  |
| Closed |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum ItemState : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Planning_oM.dll

The enum is defined in C#. The class definition is available on github:

- [ItemState.cs](https://github.com/BHoM/BHoM/blob/develop/Planning_oM/Enums\ItemState.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Planning_oM/ItemState.json}
```

The JSON Schema is available on github here:

- [ItemState.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Planning_oM/ItemState.json)
