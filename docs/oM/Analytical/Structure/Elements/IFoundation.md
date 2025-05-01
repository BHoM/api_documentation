---
title: IFoundation
---

# <small>BH.oM.Structure.Elements.</small>**IFoundation**

Base interface for foundation objects.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IFoundation is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Structure.Elements.[PadFoundation](/api/oM/Analytical/Structure/Elements/PadFoundation)
    - BH.oM.Structure.Elements.[Pile](/api/oM/Analytical/Structure/Elements/Pile)
    - BH.oM.Structure.Elements.[PileFoundation](/api/oM/Analytical/Structure/Elements/PileFoundation)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IFoundation : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IFoundation.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Elements\IFoundation.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/Elements/IFoundation.json"
}
```

The JSON Schema is available on github here:

- [IFoundation.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/Elements/IFoundation.json)
