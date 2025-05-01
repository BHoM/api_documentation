---
title: IFixtureUsage
---

# <small>BH.oM.MEP.Fixtures.</small>**IFixtureUsage**

Base interface for all Fixture objects. These objects are capable of containing a material or element that flows through the object.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IFixtureUsage is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.MEP.Fixtures.[CommercialFixtureUsage](/api/oM/Analytical/MEP/Fixtures/CommercialFixtureUsage)
    - BH.oM.MEP.Fixtures.[ResidentialFixtureUsage](/api/oM/Analytical/MEP/Fixtures/ResidentialFixtureUsage)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IFixtureUsage : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Base.IImmutable
```

Assembly: MEP_oM.dll

The C# interface definition is available on github:

- [IFixtureUsage.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/Fixtures\IFixtureUsage.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/MEP_oM/Fixtures/IFixtureUsage.json"
}
```

The JSON Schema is available on github here:

- [IFixtureUsage.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/MEP_oM/Fixtures/IFixtureUsage.json)
