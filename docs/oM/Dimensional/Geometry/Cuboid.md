---
title: Cuboid
---

# Geometry.Cuboid

A polyhedron. Standard cuboid consisting of six right-angled quadrilateral faces.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Cuboid in inheriting from the following base type(s) and implements the following interfaces:"

    -  Geometry.[ISolid](/api/oM/Dimensional/Geometry/ISolid)
    -  Geometry.[IGeometry](/api/oM/Dimensional/Geometry/IGeometry)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| CoordinateSystem | [Cartesian](/api/oM/Dimensional/Geometry/CoordinateSystem/Cartesian) | Defines both the Cuboid centre as the CoordinateSystem Origin, as well as the orientation in three-dimensional space. | - |
| Length | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Dimension in the local x-axis. The Cuboid will have one face at a distance of Length/2 from the centre along the positive local x-axis and, one face at a distance of Length/2 from the centre along the negative local x-axis. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Depth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Dimension in the local y-axis. The Cuboid will have one face at a distance of Depth/2 from the centre along the positive local y-axis and, one face at a distance of Depth/2 from the centre along the negative local y-axis. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Height | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Dimension in the local z-axis. The Cuboid will have one face at a distance of Height/2 from the centre along the positive local z-axis and, one face at a distance of Height/2 from the centre along the negative local z-axis. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| GeometryHash | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a signature of the input geometry, useful for diffing.<br>The hash is computed as a serialised array representing the coordinate of significant points taken on the geometry.<br>The number of points is reduced to the minimum essential to determine uniquely any geometry.<br>Additionally, the resulting points are transformed based on the source geometry type, to remove or minimize collisions.<br>(Any transformation so performed is translational only, in order to support geometrical tolerance, i.e. numerical distance, when comparing GeometryHashes downstream). | - | Geometry_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the area of the provided geometry. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Geometry_Engine |
| IBounds | [BoundingBox](/api/oM/Dimensional/Geometry/BoundingBox) | Returns the global world axis oriented enclosing BoundingBox for all points of the geometry, i.e. the box with the smallest volume within which all the points on the geometry lie. | - | Geometry_Engine |
| IHashArray | [Double[]](https://learn.microsoft.com/en-us/dotnet/api/System.Double[]?view=netstandard-2.0) | Returns a signature of the input geometry, useful for distance-based comparisons and diffing.<br>The hash is computed as an array representing the coordinate of significant points taken on the geometry.<br>The number of points is reduced to the minimum essential to determine uniquely any geometry.<br>Additionally, the resulting points are transformed based on the source geometry type, to remove or minimize collisions.<br>(Any transformation so performed is translational only, in order to support geometrical tolerance, i.e. numerical distance, when comparing GeometryHashes downstream). | - | Geometry_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the IGeometry is planar, i.e. all of its parts fit in a single plane. | - | Geometry_Engine |
| IIsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - | Geometry_Engine |
| INormals | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Vector](/api/oM/Dimensional/Geometry/Vector)&gt; | Interface method that returns the list of vectors normal to any IGeometry. | - | Geometry_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Geometry is null and outputs relevant error message. | - | Geometry_Engine |
| ISubParts | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[IGeometry](/api/oM/Dimensional/Geometry/IGeometry)&gt; | - | - | Geometry_Engine |
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - | Geometry_Engine |
| IVolume | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the enclosed volume of a solid. | [Volume](/api/oM/Dimensional/Quantities/Attributes/Volume) [m³] | Geometry_Engine |
| Volume | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the analytical solid volume. | [Volume](/api/oM/Dimensional/Quantities/Attributes/Volume) [m³] | Geometry_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Cuboid.cs](https://github.com/BHoM/BHoM/blob/develop/Geometry_oM/Solid/Cuboid.cs)

All history and changes of the class can be found by inspection the history.
