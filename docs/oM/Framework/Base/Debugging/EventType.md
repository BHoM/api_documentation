---
title: EventType
---

# <small>BH.oM.Base.Debugging.</small>**EventType**



## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Unknown |  -  |
| Error |  -  |
| Warning |  -  |
| Note |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum EventType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: BHoM.dll

The enum is defined in C#. The class definition is available on github:

- [EventType.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Debugging\EventType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/BHoM/Debugging/EventType.json}
```

The JSON Schema is available on github here:

- [EventType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/BHoM/Debugging/EventType.json)
