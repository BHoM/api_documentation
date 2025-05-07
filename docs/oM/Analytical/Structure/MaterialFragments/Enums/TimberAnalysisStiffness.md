---
title: TimberAnalysisStiffness
---

# <small>BH.oM.Structure.MaterialFragments.</small>**TimberAnalysisStiffness**

Enum for controling if analysis parameters of the Timber material should be assigned based on Characteristic or Mean stiffness parameters.
Refer to design codes and guidance literature to determine when each set of properties is applicable.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Characteristic |  -  |
| Mean |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum TimberAnalysisStiffness : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Structure_oM.dll

The C# enum definition is available on github:

- [TimberAnalysisStiffness.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/MaterialFragments\Enums\TimberAnalysisStiffness.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/MaterialFragments/TimberAnalysisStiffness.json"
}
```

The JSON Schema is available on github here:

- [TimberAnalysisStiffness.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/MaterialFragments/TimberAnalysisStiffness.json)
