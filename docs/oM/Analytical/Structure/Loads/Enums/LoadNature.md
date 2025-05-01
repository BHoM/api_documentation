---
title: LoadNature
---

# <small>BH.oM.Structure.Loads.</small>**LoadNature**



## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Dead |  -  |
| SuperDead |  -  |
| Live |  -  |
| Wind |  -  |
| Seismic |  -  |
| Temperature |  -  |
| Snow |  -  |
| Accidental |  -  |
| Prestress |  -  |
| Notional |  -  |
| Other |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum LoadNature : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Structure_oM.dll

The C# enum definition is available on github:

- [LoadNature.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Loads\Enums\LoadNature.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/Loads/LoadNature.json"
}
```

The JSON Schema is available on github here:

- [LoadNature.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/Loads/LoadNature.json)
