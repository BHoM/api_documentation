---
title: CoolingPeakCondition
---

# <small>BH.oM.XML.</small>**CoolingPeakCondition**



## Class structure

### Implemented interfaces and base types

???+ bhom "The CoolingPeakCondition is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.XML.EnergyPlus.[EnergyPlusObject](/api/oM/Adapter/XML/EnergyPlus/EnergyPlusObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| TimeOfPeakLoad | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| OutsideDryBulbTemperature | [OutsideDryBulbTemperature](/api/oM/Adapter/XML/EnergyPlus/OutsideDryBulbTemperature) | - | - |
| OutsideWetBulbTemperature | [OutsideWetBulbTemperature](/api/oM/Adapter/XML/EnergyPlus/OutsideWetBulbTemperature) | - | - |
| OutsideHumidityRatioAtPeak | [OutsideHumidityRatioAtPeak](/api/oM/Adapter/XML/EnergyPlus/OutsideHumidityRatioAtPeak) | - | - |
| ZoneDryBulbTemperature | [ZoneDryBulbTemperature](/api/oM/Adapter/XML/EnergyPlus/ZoneDryBulbTemperature) | - | - |
| ZoneRelativeHumdity | [ZoneRelativeHumidity](/api/oM/Adapter/XML/EnergyPlus/ZoneRelativeHumidity) | - | - |
| ZoneHumidityRatioAtPeak | [ZoneHumidityRatioAtPeak](/api/oM/Adapter/XML/EnergyPlus/ZoneHumidityRatioAtPeak) | - | - |
| PeakDesignSensibleLoad | [PeakDesignSensibleLoad](/api/oM/Adapter/XML/EnergyPlus/PeakDesignSensibleLoad) | - | - |
| EstimatedInstantDelayedSensibleLoad | [EstimatedInstantDelayedSensibleLoad](/api/oM/Adapter/XML/EnergyPlus/EstimatedInstantDelayedSensibleLoad) | - | - |
| Difference | [Difference](/api/oM/Adapter/XML/EnergyPlus/Difference) | - | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class CoolingPeakCondition : BH.oM.XML.EnergyPlus.EnergyPlusObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: XML_oM.dll

The class is defined in C#. The class definition is available on github:

- [CoolingPeakCondition.cs](https://github.com/BHoM/XML_Toolkit/blob/develop/XML_oM/EnergyPlus\CoolingPeakCondition.cs)

All history and changes of the class can be found by inspection the history.
