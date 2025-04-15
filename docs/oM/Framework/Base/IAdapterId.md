---
title: IAdapterId
---

# Base.IAdapterId



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IAdapterId in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IFragment](/documentation/oM/Framework/Base/IFragment)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.ETABS.[ETABSId](/documentation/oM/Adapter/Adapters/ETABS/ETABSId)
    - Adapters.GSA.[GSAId](/documentation/oM/Adapter/Adapters/GSA/GSAId)
    - Adapters.Lusas.[LusasId](/documentation/oM/Adapter/Adapters/Lusas/LusasId)
    - Adapters.MidasCivil.[MidasCivilId](/documentation/oM/Adapter/Adapters/MidasCivil/MidasCivilId)
    - Adapters.RAM.[RAMId](/documentation/oM/Adapter/Adapters/RAM/RAMId)
    - Adapters.RFEM5.[RFEM5Id](/documentation/oM/Adapter/Adapters/RFEM5/RFEM5Id)
    - Adapters.RFEM6.[RFEM6ID](/documentation/oM/Adapter/Adapters/RFEM6/RFEM6ID)
    - Adapters.Robot.[RobotId](/documentation/oM/Adapter/Adapters/Robot/RobotId)
    - Adapters.SAP2000.[SAP2000Id](/documentation/oM/Adapter/Adapters/SAP2000/SAP2000Id)
    - Test.Adapter.[TestAdapterId](/documentation/oM/Framework/Test/Adapter/TestAdapterId)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Id | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | Identifier of the object in the external software. | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IAdapterId.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Interface/IAdapterId.cs)

All history and changes of the class can be found by inspection the history.
