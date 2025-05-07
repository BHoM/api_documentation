---
title: BarFEAType
---

# <small>BH.oM.Structure.Elements.</small>**BarFEAType**

Defines the finite element type of the bar and what forces the bar can accommodate, i.e. if the bar should be treated as a bending element or axial only in analysis packages.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Flexural |  Full axial, flexural and torsional behaviour. 2 x 6 DOFs.  |
| Axial |  Axial only. 2 x 3 DOFs. Can be used to model pin-pin elements.  |
| CompressionOnly |  Axial compression only. No tension stiffness. 2 x 3 DOFs.  |
| TensionOnly |  Axial tension only. No compression stiffness. 2 x 3 DOFs.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum BarFEAType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Structure_oM.dll

The C# enum definition is available on github:

- [BarFEAType.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Elements\Enums\BarFEAType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/Elements/BarFEAType.json"
}
```

The JSON Schema is available on github here:

- [BarFEAType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/Elements/BarFEAType.json)
