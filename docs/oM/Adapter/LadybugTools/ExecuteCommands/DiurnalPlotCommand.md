---
title: DiurnalPlotCommand
---

# <small>BH.oM.LadybugTools.</small>**DiurnalPlotCommand**

Use in conjunction with the LadybugToolsAdapter to run a diurnal analysis on a specific key of an epw file, and output a plot.

## Class structure

### Implemented interfaces and base types

???+ bhom "The DiurnalPlotCommand is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LadybugTools.[ISimulationCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/ISimulationCommand)
    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| EPWFile | [FileSettings](/api/oM/Framework/Adapter/FileSettings) | The EPW file to analyse. | - |
| EPWKey | [EPWKey](/api/oM/Adapter/LadybugTools/Enum/EPWKeys) | The key in the EPW file to analyse. | - |
| Colour | [Color](https://learn.microsoft.com/en-us/dotnet/api/System.Drawing.Color?view=netstandard-2.0) | The colour of the average line on the plot. | - |
| OutputLocation | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The directory to output the file. Leave empty to return a base64 string representation of that image. | - |
| Title | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Title of the plot, will appear above any information on the top of the plot. | - |
| Period | [DiurnalPeriod](/api/oM/Adapter/LadybugTools/Enum/DiurnalPeriod) | The diurnal period to analyse. Daily for 365 samples/timestep, weekly for 52, monthly for 30. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class DiurnalPlotCommand : BH.oM.LadybugTools.ISimulationCommand, BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: LadybugTools_oM.dll

The class is defined in C#. The class definition is available on github:

- [DiurnalPlotCommand.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/ExecuteCommands\DiurnalPlotCommand.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LadybugTools_oM/DiurnalPlotCommand.json"
}
```

The JSON Schema is available on github here:

- [DiurnalPlotCommand.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LadybugTools_oM/DiurnalPlotCommand.json)
