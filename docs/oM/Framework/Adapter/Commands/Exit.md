---
title: Exit
---

# Adapter.Commands.Exit

Used to instruct the adapter to exit the software. The adapter will generally not be useable after running this command as the link to the software will be broken.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Exit in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapter.[IExecuteCommand](/api_documentation/oM/Framework/Adapter/IExecuteCommand)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SaveBeforeClose | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If set to true, the adapter attempts to save any open file, closes the file and exits the software. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Exit.cs](https://github.com/BHoM/BHoM_Adapter/blob/develop/Adapter_oM/ExecuteCommands/Exit.cs)

All history and changes of the class can be found by inspection the history.
