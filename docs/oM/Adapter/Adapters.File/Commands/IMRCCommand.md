---
title: IMRCCommand
---

# <small>BH.oM.Adapters.</small>**IMRCCommand**

Interface for Move, Rename and Copy commands.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IMRCCommand is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.File.[CopyCommand](/api/oM/Adapter/Adapters.File/Commands/CopyCommand)
    - BH.oM.Adapters.File.[MoveCommand](/api/oM/Adapter/Adapters.File/Commands/MoveCommand)
    - BH.oM.Adapters.File.[RenameCommand](/api/oM/Adapter/Adapters.File/Commands/RenameCommand)


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

The interface is defined in C#. The class definition is available on github:

- [IMRCCommand.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Commands\IMRCCommand.cs)

All history and changes of the class can be found by inspection the history.
