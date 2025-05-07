---
title: DamperType
---

# <small>BH.oM.MEP.Enums.</small>**DamperType**

A type of damper used in ductwork (volume damper, fire smoke damper, etc.)

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| BackdraftDamper |  -  |
| BalancingDamper |  -  |
| FireDamper |  -  |
| FireSmokeDamper |  -  |
| VolumeDamper |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum DamperType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: MEP_oM.dll

The C# enum definition is available on github:

- [DamperType.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/Enums\DamperType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/MEP_oM/Enums/DamperType.json"
}
```

The JSON Schema is available on github here:

- [DamperType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/MEP_oM/Enums/DamperType.json)
