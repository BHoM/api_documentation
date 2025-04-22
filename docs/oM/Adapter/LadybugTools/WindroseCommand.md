---
title: WindroseCommand
---

# LadybugTools.WindroseCommand

Command that, when executed with the LadybugToolsAdapter, generates a windrose from the epw file using the given parameters.
Outputs a string file path if the OutputLocation is given, or the base64 string representation of the image if no path is given.

## Class structure

### Implemented interfaces and base types

???+ bhom "The WindroseCommand in inheriting from the following base type(s) and implements the following interfaces:"

    -  LadybugTools.[ISimulationCommand](/api_documentation/oM/Adapter/LadybugTools/ISimulationCommand)
    -  Adapter.[IExecuteCommand](/api_documentation/oM/Framework/Adapter/IExecuteCommand)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| EPWFile | [FileSettings](/api_documentation/oM/Framework/Adapter/FileSettings) | The path to an EPW file. | - |
| AnalysisPeriod | [AnalysisPeriod](/api_documentation/oM/Adapter/LadybugTools/AnalysisPeriod) | The analysis period to use for plotting, default to whole non-leap year. | - |
| NumberOfDirectionBins | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | The number of directional bins to plot on the windrose. | - |
| ColourMap | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | A Matplotlib colour map. Corresponds to the 'cmap' parameter of plot methods. See https://matplotlib.org/stable/users/explain/colors/colormaps.html for examples of valid keys. Default of 'viridis'. | - |
| OutputLocation | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Full file path (with file name) to save the plot to. Leave blank to output a base 64 string representation of the image instead. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [WindroseCommand.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/ExecuteCommands/WindroseCommand.cs)

All history and changes of the class can be found by inspection the history.
