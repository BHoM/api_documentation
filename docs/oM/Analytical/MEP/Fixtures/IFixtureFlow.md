---
title: IFixtureFlow
---

# <small>BH.oM.MEP.Fixtures.</small>**IFixtureFlow**

Base interface for all Fixture Flow objects. These objects are capable of containing a material or element that flows through the object.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IFixtureFlow is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.MEP.Fixtures.[PlumbingFixtureFlow](/api/oM/Analytical/MEP/Fixtures/PlumbingFixtureFlow)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IFixtureFlow : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: MEP_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IFixtureFlow.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/Fixtures\IFixtureFlow.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/MEP_oM/Fixtures/IFixtureFlow.json"
}
```

The JSON Schema is available on github here:

- [IFixtureFlow.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/MEP_oM/Fixtures/IFixtureFlow.json)
