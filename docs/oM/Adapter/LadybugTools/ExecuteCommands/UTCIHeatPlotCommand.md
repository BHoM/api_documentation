---
title: UTCIHeatPlotCommand
---

# <small>BH.oM.LadybugTools.</small>**UTCIHeatPlotCommand**

Command that, when executed with the LadybugToolsAdapter, simulates UTCI values and outputs a heatmap. Output is a BH.oM.LadybugTools.PlotInformation containing the plot and extra information about the collection, and the ExternalComfort object that was used to get the UTCI values (whether the simulation ran or not).

## Class structure

### Implemented interfaces and base types

???+ bhom "The UTCIHeatPlotCommand is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LadybugTools.[ISimulationCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/ISimulationCommand)
    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| EPWFile | [FileSettings](/api/oM/Framework/Adapter/FileSettings) | The path to an EPW file. | - |
| ExternalComfort | [ExternalComfort](/api/oM/Adapter/LadybugTools/Simulation/ExternalComfort) | The external comfort object containing the UTCI data to plot. If the UTCI collection is null or empty, then a simulation will be run before plotting to get these values. | - |
| BinColours | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Color](https://learn.microsoft.com/en-us/dotnet/api/System.Drawing.Color?view=netstandard-2.0)&gt; | A list of 10 colours to use for each UTCI category, leave empty to use the default UTCI colours. | - |
| OutputLocation | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Full file path (with file name) to save the plot to. Leave blank to output a base 64 string representation of the image instead. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class UTCIHeatPlotCommand : BH.oM.LadybugTools.ISimulationCommand, BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: LadybugTools_oM.dll

The C# class definition is available on github:

- [UTCIHeatPlotCommand.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/ExecuteCommands\UTCIHeatPlotCommand.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LadybugTools_oM/UTCIHeatPlotCommand.json"
}
```

The JSON Schema is available on github here:

- [UTCIHeatPlotCommand.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LadybugTools_oM/UTCIHeatPlotCommand.json)
