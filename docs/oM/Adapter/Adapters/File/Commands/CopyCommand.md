---
title: CopyCommand
---

# <small>BH.oM.Adapters.File.</small>**CopyCommand**



## Class structure

### Implemented interfaces and base types

???+ bhom "The CopyCommand is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapters.File.[IMRCCommand](/api/oM/Adapter/Adapters/File/Commands/IMRCCommand)
    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| FullPath | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Full paths of the items to be Copied. | - |
| TargetFullPath | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The new Full paths of the Files. Files will be Copied there. | - |
| CreateDirectoryIfNotExist | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Whether to create the target Directory if it doesn't exist. | - |
| OverwriteTarget | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Whether to override the target. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class CopyCommand : BH.oM.Adapters.File.IMRCCommand, BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: File_oM.dll

The class is defined in C#. The class definition is available on github:

- [CopyCommand.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Commands\CopyCommand.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/File_oM/CopyCommand.json}
```

The JSON Schema is available on github here:

- [CopyCommand.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/File_oM/CopyCommand.json)
