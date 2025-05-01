---
title: Discipline
---

# <small>BH.oM.Adapters.Revit.Enums.</small>**Discipline**

Enumerator allowing choosing to which discipline (and corresponding namespace) should Revit elements be converted on pull.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  Default discipline to be used.  |
| Environmental |  Elements to be converted to types from BH.oM.Environment. If no suitable conversion exists, default discipline to be used.  |
| Structural |  Elements to be converted to types from BH.oM.Structure. If no suitable conversion exists, default discipline to be used.  |
| Architecture |  Elements to be converted to types from BH.oM.Architecture. If no suitable conversion exists, default discipline to be used.  |
| Physical |  Elements to be converted to types from BH.oM.Physical. If no suitable conversion exists, default discipline to be used.  |
| Facade |  Elements to be converted to types from BH.oM.Facade. If no suitable conversion exists, default discipline to be used.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum Discipline : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Revit_oM.dll

The C# enum definition is available on github:

- [Discipline.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Enums\Discipline.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Revit_oM/Enums/Discipline.json"
}
```

The JSON Schema is available on github here:

- [Discipline.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Revit_oM/Enums/Discipline.json)
