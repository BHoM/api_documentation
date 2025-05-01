---
title: PartName
---

# <small>BH.oM.dKoP.</small>**PartName**



## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| WallInternal |  -  |
| WallExternal |  -  |
| WallParty |  -  |
| Partition |  -  |
| FloorUpper |  -  |
| RoofPitched |  -  |
| RoofFlat |  -  |
| Truss |  -  |
| Ceiling |  -  |
| StairInternal |  -  |
| StairExternal |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum PartName : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: dKoP_oM.dll

The enum is defined in C#. The class definition is available on github:

- [PartName.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/AdministrativeInformation\Enums\PartNames.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/PartName.json"
}
```

The JSON Schema is available on github here:

- [PartName.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/PartName.json)
