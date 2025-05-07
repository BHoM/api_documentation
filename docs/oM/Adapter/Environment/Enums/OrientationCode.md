---
title: OrientationCode
---

# <small>BH.oM.Environment.SAP.</small>**OrientationCode**

Code which indicates the compass direction.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Unknown |  -  |
| North |  -  |
| NorthEast |  -  |
| East |  -  |
| SouthEast |  -  |
| South |  -  |
| SouthWest |  -  |
| West |  -  |
| NorthWest |  -  |
| Horizontal |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum OrientationCode : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: SAP_oM.dll

The C# enum definition is available on github:

- [OrientationCode.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Enums\OrientationCode.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/OrientationCode.json"
}
```

The JSON Schema is available on github here:

- [OrientationCode.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/OrientationCode.json)
