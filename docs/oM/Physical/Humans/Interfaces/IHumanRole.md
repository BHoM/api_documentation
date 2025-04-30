---
title: IHumanRole
---

# <small>BH.oM.Humans.</small>**IHumanRole**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IHumanRole is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Humans.[Employee](/api/oM/Physical/Humans/Employee)
    - BH.oM.Humans.[Skeleton](/api/oM/Physical/Humans/Skeleton)
    - BH.oM.Humans.ViewQuality.[Spectator](/api/oM/Physical/Humans/ViewQuality/Spectator)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IHumanRole : BH.oM.Base.IObject
```

Assembly: Humans_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IHumanRole.cs](https://github.com/BHoM/BHoM/blob/develop/Humans_oM/Interfaces\IHumanRole.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Humans_oM/IHumanRole.json}
```

The JSON Schema is available on github here:

- [IHumanRole.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Humans_oM/IHumanRole.json)
