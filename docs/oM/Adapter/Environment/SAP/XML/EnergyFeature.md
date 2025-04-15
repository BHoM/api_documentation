---
title: EnergyFeature
---

# Environment.SAP.XML.EnergyFeature



## Class structure

### Implemented interfaces and base types

???+ bhom "The EnergyFeature in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| EnergySavedOrGenerated | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Energy saved or generated in kWh/year. | - |
| SavedOrGeneratedFuel | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| EnergyUsed | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Energy used in kWh/year. | - |
| EnergyUsedFuel | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| AirChangeRates | [AirChangeRates](/documentation/oM/Adapter/Environment/SAP/XML/AirChangeRates) | For Appendix Q procedure that provides air change rates. Only one Special Feature can have data on air change rates. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [EnergyFeature.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/XML/EnergyFeature.cs)

All history and changes of the class can be found by inspection the history.
