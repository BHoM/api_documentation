---
title: DimensionViewCaptureSettings
---

# <small>BH.oM.Adapters.Rhinoceros.ViewCapture.</small>**DimensionViewCaptureSettings**

View capture settings class with control over the final size of the image in pixels.

## Class structure

### Implemented interfaces and base types

???+ bhom "The DimensionViewCaptureSettings is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapters.Rhinoceros.ViewCapture.[IViewCaptureSettings](/api/oM/UI/Adapters/Rhinoceros/ViewCapture/IViewCaptureSettings)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Width | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Width (in pixels) of the final image. | - |
| Height | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Height (in pixels) of the final image. | - |
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
public class DimensionViewCaptureSettings : BH.oM.Adapters.Rhinoceros.ViewCapture.IViewCaptureSettings, BH.oM.Base.IObject
```

Assembly: Rhinoceros_oM.dll

The C# class definition is available on github:

- [DimensionViewCaptureSettings.cs](https://github.com/BHoM/Rhinoceros_Toolkit/blob/develop/Rhinoceros_oM/ViewCapture\DimensionViewCaptureSettings.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Rhinoceros_oM/ViewCapture/DimensionViewCaptureSettings.json"
}
```

The JSON Schema is available on github here:

- [DimensionViewCaptureSettings.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Rhinoceros_oM/ViewCapture/DimensionViewCaptureSettings.json)
