---
title: ElectricalEquipmentType
---

# <small>BH.oM.MEP.Enums.</small>**ElectricalEquipmentType**

A type of electrical equipment (switchgear, panelboard, transformer.)

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| AutomaticTransferSwitch |  -  |
| DisconnectSwitch |  -  |
| Generator |  -  |
| Panelboard |  -  |
| Substation |  -  |
| Switchboard |  -  |
| Switchgear |  -  |
| Transformer |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum ElectricalEquipmentType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: MEP_oM.dll

The enum is defined in C#. The class definition is available on github:

- [ElectricalEquipmentType.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/Enums\ElectricalEquipmentType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/MEP_oM/Enums/ElectricalEquipmentType.json}
```

The JSON Schema is available on github here:

- [ElectricalEquipmentType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/MEP_oM/Enums/ElectricalEquipmentType.json)
