---
title: WallInterfaces
---

# <small>BH.oM.dKoP.</small>**WallInterfaces**



## Class structure

### Implemented interfaces and base types

???+ bhom "The WallInterfaces is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKopObject](/api/oM/Physical/dKoP/IdKopObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BaseInterface | [WallBaseInterface](/api/oM/Physical/dKoP/Interfaces/WallBaseInterface) | - | - |
| SideInterface | [WallSideInterface](/api/oM/Physical/dKoP/Interfaces/WallSideInterface) | - | - |
| TopInterface | [WallTopInterface](/api/oM/Physical/dKoP/Interfaces/WallTopInterface) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class WallInterfaces : BH.oM.dKoP.IdKopObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [WallInterfaces.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Interfaces\WallInterfaces.cs)

All history and changes of the class can be found by inspection the history.
