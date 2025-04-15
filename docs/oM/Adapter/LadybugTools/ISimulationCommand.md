---
title: ISimulationCommand
---

# LadybugTools.ISimulationCommand



## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISimulationCommand in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapter.[IExecuteCommand](/documentation/oM/Framework/Adapter/IExecuteCommand)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - LadybugTools.[DiurnalPlotCommand](/documentation/oM/Adapter/LadybugTools/DiurnalPlotCommand)
    - LadybugTools.[HeatPlotCommand](/documentation/oM/Adapter/LadybugTools/HeatPlotCommand)
    - LadybugTools.[RunExternalComfortCommand](/documentation/oM/Adapter/LadybugTools/RunExternalComfortCommand)
    - LadybugTools.[RunSimulationCommand](/documentation/oM/Adapter/LadybugTools/RunSimulationCommand)
    - LadybugTools.[SolarRadiationPlotCommand](/documentation/oM/Adapter/LadybugTools/SolarRadiationPlotCommand)
    - LadybugTools.[SunPathPlotCommand](/documentation/oM/Adapter/LadybugTools/SunPathPlotCommand)
    - LadybugTools.[UTCIHeatPlotCommand](/documentation/oM/Adapter/LadybugTools/UTCIHeatPlotCommand)
    - LadybugTools.[WalkabilityPlotCommand](/documentation/oM/Adapter/LadybugTools/WalkabilityPlotCommand)
    - LadybugTools.[WindroseCommand](/documentation/oM/Adapter/LadybugTools/WindroseCommand)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| EPWFile | [FileSettings](/documentation/oM/Framework/Adapter/FileSettings) | The path to an EPW file. | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [ISimulationCommand.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/ExecuteCommands/ISimulationCommand.cs)

All history and changes of the class can be found by inspection the history.
