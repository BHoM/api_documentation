---
title: Procurement
---

# <small>BH.oM.</small>**Procurement**



## Class structure

### Implemented interfaces and base types

???+ bhom "The Procurement is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKopObject](/api/oM/Physical/dKoP/IdKopObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| LeadTime | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| Cost | [Cost](/api/oM/Physical/dKoP/Assembly/Cost) | - | - |
| MinimumOrder | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |
| MaximumOrder | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Procurement : BH.oM.dKoP.IdKopObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [Procurement.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Assembly\Procurement.cs)

All history and changes of the class can be found by inspection the history.
