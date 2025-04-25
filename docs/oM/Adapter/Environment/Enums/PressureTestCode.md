---
title: PressureTestCode
---

# <small>BH.oM.Environment.SAP.</small>**PressureTestCode**

Code which indicates whether a pressure test has been done, or whether an assumed value is used.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| YesMeasured |  -  |
| YesDesignValue |  -  |
| NoAssumedForCalc |  -  |
| ExisitingDwellingSAPAlgorithm |  -  |
| NewDwellingAverage |  -  |
| YesExistingDwelling |  -  |
| YesMeasuredLowPressure |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum PressureTestCode : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: SAP_oM.dll

The enum is defined in C#. The class definition is available on github:

- [PressureTestCode.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Enums\PressureTestCode.cs)

All history and changes of the class can be found by inspection the history.
