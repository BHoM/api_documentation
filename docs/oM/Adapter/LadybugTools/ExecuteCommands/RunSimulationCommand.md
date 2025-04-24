---
title: RunSimulationCommand
---

# <small>BH.oM.</small>**RunSimulationCommand**

Command that when executed with the LadybugTools Adapter, runs a simulation and return a SimulationResult containing hourly data.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RunSimulationCommand is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LadybugTools.[ISimulationCommand](/api/oM/Adapter/LadybugTools/ExecuteCommands/ISimulationCommand)
    -  BH.oM.Adapter.[IExecuteCommand](/api/oM/Framework/Adapter/ExecuteCommands/_IExecuteCommand)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| EPWFile | [FileSettings](/api/oM/Framework/Adapter/FileSettings) | FileSettings for an EPW file to run the simulation with. | - |
| GroundMaterial | [IEnergyMaterialOpaque](/api/oM/Adapter/LadybugTools/Constructions/IEnergyMaterialOpaque) | The ground material for the simulation to use. | - |
| ShadeMaterial | [IEnergyMaterialOpaque](/api/oM/Adapter/LadybugTools/Constructions/IEnergyMaterialOpaque) | The shade material for the simulation to use. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RunSimulationCommand : BH.oM.LadybugTools.ISimulationCommand, BH.oM.Adapter.IExecuteCommand, BH.oM.Base.IObject
```

Assembly: LadybugTools_oM.dll

The class is defined in C#. The class definition is available on github:

- [RunSimulationCommand.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/ExecuteCommands\RunSimulationCommand.cs)

All history and changes of the class can be found by inspection the history.
