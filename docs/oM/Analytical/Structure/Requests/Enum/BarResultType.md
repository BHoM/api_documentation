---
title: BarResultType
---

# <small>BH.oM.Structure.</small>**BarResultType**

Defines the type of results that should be extracted for BarResultRequests.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| BarForce |  -  |
| BarDeformation |  Local deformation of the bar. All results given in local coordinates.  |
| BarStress |  -  |
| BarStrain |  -  |
| BarDisplacement |  Total displacement of the bar. All results given in global coordinates.  |
| BarModeShape |  Mode shape of the bar. All results given in global coordinates, normalised to 1.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum BarResultType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Structure_oM.dll

The enum is defined in C#. The class definition is available on github:

- [BarResultType.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Requests\Enum\BarResultType.cs)

All history and changes of the class can be found by inspection the history.
