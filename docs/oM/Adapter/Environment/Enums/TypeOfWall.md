---
title: TypeOfWall
---

# <small>BH.oM.Environment.SAP.</small>**TypeOfWall**

Code which indicates the type of wall (exposure).

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| BasementWall |  -  |
| ExposedWall |  -  |
| ShelteredWall |  -  |
| PartyWall |  -  |
| InternalWall |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum TypeOfWall : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: SAP_oM.dll

The C# enum definition is available on github:

- [TypeOfWall.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Enums\TypeOfWall.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/TypeOfWall.json"
}
```

The JSON Schema is available on github here:

- [TypeOfWall.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/TypeOfWall.json)
