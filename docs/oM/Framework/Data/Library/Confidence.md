---
title: Confidence
---

# Data.Library.Confidence

Level of confidence for the serialized DataSet, outlining both the reliability of the source and the fidelity of the dataset to that source.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  Default value - assume no fidelity and no source.  |
| None |  The Dataset may not have a reliable source and/or fidelity to the source has not been tested  |
| Low |  The Dataset comes from an unreliable source and matches the source based on initial checks.  |
| Medium |  The Dataset comes from a reliable source and matches the source based on initial checks.  |
| High |  The Dataset comes from a reliable source and matches the source based on extensive review and testing.  |


## Code and Schema

### C# implementation

The enum is defined in C#. The class definition is available on github:

- [Confidence.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Library\Confidence.cs)

All history and changes of the class can be found by inspection the history.
