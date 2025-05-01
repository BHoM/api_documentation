---
title: Roughness
---

# <small>BH.oM.Environment.MaterialFragments.</small>**Roughness**

Required for some calculations, such as determining the convective heat transfer coefficient

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| VeryRough |  -  |
| MediumRough |  -  |
| Rough |  -  |
| Smooth |  -  |
| MediumSmooth |  -  |
| VerySmooth |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum Roughness : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Environment_oM.dll

The C# enum definition is available on github:

- [Roughness.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/MaterialFragments\Enums\Roughness.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Environment_oM/MaterialFragments/Roughness.json"
}
```

The JSON Schema is available on github here:

- [Roughness.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Environment_oM/MaterialFragments/Roughness.json)
