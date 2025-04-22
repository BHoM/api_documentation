---
title: GetMaterialCommand
---

# LadybugTools.GetMaterialCommand

Command that when executed with the LadybugTools Adapter, returns a list of materials from the Python Materials list.

## Class structure

### Implemented interfaces and base types

???+ bhom "The GetMaterialCommand in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapter.[IExecuteCommand](/api_documentation/oM/Framework/Adapter/IExecuteCommand)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Filter | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Text to filter the resultant list by. Filter applies to the Material Name. Leave blank to return all Materials. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [GetMaterialCommand.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/ExecuteCommands/GetMaterialCommand.cs)

All history and changes of the class can be found by inspection the history.
