---
title: DimensionViewCaptureSettings
---

# Adapters.Rhinoceros.ViewCapture.DimensionViewCaptureSettings

View capture settings class with control over the final size of the image in pixels.

## Class structure

### Implemented interfaces and base types

???+ bhom "The DimensionViewCaptureSettings in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapters.Rhinoceros.ViewCapture.[IViewCaptureSettings](/documentation/oM/UI/Adapters/Rhinoceros/ViewCapture/IViewCaptureSettings)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


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

The class is defined in C#. The class definition is available on github:

- [DimensionViewCaptureSettings.cs](https://github.com/BHoM/Rhinoceros_Toolkit/blob/develop/Rhinoceros_oM/ViewCapture/DimensionViewCaptureSettings.cs)

All history and changes of the class can be found by inspection the history.
