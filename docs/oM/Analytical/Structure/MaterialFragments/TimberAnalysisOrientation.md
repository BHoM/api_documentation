---
title: TimberAnalysisOrientation
---

# Structure.MaterialFragments.TimberAnalysisOrientation

Enum for controlling if analysis parameters of the Timber material should be assigned based on edgewise or flatwise parameters. Only applicable for some engineered timber products, such as LVL.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  Default value. For some timber types with no distinction between edgewise and flatwise behaviour this can be used.  |
| Edgewise |  Stiffness values should be assigned based on Edgewise values, i.e. the material will be applied to an element in a way that the lamination layers are built up perpendicular to the element normal. Generally what should be used if the material is applied to a linear element such as a Bar.  |
| Flatwise |  Stiffness values should be assigned based on Flatwise values, i.e. the material will be applied to an element in a way that the lamination layers are built up along the element normal. Generally what should be used if the material is applied to a surface element such as a Panel.  |


## Code and Schema

### C# implementation

The enum is defined in C#. The class definition is available on github:

- [TimberAnalysisOrientation.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/MaterialFragments/Enums/TimberAnalysisOrientation.cs)

All history and changes of the class can be found by inspection the history.
