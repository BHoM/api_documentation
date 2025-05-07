---
title: ISpecification
---

# <small>BH.oM.Base.</small>**ISpecification**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISpecification is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Verification.Specifications.[Specification](/api/oM/Framework/Verification/Specifications/Specification)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface ISpecification : BH.oM.Base.IObject
```

Assembly: BHoM.dll

The C# interface definition is available on github:

- [ISpecification.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Interface\ISpecification.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/BHoM/ISpecification.json"
}
```

The JSON Schema is available on github here:

- [ISpecification.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/BHoM/ISpecification.json)
