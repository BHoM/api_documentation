---
title: TimberAnalysisDominantLoadCondition
---

# <small>BH.oM.Structure.MaterialFragments.</small>**TimberAnalysisDominantLoadCondition**

Enum for controlling if analysis parameters of the Timber material should be assigned based on values for bending or axial stiffness.
Only relevant for some engineered timber products.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  Default value. For some timber types where the stiffness values are independant on load condition this can be used..  |
| Axial |  The element with the Timber material will have loads resulting in axial stresses as the predominant load condition.  |
| Bending |  The element with the Timber material will have loads resulting in bending stresses as the predominant load condition.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum TimberAnalysisDominantLoadCondition : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Structure_oM.dll

The C# enum definition is available on github:

- [TimberAnalysisDominantLoadCondition.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/MaterialFragments\Enums\TimberAnalysisDominantLoadCondition.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/MaterialFragments/TimberAnalysisDominantLoadCondition.json"
}
```

The JSON Schema is available on github here:

- [TimberAnalysisDominantLoadCondition.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/MaterialFragments/TimberAnalysisDominantLoadCondition.json)
