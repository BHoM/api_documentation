---
title: ILayout2D
---

# Spatial.Layouts.ILayout2D

Base interface for all 2D layouts

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ILayout2D in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Spatial.Layouts.[ExplicitLayout](/documentation/oM/Dimensional/Spatial/Layouts/ExplicitLayout)
    - Spatial.Layouts.[LinearLayout](/documentation/oM/Dimensional/Spatial/Layouts/LinearLayout)
    - Spatial.Layouts.[MultiLinearLayout](/documentation/oM/Dimensional/Spatial/Layouts/MultiLinearLayout)
    - Spatial.Layouts.[PerimeterLayout](/documentation/oM/Dimensional/Spatial/Layouts/PerimeterLayout)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if an Layout2D is null and outputs relevant error message. | - | Spatial_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [ILayout2D.cs](https://github.com/BHoM/BHoM/blob/develop/Spatial_oM/Layouts\ILayout2D.cs)

All history and changes of the class can be found by inspection the history.
