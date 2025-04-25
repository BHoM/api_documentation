---
title: Services
---

# <small>BH.oM.dKoP.</small>**Services**



## Class structure

### Implemented interfaces and base types

???+ bhom "The Services is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKopObject](/api/oM/Physical/dKoP/IdKopObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Electrical | [Electrical](/api/oM/Physical/dKoP/Perfomance/Services/Electrical) | - | - |
| Data | [Data](/api/oM/Physical/dKoP/Perfomance/Services/Data) | - | - |
| Heating | [Heating](/api/oM/Physical/dKoP/Perfomance/Services/Heating) | - | - |
| Water | [Water](/api/oM/Physical/dKoP/Perfomance/Services/Water) | - | - |
| Drainage | [Drainage](/api/oM/Physical/dKoP/Perfomance/Services/Drainage) | - | - |
| Gas | [Gas](/api/oM/Physical/dKoP/Perfomance/Services/Gas) | - | - |
| Ventilation | [Ventilation](/api/oM/Physical/dKoP/Perfomance/Services/Ventilation) | - | - |
| ServicesIntegrationConfirmation | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Services : BH.oM.dKoP.IdKopObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [Services.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Perfomance\Services\Services.cs)

All history and changes of the class can be found by inspection the history.
