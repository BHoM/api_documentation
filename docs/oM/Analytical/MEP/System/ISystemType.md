---
title: ISystemType
---

# <small>BH.oM.MEP.System.</small>**ISystemType**

An MEP system to determine flow types.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISystemType is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.MEP.System.[MechanicalSystem](/api/oM/Analytical/MEP/System/MechanicalSystem)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface ISystemType : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: MEP_oM.dll

The C# interface definition is available on github:

- [ISystemType.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/System\ISystemType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/MEP_oM/System/ISystemType.json"
}
```

The JSON Schema is available on github here:

- [ISystemType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/MEP_oM/System/ISystemType.json)
