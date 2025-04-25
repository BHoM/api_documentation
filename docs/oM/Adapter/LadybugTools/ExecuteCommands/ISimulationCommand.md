---
title: ISimulationCommand
---

# <small>BH.oM.LadybugTools.</small>**ISimulationCommand**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISimulationCommand is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.LadybugTools.[DiurnalPlotCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/DiurnalPlotCommand)
    - BH.oM.LadybugTools.[HeatPlotCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/HeatPlotCommand)
    - BH.oM.LadybugTools.[RunExternalComfortCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/RunExternalComfortCommand)
    - BH.oM.LadybugTools.[RunSimulationCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/RunSimulationCommand)
    - BH.oM.LadybugTools.[SolarRadiationPlotCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/SolarRadiationPlotCommand)
    - BH.oM.LadybugTools.[SunPathPlotCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/SunPathPlotCommand)
    - BH.oM.LadybugTools.[UTCIHeatPlotCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/UTCIHeatPlotCommand)
    - BH.oM.LadybugTools.[WalkabilityPlotCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/WalkabilityPlotCommand)
    - BH.oM.LadybugTools.[WindroseCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/WindroseCommand)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| EPWFile | [FileSettings](/api/oM/Framework/Adapter/FileSettings) | The path to an EPW file. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface ISimulationCommand : BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: LadybugTools_oM.dll

The interface is defined in C#. The class definition is available on github:

- [ISimulationCommand.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/ExecuteCommands\ISimulationCommand.cs)

All history and changes of the class can be found by inspection the history.
