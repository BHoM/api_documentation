---
title: IRender
---

# Graphics.IRender

Base interface for rendered objects.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IRender in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Graphics.[RenderCurve](/documentation/oM/Graphics/Graphics/RenderCurve)
    - Graphics.[RenderGeometry](/documentation/oM/Graphics/Graphics/RenderGeometry)
    - Graphics.[RenderPoint](/documentation/oM/Graphics/Graphics/RenderPoint)
    - Graphics.[RenderText](/documentation/oM/Graphics/Graphics/RenderText)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Colour | [Color](https://learn.microsoft.com/en-us/dotnet/api/System.Drawing.Color?view=netstandard-2.0) | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IBounds | [BoundingBox](/documentation/oM/Dimensional/Geometry/BoundingBox) | Computes and returns the BoundingBox of the IRender. | - | Graphics_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IRender.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Render/IRender.cs)

All history and changes of the class can be found by inspection the history.
