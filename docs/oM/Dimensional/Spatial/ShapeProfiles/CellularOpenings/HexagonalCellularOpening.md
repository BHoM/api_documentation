---
title: HexagonalCellularOpening
---

# Spatial.ShapeProfiles.CellularOpenings.HexagonalCellularOpening



## Class structure

### Implemented interfaces and base types

???+ bhom "The HexagonalCellularOpening in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Spatial.ShapeProfiles.CellularOpenings.[ICellularOpening](/api_documentation/oM/Dimensional/Spatial/ShapeProfiles/CellularOpenings/ICellularOpening)
    -  Base.[IImmutable](/api_documentation/oM/Framework/Base/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Height | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Height of the hexagonal opening, equal to the height of the cut being made in the section being castellated.<br>For case of non-zero SpacerHeight, the total height of the opening will be Height+SpacerHeight. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Width | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total width of the opening. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| WidthWebPost | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Clear distance between openings. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| SpacerHeight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Height of any spacer plate between the two profile sides. Results in an octagonal opening for a non-zero value. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Spacing | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Centre to centre distance between openings. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IOpeningArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the area of a single opening. | [Area](/api_documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| IOpeningCurve | [ICurve](/api_documentation/oM/Dimensional/Geometry/ICurve) | Returns the curve of a single opening in the XY plane. | - | Spatial_Engine |
| OpeningArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the area of a single opening. | [Area](/api_documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| OpeningCurve | [Polyline](/api_documentation/oM/Dimensional/Geometry/Polyline) | Returns the curve of a single opening in the XY plane. | - | Spatial_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [HexagonalCellularOpening.cs](https://github.com/BHoM/BHoM/blob/develop/Spatial_oM/ShapeProfiles\CellularOpenings\HexagonalCellularOpening.cs)

All history and changes of the class can be found by inspection the history.
