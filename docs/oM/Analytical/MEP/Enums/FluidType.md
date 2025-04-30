---
title: FluidType
---

# <small>BH.oM.MEP.Enums.</small>**FluidType**

A fluid type that flows within any system's flow objects.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| Air |  -  |
| ColdWater |  -  |
| Electricity |  -  |
| HotWater |  -  |
| Sanitary |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum FluidType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: MEP_oM.dll

The enum is defined in C#. The class definition is available on github:

- [FluidType.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/Enums\FluidType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/MEP_oM/Enums/FluidType.json}
```

The JSON Schema is available on github here:

- [FluidType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/MEP_oM/Enums/FluidType.json)
