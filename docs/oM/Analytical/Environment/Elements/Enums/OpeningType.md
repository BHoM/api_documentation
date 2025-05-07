---
title: OpeningType
---

# <small>BH.oM.Environment.Elements.</small>**OpeningType**

The type of cutout or hole in a building surface/panel (e.g. Window, Door, Rooflight)

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| CurtainWall |  -  |
| Door |  -  |
| Frame |  -  |
| Glazing |  -  |
| Hole |  -  |
| Rooflight |  -  |
| RooflightWithFrame |  -  |
| Window |  -  |
| WindowWithFrame |  -  |
| VehicleDoor |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum OpeningType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Environment_oM.dll

The C# enum definition is available on github:

- [OpeningType.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/Elements\Enums\OpeningType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Environment_oM/Elements/OpeningType.json"
}
```

The JSON Schema is available on github here:

- [OpeningType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Environment_oM/Elements/OpeningType.json)
