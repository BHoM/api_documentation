---
title: UTCIHeatPlotCommand
---

# LadybugTools.UTCIHeatPlotCommand

Command that, when executed with the LadybugToolsAdapter, simulates UTCI values and outputs a heatmap. Output is a BH.oM.LadybugTools.PlotInformation containing the plot and extra information about the collection, and the ExternalComfort object that was used to get the UTCI values (whether the simulation ran or not).

## Class structure

### Implemented interfaces and base types

???+ bhom "The UTCIHeatPlotCommand in inheriting from the following base type(s) and implements the following interfaces:"

    -  LadybugTools.[ISimulationCommand](/api/oM/Adapter/LadybugTools/ISimulationCommand)
    -  Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/IExecuteCommand)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| EPWFile | [FileSettings](/api/oM/Framework/Adapter/FileSettings) | The path to an EPW file. | - |
| ExternalComfort | [ExternalComfort](/api/oM/Adapter/LadybugTools/ExternalComfort) | The external comfort object containing the UTCI data to plot. If the UTCI collection is null or empty, then a simulation will be run before plotting to get these values. | - |
| BinColours | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Color](https://learn.microsoft.com/en-us/dotnet/api/System.Drawing.Color?view=netstandard-2.0)&gt; | A list of 10 colours to use for each UTCI category, leave empty to use the default UTCI colours. | - |
| OutputLocation | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Full file path (with file name) to save the plot to. Leave blank to output a base 64 string representation of the image instead. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [UTCIHeatPlotCommand.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/ExecuteCommands/UTCIHeatPlotCommand.cs)

All history and changes of the class can be found by inspection the history.
