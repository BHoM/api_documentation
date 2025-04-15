---
title: RenderCurve
---

# Graphics.RenderCurve

Render a curve with specified colour and thickness.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RenderCurve in inheriting from the following base type(s) and implements the following interfaces:"

    -  Graphics.[IRender](/documentation/oM/Graphics/Graphics/IRender)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Curve | [ICurve](/documentation/oM/Dimensional/Geometry/ICurve) | The curve to render. | - |
| Thickness | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | The thickness of the curve. Should be a value greater or equal to 1. | - |
| Colour | [Color](https://learn.microsoft.com/en-us/dotnet/api/System.Drawing.Color?view=netstandard-2.0) | Colour used to render the Geometry. Default is BHoM Coral with a subtle transparency (Color.FromArgb(80, 255, 41, 105)). | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IBounds | [BoundingBox](/documentation/oM/Dimensional/Geometry/BoundingBox) | Computes and returns the BoundingBox of the IRender. | - | Graphics_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [RenderCurve.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Render/RenderCurve.cs)

All history and changes of the class can be found by inspection the history.
