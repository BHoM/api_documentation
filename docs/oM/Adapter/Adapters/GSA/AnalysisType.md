---
title: AnalysisType
---

# Adapters.GSA.AnalysisType

Controls which type of analysis solver used for a Loadcombination.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| LinearStatic |  Standard linear static solver.  |
| NonLinearStatic |  Full non linear solver making use of the dynamic relaxtion solver.  |
| FormFinding |  Formfinding, using dynamic relaxtion, updating geometry and pre-stress values of the model.  |
| SoapFilm |  Formfinding, using dynamic relaxtion, updating geometry to match specified pre-stress.  |


## Code and Schema

### C# implementation

The enum is defined in C#. The class definition is available on github:

- [AnalysisType.cs](https://github.com/BHoM/GSA_Toolkit/blob/develop/GSA_oM/Enum/AnalysisType.cs)

All history and changes of the class can be found by inspection the history.
