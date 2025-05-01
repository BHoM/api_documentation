---
title: IMRCCommand
---

# <small>BH.oM.Adapters.File.</small>**IMRCCommand**

Interface for Move, Rename and Copy commands.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IMRCCommand is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.File.[CopyCommand](/api/oM/Adapter/Adapters/File/Commands/CopyCommand)
    - BH.oM.Adapters.File.[MoveCommand](/api/oM/Adapter/Adapters/File/Commands/MoveCommand)
    - BH.oM.Adapters.File.[RenameCommand](/api/oM/Adapter/Adapters/File/Commands/RenameCommand)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| FullPath | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| TargetFullPath | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| OverwriteTarget | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IMRCCommand : BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: File_oM.dll

The C# interface definition is available on github:

- [IMRCCommand.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Commands\IMRCCommand.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/File_oM/IMRCCommand.json"
}
```

The JSON Schema is available on github here:

- [IMRCCommand.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/File_oM/IMRCCommand.json)
