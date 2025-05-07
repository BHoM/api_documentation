---
title: Save
---

# <small>BH.oM.Adapter.Commands.</small>**Save**

Used to instruct the external software to save a file or model.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Save is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public class Save : BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: Adapter_oM.dll

The C# class definition is available on github:

- [Save.cs](https://github.com/BHoM/BHoM_Adapter/blob/develop/Adapter_oM/ExecuteCommands\Save.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Adapter_oM/Commands/Save.json"
}
```

The JSON Schema is available on github here:

- [Save.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Adapter_oM/Commands/Save.json)
