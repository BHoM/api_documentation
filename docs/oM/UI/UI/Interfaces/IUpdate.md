---
title: IUpdate
---

# <small>BH.oM.UI.</small>**IUpdate**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IUpdate is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.UI.[IParamUpdate](/api/oM/UI/UI/Interfaces/IParamUpdate)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.UI.[CallerUpdate](/api/oM/UI/UI/Updates/CallerUpdate)
    - BH.oM.UI.[ComponentUpdate](/api/oM/UI/UI/Updates/ComponentUpdate)
    - BH.oM.UI.[InputsUpdate](/api/oM/UI/UI/Updates/InputsUpdate)
    - BH.oM.UI.[OutputsUpdate](/api/oM/UI/UI/Updates/OutputsUpdate)
    - BH.oM.UI.[ParamAdded](/api/oM/UI/UI/Updates/ParamAdded)
    - BH.oM.UI.[ParamMoved](/api/oM/UI/UI/Updates/ParamMoved)
    - BH.oM.UI.[ParamRemoved](/api/oM/UI/UI/Updates/ParamRemoved)
    - BH.oM.UI.[ParamUpdated](/api/oM/UI/UI/Updates/ParamReplaced)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IUpdate : BH.oM.Base.IObject
```

Assembly: UI_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IUpdate.cs](https://github.com/BHoM/BHoM_UI/blob/develop/UI_oM/Interfaces\IUpdate.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/UI_oM/IUpdate.json}
```

The JSON Schema is available on github here:

- [IUpdate.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/UI_oM/IUpdate.json)
