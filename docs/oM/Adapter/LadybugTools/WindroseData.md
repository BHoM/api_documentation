---
title: WindroseData
---

# LadybugTools.WindroseData



## Class structure

### Implemented interfaces and base types

???+ bhom "The WindroseData in inheriting from the following base type(s) and implements the following interfaces:"

    -  LadybugTools.[ISimulationData](/api/oM/Adapter/LadybugTools/ISimulationData)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PrevailingDirection | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt; | The direction bin of the prevailing wind, defined as two values (in degrees) for the lower and upper values for the bin, where 0 degrees is north. | - |
| PrevailingPercentile95 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The 95th percentile wind speed value in the prevailing direction. | - |
| PrevailingPercentile50 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The median (50th percentile) wind speed value in the prevailing direction. | - |
| Percentile95 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The 95th percentile wind speed value. | - |
| Percentile50 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The median (50th percentile) wind speed value. | - |
| RatioOfCalmHours | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The ratio of calm hours to total hours. Calm hours are hours with a wind speed of 1e-10 or less. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [WindroseData.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/MetaData/WindroseData.cs)

All history and changes of the class can be found by inspection the history.
