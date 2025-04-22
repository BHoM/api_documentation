---
title: IMRCCommand
---

# Adapters.File.IMRCCommand

Interface for Move, Rename and Copy commands.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IMRCCommand in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapter.[IExecuteCommand](/api_documentation/oM/Framework/Adapter/IExecuteCommand)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.File.[CopyCommand](/api_documentation/oM/Adapter/Adapters/File/CopyCommand)
    - Adapters.File.[MoveCommand](/api_documentation/oM/Adapter/Adapters/File/MoveCommand)
    - Adapters.File.[RenameCommand](/api_documentation/oM/Adapter/Adapters/File/RenameCommand)


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

The interface is defined in C#. The class definition is available on github:

- [IMRCCommand.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Commands/IMRCCommand.cs)

All history and changes of the class can be found by inspection the history.
