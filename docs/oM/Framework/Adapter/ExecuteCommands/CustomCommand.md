---
title: CustomCommand
---

# <small>BH.oM.Adapter.Commands.</small>**CustomCommand**

Used to instruct the external software to run a certain command.

## Class structure

### Implemented interfaces and base types

???+ bhom "The CustomCommand is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Command | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the command to be executed by the external software. | - |
| Parameters | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | Parameters needed by the external software to execute the command. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class CustomCommand : BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: Adapter_oM.dll

The C# class definition is available on github:

- [CustomCommand.cs](https://github.com/BHoM/BHoM_Adapter/blob/develop/Adapter_oM/ExecuteCommands\CustomCommand.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Adapter_oM/Commands/CustomCommand.json"
}
```

The JSON Schema is available on github here:

- [CustomCommand.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Adapter_oM/Commands/CustomCommand.json)
