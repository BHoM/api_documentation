---
title: SunData
---

# <small>BH.oM.LadybugTools.</small>**SunData**



## Class structure

### Implemented interfaces and base types

???+ bhom "The SunData is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SunriseAzimuth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The azimuth angle at sunrise in degrees. Sunrise is defined as the time at which the sun is first visible above the horizon, ignoring atmospheric effects. | - |
| SunriseTime | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | The time of actual sunrise, defined as the time at which the sun is first visible above the horizon, ignoring atmospheric effects. | - |
| NoonAltitude | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The altitude angle at solar noon (when the sun is at its highest point) in degrees. | - |
| NoonTime | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | The time that the altitude is highest. | - |
| SunsetAzimuth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The azimuth angle at sunset in degrees. Sunset is defined as the time at which the sun has just finished passing the horizon, ignoring atmospheric effects. | - |
| SunsetTime | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | The time of actual sunset, defined as the time at which the sun has just finished passing the horizon, ignoring atmospheric effects. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class SunData : BH.oM.Base.IObject
```

Assembly: LadybugTools_oM.dll

The C# class definition is available on github:

- [SunData.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/MetaData\SunData.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LadybugTools_oM/SunData.json"
}
```

The JSON Schema is available on github here:

- [SunData.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LadybugTools_oM/SunData.json)
