---
title: IBHoMGroup
---

# <small>BH.oM.Base.</small>**IBHoMGroup**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IBHoMGroup is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Base.[BHoMGroup](/api/oM/Framework/Base/BHoMGroup)&lt;[T](/api/oM/Framework/Base/BHoMGroup#t)&gt;


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IBHoMGroup : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: BHoM.dll

The interface is defined in C#. The class definition is available on github:

- [IBHoMGroup.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Interface\IBHoMGroup.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/BHoM/IBHoMGroup.json}
```

The JSON Schema is available on github here:

- [IBHoMGroup.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/BHoM/IBHoMGroup.json)
