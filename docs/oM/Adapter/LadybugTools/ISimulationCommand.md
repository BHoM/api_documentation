---
title: ISimulationCommand
---

# LadybugTools.ISimulationCommand



## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISimulationCommand in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapter.[IExecuteCommand](/om_documentation/oM/Framework/Adapter/IExecuteCommand)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - LadybugTools.[DiurnalPlotCommand](/om_documentation/oM/Adapter/LadybugTools/DiurnalPlotCommand)
    - LadybugTools.[HeatPlotCommand](/om_documentation/oM/Adapter/LadybugTools/HeatPlotCommand)
    - LadybugTools.[RunExternalComfortCommand](/om_documentation/oM/Adapter/LadybugTools/RunExternalComfortCommand)
    - LadybugTools.[RunSimulationCommand](/om_documentation/oM/Adapter/LadybugTools/RunSimulationCommand)
    - LadybugTools.[SolarRadiationPlotCommand](/om_documentation/oM/Adapter/LadybugTools/SolarRadiationPlotCommand)
    - LadybugTools.[SunPathPlotCommand](/om_documentation/oM/Adapter/LadybugTools/SunPathPlotCommand)
    - LadybugTools.[UTCIHeatPlotCommand](/om_documentation/oM/Adapter/LadybugTools/UTCIHeatPlotCommand)
    - LadybugTools.[WalkabilityPlotCommand](/om_documentation/oM/Adapter/LadybugTools/WalkabilityPlotCommand)
    - LadybugTools.[WindroseCommand](/om_documentation/oM/Adapter/LadybugTools/WindroseCommand)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| EPWFile | [FileSettings](/om_documentation/oM/Framework/Adapter/FileSettings) | The path to an EPW file. | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [ISimulationCommand.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/ExecuteCommands/ISimulationCommand.cs)

All history and changes of the class can be found by inspection the history.
