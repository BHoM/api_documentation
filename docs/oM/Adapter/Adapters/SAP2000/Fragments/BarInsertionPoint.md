---
title: BarInsertionPoint
---

# <small>BH.oM.Adapters.SAP2000.Elements.</small>**BarInsertionPoint**



## Class structure

### Implemented interfaces and base types

???+ bhom "The BarInsertionPoint is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| InsertionPoint | [BarInsertionPointLocation](/api/oM/Adapter/Adapters/SAP2000/Enums/BarInsertionPointLocation) | Bar insertion point based on cross section. | - |
| ModifyStiffness | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Transform frame stiffness for offsets from centroid. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class BarInsertionPoint : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: SAP2000_oM.dll

The class is defined in C#. The class definition is available on github:

- [BarInsertionPoint.cs](https://github.com/BHoM/SAP2000_Toolkit/blob/develop/SAP2000_oM/Fragments\BarInsertionPoint.cs)

All history and changes of the class can be found by inspection the history.
