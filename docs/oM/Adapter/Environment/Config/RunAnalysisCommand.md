---
title: RunAnalysisCommand
---

# <small>BH.oM.Environment.SAP.</small>**RunAnalysisCommand**



## Class structure

### Implemented interfaces and base types

???+ bhom "The RunAnalysisCommand is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| FileSettingsInput | [FileSettings](/api/oM/Framework/Adapter/FileSettings) | Path to XML file that will be calculated. | - |
| FileSettingsOutput | [FileSettings](/api/oM/Framework/Adapter/FileSettings) | Path to new file, if using txt endpoint. | - |
| APIKey | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | API Key for access. | - |
| PostURL | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Endpoint. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RunAnalysisCommand : BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: SAP_oM.dll

The class is defined in C#. The class definition is available on github:

- [RunAnalysisCommand.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Config\RunAnalysisCommand.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/RunAnalysisCommand.json"
}
```

The JSON Schema is available on github here:

- [RunAnalysisCommand.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/RunAnalysisCommand.json)
