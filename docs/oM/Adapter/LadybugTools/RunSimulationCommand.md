---
title: RunSimulationCommand
---

# LadybugTools.RunSimulationCommand

Command that when executed with the LadybugTools Adapter, runs a simulation and return a SimulationResult containing hourly data.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RunSimulationCommand in inheriting from the following base type(s) and implements the following interfaces:"

    -  LadybugTools.[ISimulationCommand](/om_documentation/oM/Adapter/LadybugTools/ISimulationCommand)
    -  Adapter.[IExecuteCommand](/om_documentation/oM/Framework/Adapter/IExecuteCommand)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| EPWFile | [FileSettings](/om_documentation/oM/Framework/Adapter/FileSettings) | FileSettings for an EPW file to run the simulation with. | - |
| GroundMaterial | [IEnergyMaterialOpaque](/om_documentation/oM/Adapter/LadybugTools/IEnergyMaterialOpaque) | The ground material for the simulation to use. | - |
| ShadeMaterial | [IEnergyMaterialOpaque](/om_documentation/oM/Adapter/LadybugTools/IEnergyMaterialOpaque) | The shade material for the simulation to use. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [RunSimulationCommand.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/ExecuteCommands/RunSimulationCommand.cs)

All history and changes of the class can be found by inspection the history.
