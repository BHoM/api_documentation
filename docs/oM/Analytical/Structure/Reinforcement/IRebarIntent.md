---
title: IRebarIntent
---

# <small>BH.oM.Structure.Reinforcement.</small>**IRebarIntent**

Base interface for any rebar intent.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IRebarIntent is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Structure.Reinforcement.[BarRebarIntent](/api/oM/Analytical/Structure/Reinforcement/BarRebarIntent)
    - BH.oM.Structure.Reinforcement.[PanelRebarIntent](/api/oM/Analytical/Structure/Reinforcement/PanelRebarIntent)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IRebarIntent : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IRebarIntent.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Reinforcement\IRebarIntent.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/Reinforcement/IRebarIntent.json}
```

The JSON Schema is available on github here:

- [IRebarIntent.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/Reinforcement/IRebarIntent.json)
