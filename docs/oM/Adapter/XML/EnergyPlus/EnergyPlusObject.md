---
title: EnergyPlusObject
---

# <small>BH.oM.XML.EnergyPlus.</small>**EnergyPlusObject**



## Class structure

### Implemented interfaces and base types

???+ bhom "The EnergyPlusObject is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes inheriting from this class

???+ bhom "The following classes are inheriting from this class:"

    - BH.oM.XML.EnergyPlus.[CoolingPeakCondition](/api/oM/Adapter/XML/EnergyPlus/CoolingPeakCondition)
    - BH.oM.XML.EnergyPlus.[Difference](/api/oM/Adapter/XML/EnergyPlus/Difference)
    - BH.oM.XML.EnergyPlus.[EnergyPlusTabularReport](/api/oM/Adapter/XML/EnergyPlus/EnergyPlusTabularReport)
    - BH.oM.XML.EnergyPlus.[EstimatedCoolingPeakLoadComponent](/api/oM/Adapter/XML/EnergyPlus/EstimatedCoolingPeakLoadComponent)
    - BH.oM.XML.EnergyPlus.[EstimatedInstantDelayedSensibleLoad](/api/oM/Adapter/XML/EnergyPlus/EstimatedInstantDelayedSensibleLoad)
    - BH.oM.XML.EnergyPlus.[HeatingPeakCondition](/api/oM/Adapter/XML/EnergyPlus/HeatingPeakCondition)
    - BH.oM.XML.EnergyPlus.[Latent](/api/oM/Adapter/XML/EnergyPlus/Latent)
    - BH.oM.XML.EnergyPlus.[OutsideDryBulbTemperature](/api/oM/Adapter/XML/EnergyPlus/OutsideDryBulbTemperature)
    - BH.oM.XML.EnergyPlus.[OutsideHumidityRatioAtPeak](/api/oM/Adapter/XML/EnergyPlus/OutsideHumidityRatioAtPeak)
    - BH.oM.XML.EnergyPlus.[OutsideWetBulbTemperature](/api/oM/Adapter/XML/EnergyPlus/OutsideWetBulbTemperature)
    - BH.oM.XML.EnergyPlus.[PeakDesignSensibleLoad](/api/oM/Adapter/XML/EnergyPlus/PeakDesignSensibleLoad)
    - BH.oM.XML.EnergyPlus.[SensibleDelayed](/api/oM/Adapter/XML/EnergyPlus/SensibleDelayed)
    - BH.oM.XML.EnergyPlus.[SensibleInstant](/api/oM/Adapter/XML/EnergyPlus/SensibleInstant)
    - BH.oM.XML.EnergyPlus.[SensibleReturnAir](/api/oM/Adapter/XML/EnergyPlus/SensibleReturnAir)
    - BH.oM.XML.EnergyPlus.[SimulationTimestamp](/api/oM/Adapter/XML/EnergyPlus/SimulationTimestamp)
    - BH.oM.XML.EnergyPlus.[Total](/api/oM/Adapter/XML/EnergyPlus/Total)
    - BH.oM.XML.EnergyPlus.[ZoneComponentLoadSummary](/api/oM/Adapter/XML/EnergyPlus/ZoneComponentLoadSummary)
    - BH.oM.XML.EnergyPlus.[ZoneDryBulbTemperature](/api/oM/Adapter/XML/EnergyPlus/ZoneDryBulbTemperature)
    - BH.oM.XML.EnergyPlus.[ZoneHumidityRatioAtPeak](/api/oM/Adapter/XML/EnergyPlus/ZoneHumidityRatioAtPeak)
    - BH.oM.XML.EnergyPlus.[ZoneRelativeHumidity](/api/oM/Adapter/XML/EnergyPlus/ZoneRelativeHumidity)


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

``` C# title="C#"
public class EnergyPlusObject : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: XML_oM.dll

The class is defined in C#. The class definition is available on github:

- [EnergyPlusObject.cs](https://github.com/BHoM/XML_Toolkit/blob/develop/XML_oM/EnergyPlus\EnergyPlusObject.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/XML_oM/EnergyPlus/EnergyPlusObject.json}
```

The JSON Schema is available on github here:

- [EnergyPlusObject.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/XML_oM/EnergyPlus/EnergyPlusObject.json)
