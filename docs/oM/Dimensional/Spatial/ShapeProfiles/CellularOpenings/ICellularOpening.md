---
title: ICellularOpening
---

# Spatial.ShapeProfiles.CellularOpenings.ICellularOpening



## Interface structure

### Implemented interfaces and base types

???+ bhom "The ICellularOpening in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Spatial.ShapeProfiles.CellularOpenings.[CircularCellularOpening](/api_documentation/oM/Dimensional/Spatial/ShapeProfiles/CellularOpenings/CircularCellularOpening)
    - Spatial.ShapeProfiles.CellularOpenings.[HexagonalCellularOpening](/api_documentation/oM/Dimensional/Spatial/ShapeProfiles/CellularOpenings/HexagonalCellularOpening)
    - Spatial.ShapeProfiles.CellularOpenings.[SinusoidalCellularOpening](/api_documentation/oM/Dimensional/Spatial/ShapeProfiles/CellularOpenings/SinusoidalCellularOpening)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| WidthWebPost | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Clear distance between openings. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Spacing | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Centre to centre distance between openings. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IOpeningArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the area of a single opening. | [Area](/api_documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| IOpeningCurve | [ICurve](/api_documentation/oM/Dimensional/Geometry/ICurve) | Returns the curve of a single opening in the XY plane. | - | Spatial_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [ICellularOpening.cs](https://github.com/BHoM/BHoM/blob/develop/Spatial_oM/ShapeProfiles\CellularOpenings\ICellularOpening.cs)

All history and changes of the class can be found by inspection the history.
