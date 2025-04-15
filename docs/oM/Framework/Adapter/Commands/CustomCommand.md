---
title: CustomCommand
---

# Adapter.Commands.CustomCommand

Used to instruct the external software to run a certain command.

## Class structure

### Implemented interfaces and base types

???+ bhom "The CustomCommand in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapter.[IExecuteCommand](/om_documentation/oM/Framework/Adapter/IExecuteCommand)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Command | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the command to be executed by the external software. | - |
| Parameters | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | Parameters needed by the external software to execute the command. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [CustomCommand.cs](https://github.com/BHoM/BHoM_Adapter/blob/develop/Adapter_oM/ExecuteCommands/CustomCommand.cs)

All history and changes of the class can be found by inspection the history.
