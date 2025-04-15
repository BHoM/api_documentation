---
title: ScaleViewCaptureSettings
---

# Adapters.Rhinoceros.ViewCapture.ScaleViewCaptureSettings

View capture settings allowing the size of the image to be controled as a scale of the current viewport size.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ScaleViewCaptureSettings in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapters.Rhinoceros.ViewCapture.[IViewCaptureSettings](/om_documentation/oM/UI/Adapters/Rhinoceros/ViewCapture/IViewCaptureSettings)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


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

The class is defined in C#. The class definition is available on github:

- [ScaleViewCaptureSettings.cs](https://github.com/BHoM/Rhinoceros_Toolkit/blob/develop/Rhinoceros_oM/ViewCapture/ScaleViewCaptureSettings.cs)

All history and changes of the class can be found by inspection the history.
