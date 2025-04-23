---
title: EnergyPlusObject
---

# XML.EnergyPlus.EnergyPlusObject



## Class structure

### Implemented interfaces and base types

???+ bhom "The EnergyPlusObject in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


### Classes inheriting from this class

???+ bhom "The following classes are inheriting from this class:"

    - XML.EnergyPlus.[CoolingPeakCondition](/api/oM/Adapter/XML/EnergyPlus/CoolingPeakCondition)
    - XML.EnergyPlus.[Difference](/api/oM/Adapter/XML/EnergyPlus/Difference)
    - XML.EnergyPlus.[EnergyPlusTabularReport](/api/oM/Adapter/XML/EnergyPlus/EnergyPlusTabularReport)
    - XML.EnergyPlus.[EstimatedCoolingPeakLoadComponent](/api/oM/Adapter/XML/EnergyPlus/EstimatedCoolingPeakLoadComponent)
    - XML.EnergyPlus.[EstimatedInstantDelayedSensibleLoad](/api/oM/Adapter/XML/EnergyPlus/EstimatedInstantDelayedSensibleLoad)
    - XML.EnergyPlus.[HeatingPeakCondition](/api/oM/Adapter/XML/EnergyPlus/HeatingPeakCondition)
    - XML.EnergyPlus.[Latent](/api/oM/Adapter/XML/EnergyPlus/Latent)
    - XML.EnergyPlus.[OutsideDryBulbTemperature](/api/oM/Adapter/XML/EnergyPlus/OutsideDryBulbTemperature)
    - XML.EnergyPlus.[OutsideHumidityRatioAtPeak](/api/oM/Adapter/XML/EnergyPlus/OutsideHumidityRatioAtPeak)
    - XML.EnergyPlus.[OutsideWetBulbTemperature](/api/oM/Adapter/XML/EnergyPlus/OutsideWetBulbTemperature)
    - XML.EnergyPlus.[PeakDesignSensibleLoad](/api/oM/Adapter/XML/EnergyPlus/PeakDesignSensibleLoad)
    - XML.EnergyPlus.[SensibleDelayed](/api/oM/Adapter/XML/EnergyPlus/SensibleDelayed)
    - XML.EnergyPlus.[SensibleInstant](/api/oM/Adapter/XML/EnergyPlus/SensibleInstant)
    - XML.EnergyPlus.[SensibleReturnAir](/api/oM/Adapter/XML/EnergyPlus/SensibleReturnAir)
    - XML.EnergyPlus.[SimulationTimestamp](/api/oM/Adapter/XML/EnergyPlus/SimulationTimestamp)
    - XML.EnergyPlus.[Total](/api/oM/Adapter/XML/EnergyPlus/Total)
    - XML.EnergyPlus.[ZoneComponentLoadSummary](/api/oM/Adapter/XML/EnergyPlus/ZoneComponentLoadSummary)
    - XML.EnergyPlus.[ZoneDryBulbTemperature](/api/oM/Adapter/XML/EnergyPlus/ZoneDryBulbTemperature)
    - XML.EnergyPlus.[ZoneHumidityRatioAtPeak](/api/oM/Adapter/XML/EnergyPlus/ZoneHumidityRatioAtPeak)
    - XML.EnergyPlus.[ZoneRelativeHumidity](/api/oM/Adapter/XML/EnergyPlus/ZoneRelativeHumidity)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [EnergyPlusObject.cs](https://github.com/BHoM/XML_Toolkit/blob/develop/XML_oM/EnergyPlus\EnergyPlusObject.cs)

All history and changes of the class can be found by inspection the history.
