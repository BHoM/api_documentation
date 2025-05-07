---
title: Analyse
---

# <small>BH.oM.Adapter.Commands.</small>**Analyse**

Used to instruct the external software to run an Analysis.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Analyse is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public class Analyse : BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: Adapter_oM.dll

The C# class definition is available on github:

- [Analyse.cs](https://github.com/BHoM/BHoM_Adapter/blob/develop/Adapter_oM/ExecuteCommands\Analyse.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Adapter_oM/Commands/Analyse.json"
}
```

The JSON Schema is available on github here:

- [Analyse.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Adapter_oM/Commands/Analyse.json)
