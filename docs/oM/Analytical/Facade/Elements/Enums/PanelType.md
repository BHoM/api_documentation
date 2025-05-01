---
title: PanelType
---

# <small>BH.oM.Facade.Elements.</small>**PanelType**

The type of surface (e.g. AirGap, Internal Wall, External Wall, etc.)

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| AirGap |  -  |
| Shade |  -  |
| Spandrel |  -  |
| WallExternal |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum PanelType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Facade_oM.dll

The enum is defined in C#. The class definition is available on github:

- [PanelType.cs](https://github.com/BHoM/BHoM/blob/develop/Facade_oM/Elements\Enums\PanelType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Facade_oM/Elements/PanelType.json"
}
```

The JSON Schema is available on github here:

- [PanelType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Facade_oM/Elements/PanelType.json)
