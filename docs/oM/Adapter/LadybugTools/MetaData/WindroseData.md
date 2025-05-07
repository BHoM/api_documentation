---
title: WindroseData
---

# <small>BH.oM.LadybugTools.</small>**WindroseData**



## Class structure

### Implemented interfaces and base types

???+ bhom "The WindroseData is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LadybugTools.[ISimulationData](/api/oM/Adapter/LadybugTools/MetaData/ISimulationData)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


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

``` C# title="C#"
public class WindroseData : BH.oM.LadybugTools.ISimulationData, BH.oM.Base.IObject
```

Assembly: LadybugTools_oM.dll

The C# class definition is available on github:

- [WindroseData.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/MetaData\WindroseData.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LadybugTools_oM/WindroseData.json"
}
```

The JSON Schema is available on github here:

- [WindroseData.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LadybugTools_oM/WindroseData.json)
