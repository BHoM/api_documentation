---
title: HeatPlotCommand
---

# <small>BH.oM.LadybugTools.</small>**HeatPlotCommand**

Command that, when executed with the LadybugToolsAdapter, produces a heatmap from data in an epw file.
Output is a string of either the path to the image (if OutputLocation is not set) or the base 64 string representation of it.

## Class structure

### Implemented interfaces and base types

???+ bhom "The HeatPlotCommand is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LadybugTools.[ISimulationCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/ISimulationCommand)
    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| EPWFile | [FileSettings](/api/oM/Framework/Adapter/FileSettings) | The path to an EPW file. | - |
| EPWKey | [EPWKey](/api/oM/Adapter/LadybugTools/Enum/EPWKeys) | Key representing an hourly continuous collection in the EPW file to plot. | - |
| ColourMap | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | A Matplotlib colour map. Corresponds to the 'cmap' parameter of plot methods. See https://matplotlib.org/stable/users/explain/colors/colormaps.html for examples of valid keys. Default of 'viridis'. | - |
| OutputLocation | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Full file path (with file name) to save the plot to. Leave blank to output a base 64 string representation of the image instead. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class HeatPlotCommand : BH.oM.LadybugTools.ISimulationCommand, BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: LadybugTools_oM.dll

The class is defined in C#. The class definition is available on github:

- [HeatPlotCommand.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/ExecuteCommands\HeatPlotCommand.cs)

All history and changes of the class can be found by inspection the history.
