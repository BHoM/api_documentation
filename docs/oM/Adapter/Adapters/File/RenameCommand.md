---
title: RenameCommand
---

# Adapters.File.RenameCommand



## Class structure

### Implemented interfaces and base types

???+ bhom "The RenameCommand in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapters.File.[IMRCCommand](/om_documentation/oM/Adapter/Adapters/File/IMRCCommand)
    -  Adapter.[IExecuteCommand](/om_documentation/oM/Framework/Adapter/IExecuteCommand)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| FullPath | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Full paths of the items to be Renamed. | - |
| TargetFullPath | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The new Full paths of the Files. Files will be Renamed. | - |
| OverwriteTarget | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Whether to override the target. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [RenameCommand.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Commands/RenameCommand.cs)

All history and changes of the class can be found by inspection the history.
