---
title: CoolingPeakCondition
---

# XML.EnergyPlus.CoolingPeakCondition



## Class structure

### Implemented interfaces and base types

???+ bhom "The CoolingPeakCondition in inheriting from the following base type(s) and implements the following interfaces:"

    -  XML.EnergyPlus.[EnergyPlusObject](/om_documentation/oM/Adapter/XML/EnergyPlus/EnergyPlusObject)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| TimeOfPeakLoad | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| OutsideDryBulbTemperature | [OutsideDryBulbTemperature](/om_documentation/oM/Adapter/XML/EnergyPlus/OutsideDryBulbTemperature) | - | - |
| OutsideWetBulbTemperature | [OutsideWetBulbTemperature](/om_documentation/oM/Adapter/XML/EnergyPlus/OutsideWetBulbTemperature) | - | - |
| OutsideHumidityRatioAtPeak | [OutsideHumidityRatioAtPeak](/om_documentation/oM/Adapter/XML/EnergyPlus/OutsideHumidityRatioAtPeak) | - | - |
| ZoneDryBulbTemperature | [ZoneDryBulbTemperature](/om_documentation/oM/Adapter/XML/EnergyPlus/ZoneDryBulbTemperature) | - | - |
| ZoneRelativeHumdity | [ZoneRelativeHumidity](/om_documentation/oM/Adapter/XML/EnergyPlus/ZoneRelativeHumidity) | - | - |
| ZoneHumidityRatioAtPeak | [ZoneHumidityRatioAtPeak](/om_documentation/oM/Adapter/XML/EnergyPlus/ZoneHumidityRatioAtPeak) | - | - |
| PeakDesignSensibleLoad | [PeakDesignSensibleLoad](/om_documentation/oM/Adapter/XML/EnergyPlus/PeakDesignSensibleLoad) | - | - |
| EstimatedInstantDelayedSensibleLoad | [EstimatedInstantDelayedSensibleLoad](/om_documentation/oM/Adapter/XML/EnergyPlus/EstimatedInstantDelayedSensibleLoad) | - | - |
| Difference | [Difference](/om_documentation/oM/Adapter/XML/EnergyPlus/Difference) | - | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |
| Fragments | [FragmentSet](/om_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [CoolingPeakCondition.cs](https://github.com/BHoM/XML_Toolkit/blob/develop/XML_oM/EnergyPlus\CoolingPeakCondition.cs)

All history and changes of the class can be found by inspection the history.
