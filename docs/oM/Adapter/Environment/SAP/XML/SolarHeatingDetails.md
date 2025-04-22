---
title: SolarHeatingDetails
---

# Environment.SAP.XML.SolarHeatingDetails



## Class structure

### Implemented interfaces and base types

???+ bhom "The SolarHeatingDetails in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SolarHeatingCollectorManufacturer | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Panel manufacturer. | - |
| SolarHeatingCertificate | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Solar-Heating-Certificate. | - |
| ApertureArea | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Panel aperture area in square metres. | - |
| Pitch | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| SolarStoreVolume | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Dedicated solar store volume in litres. | - |
| CollectorType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Type of solar panel collector. | - |
| ZeroLossEfficiency | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Collector zero-loss efficiency; only if declared values. | - |
| HeatLossRate | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Collector heat loss rate; for backward compatibility only, do not use. | - |
| LinearHeatLossCoefficient | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Collector linear heat loss coefficient; only if declared values. | - |
| SecondOrderHeatLossCoefficient | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Collector 2nd order heat loss coefficient; only if declared values. | - |
| Orientation | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Collector orientation. | - |
| Overshading | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| HasSolarPoweredPump | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | . | - |
| IsSolarStoreCombinedCylinder | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | . | - |
| CollectorLoopEfficiency | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Collector loop efficiency; only if declared values. | - |
| IncidenceAngleModifier | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Incidence angle modifier; only if declared values. | - |
| IsCommunitySolar | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | . | - |
| ServiceProvision | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| DataSource | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Source of solar panel collector data. | - |
| OverallHeatLoss | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Overall heat loss coefficient of system; only if declared values. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [SolarHeatingDetails.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/XML/SolarHeatingDetails.cs)

All history and changes of the class can be found by inspection the history.
