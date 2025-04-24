---
title: RAMGridData
---

# <small>BH.oM.Adapters.</small>**RAMGridData**



## Class structure

### Implemented interfaces and base types

???+ bhom "The RAMGridData is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Label | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Represents Grid System label as per RAM | - |
| Type | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Represents Grid System type as per RAM | - |
| XOffset | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Represents Grid System X offset | - |
| YOffset | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Represents Grid System Y offset | - |
| Rotation | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Represents Grid System rotation | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RAMGridData : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: RAM_oM.dll

The class is defined in C#. The class definition is available on github:

- [RAMGridData.cs](https://github.com/BHoM/RAM_Toolkit/blob/develop/RAM_oM/Fragments\RAMGridData.cs)

All history and changes of the class can be found by inspection the history.
