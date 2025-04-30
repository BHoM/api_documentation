---
title: AnalysisType
---

# <small>BH.oM.Adapters.GSA.</small>**AnalysisType**

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

``` C# title="C#"
public enum AnalysisType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: GSA_oM.dll

The enum is defined in C#. The class definition is available on github:

- [AnalysisType.cs](https://github.com/BHoM/GSA_Toolkit/blob/develop/GSA_oM/Enum\AnalysisType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/GSA_oM/AnalysisType.json}
```

The JSON Schema is available on github here:

- [AnalysisType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/GSA_oM/AnalysisType.json)
