---
title: EstimatedCoolingPeakLoadComponent
---

# XML.EnergyPlus.EstimatedCoolingPeakLoadComponent



## Class structure

### Implemented interfaces and base types

???+ bhom "The EstimatedCoolingPeakLoadComponent in inheriting from the following base type(s) and implements the following interfaces:"

    -  XML.EnergyPlus.[EnergyPlusObject](/api_documentation/oM/Adapter/XML/EnergyPlus/EnergyPlusObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| SensibleInstant | [SensibleInstant](/api_documentation/oM/Adapter/XML/EnergyPlus/SensibleInstant) | - | - |
| SensibleDelayed | [SensibleDelayed](/api_documentation/oM/Adapter/XML/EnergyPlus/SensibleDelayed) | - | - |
| SensibleReturnAir | [SensibleReturnAir](/api_documentation/oM/Adapter/XML/EnergyPlus/SensibleReturnAir) | - | - |
| Latent | [Latent](/api_documentation/oM/Adapter/XML/EnergyPlus/Latent) | - | - |
| Total | [Total](/api_documentation/oM/Adapter/XML/EnergyPlus/Total) | - | - |
| GrandTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [EstimatedCoolingPeakLoadComponent.cs](https://github.com/BHoM/XML_Toolkit/blob/develop/XML_oM/EnergyPlus\EstimatedCoolingPeakLoadComponent.cs)

All history and changes of the class can be found by inspection the history.
