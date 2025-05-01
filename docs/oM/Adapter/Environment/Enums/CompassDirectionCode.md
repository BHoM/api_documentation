---
title: CompassDirectionCode
---

# <small>BH.oM.Environment.SAP.</small>**CompassDirectionCode**

Code which indicates the compass direction.  Like OrientationCode, but without the "unknown" and "horizontal" options.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| North |  -  |
| NorthEast |  -  |
| East |  -  |
| SouthEast |  -  |
| South |  -  |
| SouthWest |  -  |
| West |  -  |
| NorthWest |  -  |
| ToBeUsedWhenThePitchIsHorizontal |  -  |
| NotRecordedForBackwardsCompatibilityOnlyDoNotUse |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum CompassDirectionCode : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: SAP_oM.dll

The C# enum definition is available on github:

- [CompassDirectionCode.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Enums\CompassDirectionCode.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/CompassDirectionCode.json"
}
```

The JSON Schema is available on github here:

- [CompassDirectionCode.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/CompassDirectionCode.json)
