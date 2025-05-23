---
title: Exit
---

# <small>BH.oM.Adapter.Commands.</small>**Exit**

Used to instruct the adapter to exit the software. The adapter will generally not be useable after running this command as the link to the software will be broken.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Exit is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SaveBeforeClose | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If set to true, the adapter attempts to save any open file, closes the file and exits the software. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Exit : BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: Adapter_oM.dll

The C# class definition is available on github:

- [Exit.cs](https://github.com/BHoM/BHoM_Adapter/blob/develop/Adapter_oM/ExecuteCommands\Exit.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Adapter_oM/Commands/Exit.json"
}
```

The JSON Schema is available on github here:

- [Exit.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Adapter_oM/Commands/Exit.json)
