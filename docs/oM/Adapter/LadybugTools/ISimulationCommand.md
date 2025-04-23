---
title: ISimulationCommand
---

# LadybugTools.ISimulationCommand



## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISimulationCommand in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/IExecuteCommand)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - LadybugTools.[DiurnalPlotCommand](/api/oM/Adapter/LadybugTools/DiurnalPlotCommand)
    - LadybugTools.[HeatPlotCommand](/api/oM/Adapter/LadybugTools/HeatPlotCommand)
    - LadybugTools.[RunExternalComfortCommand](/api/oM/Adapter/LadybugTools/RunExternalComfortCommand)
    - LadybugTools.[RunSimulationCommand](/api/oM/Adapter/LadybugTools/RunSimulationCommand)
    - LadybugTools.[SolarRadiationPlotCommand](/api/oM/Adapter/LadybugTools/SolarRadiationPlotCommand)
    - LadybugTools.[SunPathPlotCommand](/api/oM/Adapter/LadybugTools/SunPathPlotCommand)
    - LadybugTools.[UTCIHeatPlotCommand](/api/oM/Adapter/LadybugTools/UTCIHeatPlotCommand)
    - LadybugTools.[WalkabilityPlotCommand](/api/oM/Adapter/LadybugTools/WalkabilityPlotCommand)
    - LadybugTools.[WindroseCommand](/api/oM/Adapter/LadybugTools/WindroseCommand)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| EPWFile | [FileSettings](/api/oM/Framework/Adapter/FileSettings) | The path to an EPW file. | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [ISimulationCommand.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/ExecuteCommands/ISimulationCommand.cs)

All history and changes of the class can be found by inspection the history.
