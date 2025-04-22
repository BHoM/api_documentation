---
title: ICurveLayout
---

# Spatial.Layouts.ICurveLayout

Base interface for all curve layouts.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ICurveLayout in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Spatial.Layouts.[ExplicitCurveLayout](/api_documentation/oM/Dimensional/Spatial/Layouts/ExplicitCurveLayout)
    - Spatial.Layouts.[OffsetCurveLayout](/api_documentation/oM/Dimensional/Spatial/Layouts/OffsetCurveLayout)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if an CurveLayout is null and outputs relevant error message. | - | Spatial_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [ICurveLayout.cs](https://github.com/BHoM/BHoM/blob/develop/Spatial_oM/Layouts\ICurveLayout.cs)

All history and changes of the class can be found by inspection the history.
