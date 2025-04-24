---
title: PanelOffsetByJointPattern
---

# <small>BH.oM.Adapters.SAP2000.</small>**PanelOffsetByJointPattern**



## Class structure

### Implemented interfaces and base types

???+ bhom "The PanelOffsetByJointPattern is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapters.SAP2000.Fragments.[IPanelOffset](/api/oM/Adapter/Adapters.SAP2000/Fragments/IPanelOffset)
    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| OffsetPattern | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | This is the name of the defined joint pattern that is used to calculate the joint offsets. | - |
| OffsetPatternSF | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | This is the scale factor applied to the joint pattern when calculating the joint offsets. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PanelOffsetByJointPattern : BH.oM.Adapters.SAP2000.Fragments.IPanelOffset, BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: SAP2000_oM.dll

The class is defined in C#. The class definition is available on github:

- [PanelOffsetByJointPattern.cs](https://github.com/BHoM/SAP2000_Toolkit/blob/develop/SAP2000_oM/Fragments\PanelOffsetByJointPattern.cs)

All history and changes of the class can be found by inspection the history.
