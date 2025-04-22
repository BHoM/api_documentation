---
title: DiurnalPlotCommand
---

# LadybugTools.DiurnalPlotCommand

Use in conjunction with the LadybugToolsAdapter to run a diurnal analysis on a specific key of an epw file, and output a plot.

## Class structure

### Implemented interfaces and base types

???+ bhom "The DiurnalPlotCommand in inheriting from the following base type(s) and implements the following interfaces:"

    -  LadybugTools.[ISimulationCommand](/api_documentation/oM/Adapter/LadybugTools/ISimulationCommand)
    -  Adapter.[IExecuteCommand](/api_documentation/oM/Framework/Adapter/IExecuteCommand)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| EPWFile | [FileSettings](/api_documentation/oM/Framework/Adapter/FileSettings) | The EPW file to analyse. | - |
| EPWKey | [EPWKey](/api_documentation/oM/Adapter/LadybugTools/EPWKey) | The key in the EPW file to analyse. | - |
| Colour | [Color](https://learn.microsoft.com/en-us/dotnet/api/System.Drawing.Color?view=netstandard-2.0) | The colour of the average line on the plot. | - |
| OutputLocation | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The directory to output the file. Leave empty to return a base64 string representation of that image. | - |
| Title | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Title of the plot, will appear above any information on the top of the plot. | - |
| Period | [DiurnalPeriod](/api_documentation/oM/Adapter/LadybugTools/DiurnalPeriod) | The diurnal period to analyse. Daily for 365 samples/timestep, weekly for 52, monthly for 30. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [DiurnalPlotCommand.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/ExecuteCommands/DiurnalPlotCommand.cs)

All history and changes of the class can be found by inspection the history.
