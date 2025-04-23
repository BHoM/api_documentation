---
title: IViewCaptureSettings
---

# Adapters.Rhinoceros.ViewCapture.IViewCaptureSettings

Base itnerface for interface controling settings for view capture.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IViewCaptureSettings in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/api/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.Rhinoceros.ViewCapture.[DimensionViewCaptureSettings](/api/oM/UI/Adapters/Rhinoceros/ViewCapture/DimensionViewCaptureSettings)
    - Adapters.Rhinoceros.ViewCapture.[ScaleViewCaptureSettings](/api/oM/UI/Adapters/Rhinoceros/ViewCapture/ScaleViewCaptureSettings)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| FileFormat | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | File format to be used. | - |
| ScaleScreenItems | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) |  | - |
| DrawAxes | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Controls if the world axes should be captured or not. | - |
| DrawGrid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Controls if the grid should be captured or not. | - |
| DrawGridAxes | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Controls if the grid axes should be captured or not. | - |
| TransparentBackground | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Controls if the background should be transparent. | - |
| Preview | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) |  | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IViewCaptureSettings.cs](https://github.com/BHoM/Rhinoceros_Toolkit/blob/develop/Rhinoceros_oM/ViewCapture/IViewCaptureSettings.cs)

All history and changes of the class can be found by inspection the history.
