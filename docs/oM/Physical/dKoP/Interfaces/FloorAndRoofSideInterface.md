---
title: FloorAndRoofSideInterface
---

# <small>BH.oM.dKoP.</small>**FloorAndRoofSideInterface**



## Class structure

### Implemented interfaces and base types

???+ bhom "The FloorAndRoofSideInterface is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKopObject](/api/oM/Physical/dKoP/IdKopObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| InterfaceType | [SideInterfaceType](/api/oM/Physical/dKoP/Interfaces/Enums/SideInterfaceType) | - | - |
| LoadingData | [SideLoadingData](/api/oM/Physical/dKoP/Interfaces/SideLoadingData) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class FloorAndRoofSideInterface : BH.oM.dKoP.IdKopObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [FloorAndRoofSideInterface.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Interfaces\FloorAndRoofSideInterface.cs)

All history and changes of the class can be found by inspection the history.
