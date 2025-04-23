---
title: IParamUpdate
---

# UI.IParamUpdate



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IParamUpdate in inheriting from the following base type(s) and implements the following interfaces:"

    -  UI.[IUpdate](/api/oM/UI/UI/IUpdate)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - UI.[ParamAdded](/api/oM/UI/UI/ParamAdded)
    - UI.[ParamMoved](/api/oM/UI/UI/ParamMoved)
    - UI.[ParamRemoved](/api/oM/UI/UI/ParamRemoved)
    - UI.[ParamUpdated](/api/oM/UI/UI/ParamUpdated)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Param | [ParamInfo](/api/oM/UI/UI/ParamInfo) | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IToText | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - | UI_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IParamUpdate.cs](https://github.com/BHoM/BHoM_UI/blob/develop/UI_oM/Interfaces/IParamUpdate.cs)

All history and changes of the class can be found by inspection the history.
