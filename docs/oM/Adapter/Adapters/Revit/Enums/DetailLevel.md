---
title: DetailLevel
---

# <small>BH.oM.Adapters.Revit.Enums.</small>**DetailLevel**

Enum specifying detail level of representation, correspondent to level of detail in Revit.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Coarse |  Coarse - correspondent to Revit level of detail with same name.  |
| Medium |  Medium - correspondent to Revit level of detail with same name.  |
| Fine |  Fine - correspondent to Revit level of detail with same name.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum DetailLevel : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Revit_oM.dll

The C# enum definition is available on github:

- [DetailLevel.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Enums\DetailLevel.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Revit_oM/Enums/DetailLevel.json"
}
```

The JSON Schema is available on github here:

- [DetailLevel.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Revit_oM/Enums/DetailLevel.json)
