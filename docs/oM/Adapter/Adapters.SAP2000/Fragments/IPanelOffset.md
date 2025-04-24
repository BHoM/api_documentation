---
title: IPanelOffset
---

# <small>BH.oM.Adapters.SAP2000.</small>**IPanelOffset**

Base interface for panel offsets in SAP. Contains only the type of offset.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IPanelOffset is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.SAP2000.Fragments.[PanelOffsetByJointPattern](/api/oM/Adapter/Adapters.SAP2000/Fragments/PanelOffsetByJointPattern)
    - BH.oM.Adapters.SAP2000.Fragments.[PanelOffsetByPoint](/api/oM/Adapter/Adapters.SAP2000/Fragments/PanelOffsetByPoint)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IPanelOffset : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: SAP2000_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IPanelOffset.cs](https://github.com/BHoM/SAP2000_Toolkit/blob/develop/SAP2000_oM/Fragments\IPanelOffset.cs)

All history and changes of the class can be found by inspection the history.
