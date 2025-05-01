---
title: BuildingType
---

# <small>BH.oM.Environment.Elements.</small>**BuildingType**

The main classification for a building (e.g. Office, Residential)

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| Education |  -  |
| Office |  -  |
| Residential |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum BuildingType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Environment_oM.dll

The enum is defined in C#. The class definition is available on github:

- [BuildingType.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/Elements\Enums\BuildingType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Environment_oM/Elements/BuildingType.json"
}
```

The JSON Schema is available on github here:

- [BuildingType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Environment_oM/Elements/BuildingType.json)
