---
title: ILadybugTools
---

# <small>BH.oM.</small>**ILadybugTools**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The ILadybugTools is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.LadybugTools.[IEnergyMaterialOpaque](/api/oM/Adapter/LadybugTools/Constructions/IEnergyMaterialOpaque)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.LadybugTools.[HourlyContinuousCollection](/api/oM/Adapter/LadybugTools/Collections/HourlyContinuousCollection)
    - BH.oM.LadybugTools.[EnergyMaterial](/api/oM/Adapter/LadybugTools/Constructions/EnergyMaterial)
    - BH.oM.LadybugTools.[EnergyMaterialVegetation](/api/oM/Adapter/LadybugTools/Constructions/EnergyMaterialVegetation)
    - BH.oM.LadybugTools.[Shelter](/api/oM/Adapter/LadybugTools/Geometry/Shelter)
    - BH.oM.LadybugTools.[AnalysisPeriod](/api/oM/Adapter/LadybugTools/MetaData/AnalysisPeriod)
    - BH.oM.LadybugTools.[DataType](/api/oM/Adapter/LadybugTools/MetaData/DataType)
    - BH.oM.LadybugTools.[Header](/api/oM/Adapter/LadybugTools/MetaData/Header)
    - BH.oM.LadybugTools.[ExternalComfort](/api/oM/Adapter/LadybugTools/Simulation/ExternalComfort)
    - BH.oM.LadybugTools.[SimulationResult](/api/oM/Adapter/LadybugTools/Simulation/SimulationResult)
    - BH.oM.LadybugTools.[Typology](/api/oM/Adapter/LadybugTools/Simulation/Typology)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface ILadybugTools : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: LadybugTools_oM.dll

The interface is defined in C#. The class definition is available on github:

- [ILadybugTools.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/ILadybugTools.cs)

All history and changes of the class can be found by inspection the history.
