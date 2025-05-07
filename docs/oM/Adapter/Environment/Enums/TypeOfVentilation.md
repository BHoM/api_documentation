---
title: TypeOfVentilation
---

# <small>BH.oM.Environment.SAP.</small>**TypeOfVentilation**

Code which indicates the type of ventilation.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| NaturalIntermittentExtractFans |  -  |
| NaturalPassiveVents |  -  |
| PositiveInputFromLoft |  -  |
| PositiveInputFromOutside |  -  |
| MEVc |  -  |
| MEVdc |  -  |
| MV |  -  |
| MVHR |  -  |
| NaturalIntermittentExtractFansAndPassiveVents |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum TypeOfVentilation : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: SAP_oM.dll

The C# enum definition is available on github:

- [TypeOfVentilation.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Enums\TypeOfVentilation.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/TypeOfVentilation.json"
}
```

The JSON Schema is available on github here:

- [TypeOfVentilation.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/TypeOfVentilation.json)
