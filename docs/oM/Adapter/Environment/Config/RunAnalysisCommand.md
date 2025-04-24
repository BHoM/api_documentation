---
title: RunAnalysisCommand
---

# <small>BH.oM.Environment.</small>**RunAnalysisCommand**



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
