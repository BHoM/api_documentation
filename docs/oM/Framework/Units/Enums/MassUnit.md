---
title: MassUnit
---

# <small>BH.oM.Units.</small>**MassUnit**



## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| Gram |  -  |
| Kilogram |  -  |
| LongTon |  -  |
| Milligram |  -  |
| Ounce |  -  |
| Pound |  -  |
| ShortTon |  -  |
| Tonne |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum MassUnit : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Units_oM.dll

The enum is defined in C#. The class definition is available on github:

- [MassUnit.cs](https://github.com/BHoM/Localisation_Toolkit/blob/develop/Units_oM/Enums\MassUnit.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Units_oM/MassUnit.json}
```

The JSON Schema is available on github here:

- [MassUnit.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Units_oM/MassUnit.json)
