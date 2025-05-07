---
title: TimberAnalysisOrientation
---

# <small>BH.oM.Structure.MaterialFragments.</small>**TimberAnalysisOrientation**

Enum for controlling if analysis parameters of the Timber material should be assigned based on edgewise or flatwise parameters. Only applicable for some engineered timber products, such as LVL.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  Default value. For some timber types with no distinction between edgewise and flatwise behaviour this can be used.  |
| Edgewise |  Stiffness values should be assigned based on Edgewise values, i.e. the material will be applied to an element in a way that the lamination layers are built up perpendicular to the element normal. Generally what should be used if the material is applied to a linear element such as a Bar.  |
| Flatwise |  Stiffness values should be assigned based on Flatwise values, i.e. the material will be applied to an element in a way that the lamination layers are built up along the element normal. Generally what should be used if the material is applied to a surface element such as a Panel.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum TimberAnalysisOrientation : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Structure_oM.dll

The C# enum definition is available on github:

- [TimberAnalysisOrientation.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/MaterialFragments\Enums\TimberAnalysisOrientation.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/MaterialFragments/TimberAnalysisOrientation.json"
}
```

The JSON Schema is available on github here:

- [TimberAnalysisOrientation.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/MaterialFragments/TimberAnalysisOrientation.json)
