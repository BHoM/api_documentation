---
title: IAdapterId
---

# <small>BH.oM.Base.</small>**IAdapterId**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IAdapterId is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.ETABS.[ETABSId](/api/oM/Adapter/Adapters/ETABS/Fragments/ETABSId)
    - BH.oM.Adapters.GSA.[GSAId](/api/oM/Adapter/Adapters/GSA/Fragments/GSAId)
    - BH.oM.Adapters.Lusas.[LusasId](/api/oM/Adapter/Adapters/Lusas/Fragments/LusasId)
    - BH.oM.Adapters.MidasCivil.[MidasCivilId](/api/oM/Adapter/Adapters/MidasCivil/Fragments/MidasCivilId)
    - BH.oM.Adapters.RAM.[RAMId](/api/oM/Adapter/Adapters/RAM/Fragments/RAMId)
    - BH.oM.Adapters.RFEM5.[RFEM5Id](/api/oM/Adapter/Adapters/RFEM5/RFEM5Id)
    - BH.oM.Adapters.RFEM6.[RFEM6ID](/api/oM/Adapter/Adapters/RFEM6/Fragments/RFEM6ID)
    - BH.oM.Adapters.Robot.[RobotId](/api/oM/Adapter/Adapters/Robot/Fragments/RobotId)
    - BH.oM.Adapters.SAP2000.[SAP2000Id](/api/oM/Adapter/Adapters/SAP2000/Fragments/SAP2000Id)
    - BH.oM.Test.Adapter.[TestAdapterId](/api/oM/Framework/Test/Adapter/TestAdapterId)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Id | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | Identifier of the object in the external software. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IAdapterId : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: BHoM.dll

The interface is defined in C#. The class definition is available on github:

- [IAdapterId.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Interface\IAdapterId.cs)

All history and changes of the class can be found by inspection the history.
