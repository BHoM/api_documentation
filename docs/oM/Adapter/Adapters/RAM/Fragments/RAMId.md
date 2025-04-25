---
title: RAMId
---

# <small>BH.oM.Adapters.RAM.</small>**RAMId**



## Class structure

### Implemented interfaces and base types

???+ bhom "The RAMId is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IAdapterId](/api/oM/Framework/Base/Interface/IAdapterId)
    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Id | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | lUID of the element as assigned in RAM. | - |
| FloorType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The RAM FloorType that the element belongs to. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RAMId : BH.oM.Base.IAdapterId, BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: RAM_oM.dll

The class is defined in C#. The class definition is available on github:

- [RAMId.cs](https://github.com/BHoM/RAM_Toolkit/blob/develop/RAM_oM/Fragments\RAMId.cs)

All history and changes of the class can be found by inspection the history.
