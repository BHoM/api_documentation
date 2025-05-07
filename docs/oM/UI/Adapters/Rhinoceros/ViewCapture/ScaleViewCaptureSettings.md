---
title: ScaleViewCaptureSettings
---

# <small>BH.oM.Adapters.Rhinoceros.ViewCapture.</small>**ScaleViewCaptureSettings**

View capture settings allowing the size of the image to be controled as a scale of the current viewport size.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ScaleViewCaptureSettings is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapters.Rhinoceros.ViewCapture.[IViewCaptureSettings](/api/oM/UI/Adapters/Rhinoceros/ViewCapture/IViewCaptureSettings)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Scale | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Scale factor of the current preview. A factor of 2 gives a resolution twice to the current viewport resolution. | - |
| FileFormat | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | File format to be used. Defaults to png. | - |
| ScaleScreenItems | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) |  | - |
| DrawAxes | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Controls if the world axes should be captured or not. | - |
| DrawGrid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Controls if the grid should be captured or not. | - |
| DrawGridAxes | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Controls if the grid axes should be captured or not. | - |
| TransparentBackground | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Controls if the background should be transparent. | - |
| Preview | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) |  | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ScaleViewCaptureSettings : BH.oM.Adapters.Rhinoceros.ViewCapture.IViewCaptureSettings, BH.oM.Base.IObject
```

Assembly: Rhinoceros_oM.dll

The C# class definition is available on github:

- [ScaleViewCaptureSettings.cs](https://github.com/BHoM/Rhinoceros_Toolkit/blob/develop/Rhinoceros_oM/ViewCapture\ScaleViewCaptureSettings.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Rhinoceros_oM/ViewCapture/ScaleViewCaptureSettings.json"
}
```

The JSON Schema is available on github here:

- [ScaleViewCaptureSettings.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Rhinoceros_oM/ViewCapture/ScaleViewCaptureSettings.json)
