---
title: ElectricalFixtureType
---

# <small>BH.oM.MEP.Enums.</small>**ElectricalFixtureType**

A type of electrical fixture (duplex/quad socket/receptacle, floor box, or disconnect/isolator switch.)

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| CeilingBox |  -  |
| DuplexSocketReceptacle |  -  |
| FloorBox |  -  |
| FusedDisconnectIsolator |  -  |
| JunctionBox |  -  |
| QuadSocketReceptacle |  -  |
| SimplexSocketReceptacle |  -  |
| ToggleSwitch |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum ElectricalFixtureType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: MEP_oM.dll

The C# enum definition is available on github:

- [ElectricalFixtureType.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/Enums\ElectricalFixtureType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/MEP_oM/Enums/ElectricalFixtureType.json"
}
```

The JSON Schema is available on github here:

- [ElectricalFixtureType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/MEP_oM/Enums/ElectricalFixtureType.json)
