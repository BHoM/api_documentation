---
title: EnergyPlusObject
---

# XML.EnergyPlus.EnergyPlusObject



## Class structure

### Implemented interfaces and base types

???+ bhom "The EnergyPlusObject in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Classes inheriting from this class

???+ bhom "The following classes are inheriting from this class:"

    - XML.EnergyPlus.[CoolingPeakCondition](/api_documentation/oM/Adapter/XML/EnergyPlus/CoolingPeakCondition)
    - XML.EnergyPlus.[Difference](/api_documentation/oM/Adapter/XML/EnergyPlus/Difference)
    - XML.EnergyPlus.[EnergyPlusTabularReport](/api_documentation/oM/Adapter/XML/EnergyPlus/EnergyPlusTabularReport)
    - XML.EnergyPlus.[EstimatedCoolingPeakLoadComponent](/api_documentation/oM/Adapter/XML/EnergyPlus/EstimatedCoolingPeakLoadComponent)
    - XML.EnergyPlus.[EstimatedInstantDelayedSensibleLoad](/api_documentation/oM/Adapter/XML/EnergyPlus/EstimatedInstantDelayedSensibleLoad)
    - XML.EnergyPlus.[HeatingPeakCondition](/api_documentation/oM/Adapter/XML/EnergyPlus/HeatingPeakCondition)
    - XML.EnergyPlus.[Latent](/api_documentation/oM/Adapter/XML/EnergyPlus/Latent)
    - XML.EnergyPlus.[OutsideDryBulbTemperature](/api_documentation/oM/Adapter/XML/EnergyPlus/OutsideDryBulbTemperature)
    - XML.EnergyPlus.[OutsideHumidityRatioAtPeak](/api_documentation/oM/Adapter/XML/EnergyPlus/OutsideHumidityRatioAtPeak)
    - XML.EnergyPlus.[OutsideWetBulbTemperature](/api_documentation/oM/Adapter/XML/EnergyPlus/OutsideWetBulbTemperature)
    - XML.EnergyPlus.[PeakDesignSensibleLoad](/api_documentation/oM/Adapter/XML/EnergyPlus/PeakDesignSensibleLoad)
    - XML.EnergyPlus.[SensibleDelayed](/api_documentation/oM/Adapter/XML/EnergyPlus/SensibleDelayed)
    - XML.EnergyPlus.[SensibleInstant](/api_documentation/oM/Adapter/XML/EnergyPlus/SensibleInstant)
    - XML.EnergyPlus.[SensibleReturnAir](/api_documentation/oM/Adapter/XML/EnergyPlus/SensibleReturnAir)
    - XML.EnergyPlus.[SimulationTimestamp](/api_documentation/oM/Adapter/XML/EnergyPlus/SimulationTimestamp)
    - XML.EnergyPlus.[Total](/api_documentation/oM/Adapter/XML/EnergyPlus/Total)
    - XML.EnergyPlus.[ZoneComponentLoadSummary](/api_documentation/oM/Adapter/XML/EnergyPlus/ZoneComponentLoadSummary)
    - XML.EnergyPlus.[ZoneDryBulbTemperature](/api_documentation/oM/Adapter/XML/EnergyPlus/ZoneDryBulbTemperature)
    - XML.EnergyPlus.[ZoneHumidityRatioAtPeak](/api_documentation/oM/Adapter/XML/EnergyPlus/ZoneHumidityRatioAtPeak)
    - XML.EnergyPlus.[ZoneRelativeHumidity](/api_documentation/oM/Adapter/XML/EnergyPlus/ZoneRelativeHumidity)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [EnergyPlusObject.cs](https://github.com/BHoM/XML_Toolkit/blob/develop/XML_oM/EnergyPlus\EnergyPlusObject.cs)

All history and changes of the class can be found by inspection the history.
