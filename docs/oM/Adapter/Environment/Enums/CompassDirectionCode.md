---
title: CompassDirectionCode
---

# <small>BH.oM.Environment.</small>**CompassDirectionCode**

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

The enum is defined in C#. The class definition is available on github:

- [CompassDirectionCode.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Enums\CompassDirectionCode.cs)

All history and changes of the class can be found by inspection the history.
