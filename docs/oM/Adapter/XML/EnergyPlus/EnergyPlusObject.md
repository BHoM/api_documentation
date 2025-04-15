---
title: EnergyPlusObject
---

# XML.EnergyPlus.EnergyPlusObject



## Class structure

### Implemented interfaces and base types

???+ bhom "The EnergyPlusObject in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


### Classes inheriting from this class

???+ bhom "The following classes are inheriting from this class:"

    - XML.EnergyPlus.[CoolingPeakCondition](/documentation/oM/Adapter/XML/EnergyPlus/CoolingPeakCondition)
    - XML.EnergyPlus.[Difference](/documentation/oM/Adapter/XML/EnergyPlus/Difference)
    - XML.EnergyPlus.[EnergyPlusTabularReport](/documentation/oM/Adapter/XML/EnergyPlus/EnergyPlusTabularReport)
    - XML.EnergyPlus.[EstimatedCoolingPeakLoadComponent](/documentation/oM/Adapter/XML/EnergyPlus/EstimatedCoolingPeakLoadComponent)
    - XML.EnergyPlus.[EstimatedInstantDelayedSensibleLoad](/documentation/oM/Adapter/XML/EnergyPlus/EstimatedInstantDelayedSensibleLoad)
    - XML.EnergyPlus.[HeatingPeakCondition](/documentation/oM/Adapter/XML/EnergyPlus/HeatingPeakCondition)
    - XML.EnergyPlus.[Latent](/documentation/oM/Adapter/XML/EnergyPlus/Latent)
    - XML.EnergyPlus.[OutsideDryBulbTemperature](/documentation/oM/Adapter/XML/EnergyPlus/OutsideDryBulbTemperature)
    - XML.EnergyPlus.[OutsideHumidityRatioAtPeak](/documentation/oM/Adapter/XML/EnergyPlus/OutsideHumidityRatioAtPeak)
    - XML.EnergyPlus.[OutsideWetBulbTemperature](/documentation/oM/Adapter/XML/EnergyPlus/OutsideWetBulbTemperature)
    - XML.EnergyPlus.[PeakDesignSensibleLoad](/documentation/oM/Adapter/XML/EnergyPlus/PeakDesignSensibleLoad)
    - XML.EnergyPlus.[SensibleDelayed](/documentation/oM/Adapter/XML/EnergyPlus/SensibleDelayed)
    - XML.EnergyPlus.[SensibleInstant](/documentation/oM/Adapter/XML/EnergyPlus/SensibleInstant)
    - XML.EnergyPlus.[SensibleReturnAir](/documentation/oM/Adapter/XML/EnergyPlus/SensibleReturnAir)
    - XML.EnergyPlus.[SimulationTimestamp](/documentation/oM/Adapter/XML/EnergyPlus/SimulationTimestamp)
    - XML.EnergyPlus.[Total](/documentation/oM/Adapter/XML/EnergyPlus/Total)
    - XML.EnergyPlus.[ZoneComponentLoadSummary](/documentation/oM/Adapter/XML/EnergyPlus/ZoneComponentLoadSummary)
    - XML.EnergyPlus.[ZoneDryBulbTemperature](/documentation/oM/Adapter/XML/EnergyPlus/ZoneDryBulbTemperature)
    - XML.EnergyPlus.[ZoneHumidityRatioAtPeak](/documentation/oM/Adapter/XML/EnergyPlus/ZoneHumidityRatioAtPeak)
    - XML.EnergyPlus.[ZoneRelativeHumidity](/documentation/oM/Adapter/XML/EnergyPlus/ZoneRelativeHumidity)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [EnergyPlusObject.cs](https://github.com/BHoM/XML_Toolkit/blob/develop/XML_oM/EnergyPlus\EnergyPlusObject.cs)

All history and changes of the class can be found by inspection the history.
