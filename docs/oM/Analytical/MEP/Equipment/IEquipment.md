---
title: IEquipment
---

# <small>BH.oM.MEP.Equipment.</small>**IEquipment**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IEquipment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.MEP.Equipment.[AirHandlingUnit](/api/oM/Analytical/MEP/Equipment/AirHandlingUnit)
    - BH.oM.MEP.Equipment.[ElectricalEquipment](/api/oM/Analytical/MEP/Equipment/ElectricalEquipment)
    - BH.oM.MEP.Equipment.[FanCoilUnit](/api/oM/Analytical/MEP/Equipment/FanCoilUnit)
    - BH.oM.MEP.Equipment.[MechanicalEquipment](/api/oM/Analytical/MEP/Equipment/MechanicalEquipment)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IEquipment : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: MEP_oM.dll

The C# interface definition is available on github:

- [IEquipment.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/Equipment\IEquipment.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/MEP_oM/Equipment/IEquipment.json"
}
```

The JSON Schema is available on github here:

- [IEquipment.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/MEP_oM/Equipment/IEquipment.json)
