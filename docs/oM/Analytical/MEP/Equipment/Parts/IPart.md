---
title: IPart
---

# <small>BH.oM.MEP.Equipment.Parts.</small>**IPart**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IPart is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.MEP.Equipment.Parts.[AirHandlingUnitBase](/api/oM/Analytical/MEP/Equipment/Parts/AirHandlingUnitBase)
    - BH.oM.MEP.Equipment.Parts.[CoolingCoil](/api/oM/Analytical/MEP/Equipment/Parts/CoolingCoil)
    - BH.oM.MEP.Equipment.Parts.[ElectricalConnector](/api/oM/Analytical/MEP/Equipment/Parts/ElectricalConnector)
    - BH.oM.MEP.Equipment.Parts.[EnergyWheel](/api/oM/Analytical/MEP/Equipment/Parts/EnergyWheel)
    - BH.oM.MEP.Equipment.Parts.[Fan](/api/oM/Analytical/MEP/Equipment/Parts/Fan)
    - BH.oM.MEP.Equipment.Parts.[Filter](/api/oM/Analytical/MEP/Equipment/Parts/Filter)
    - BH.oM.MEP.Equipment.Parts.[HeatingCoil](/api/oM/Analytical/MEP/Equipment/Parts/HeatingCoil)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IPart : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: MEP_oM.dll

The C# interface definition is available on github:

- [IPart.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/Equipment\Parts\IPart.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/MEP_oM/Equipment/Parts/IPart.json"
}
```

The JSON Schema is available on github here:

- [IPart.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/MEP_oM/Equipment/Parts/IPart.json)
