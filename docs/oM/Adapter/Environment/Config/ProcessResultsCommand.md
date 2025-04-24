---
title: ProcessResultsCommand
---

# <small>BH.oM.Environment.</small>**ProcessResultsCommand**



## Class structure

### Implemented interfaces and base types

???+ bhom "The ProcessResultsCommand is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ResultFiles | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[FileSettings](/api/oM/Framework/Adapter/FileSettings)&gt; | Paths to the XML results files that will be calculated. | - |
| SaveFileDirectory | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Directory to save the results file(s) to. | - |
| DwellingSchedules | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[DwellingSchedule](/api/oM/Adapter/Environment/Excel/DwellingSchedule)&gt; | List of dwelling schedules containing information about each individual dwelling in the report. | - |
| TargetDERTERImprovement | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Provide the target DER/TER improvement as a % between 0 and 100. | - |
| TargetDPERTPERImprovement | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Provide the target DPER/TPER improvement as a % between 0 and 100. | - |
| TargetDFEETFEEImprovement | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Provide the target DFEE/TFEE improvement as a % between 0 and 100. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ProcessResultsCommand : BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: SAP_oM.dll

The class is defined in C#. The class definition is available on github:

- [ProcessResultsCommand.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Config\ProcessResultsCommand.cs)

All history and changes of the class can be found by inspection the history.
