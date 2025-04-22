---
title: Cartesian
---

# Geometry.CoordinateSystem.Cartesian

A three-dimensional Cartesian coordinate system, as defined by a set of mutually orthogonal unit vectors and a common origin point

## Class structure

### Implemented interfaces and base types

???+ bhom "The Cartesian in inheriting from the following base type(s) and implements the following interfaces:"

    -  Geometry.[IGeometry](/api_documentation/oM/Dimensional/Geometry/IGeometry)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Base.[IImmutable](/api_documentation/oM/Framework/Base/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| X | [Vector](/api_documentation/oM/Dimensional/Geometry/Vector) | Unit vector defining local x coordinate axis | - |
| Y | [Vector](/api_documentation/oM/Dimensional/Geometry/Vector) | Unit vector defining local y coordinate axis | - |
| Z | [Vector](/api_documentation/oM/Dimensional/Geometry/Vector) | Unit vector defining local z coordinate axis | - |
| Origin | [Point](/api_documentation/oM/Dimensional/Geometry/Point) | Location point in three-dimensional space defining (0,0,0) and the origin for each axis | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Bounds | [BoundingBox](/api_documentation/oM/Dimensional/Geometry/BoundingBox) | Returns the global world axis oriented BoundingBox of the Cartesian coordinate system. If the coordinate system is parallel to any of the world axis, the returned BoundingBox will be an infinite flat box in the plane. If not, the rturned box will be infinite box in all coordinate directions. | - | Geometry_Engine |
| GeometryHash | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a signature of the input geometry, useful for diffing.<br>The hash is computed as a serialised array representing the coordinate of significant points taken on the geometry.<br>The number of points is reduced to the minimum essential to determine uniquely any geometry.<br>Additionally, the resulting points are transformed based on the source geometry type, to remove or minimize collisions.<br>(Any transformation so performed is translational only, in order to support geometrical tolerance, i.e. numerical distance, when comparing GeometryHashes downstream). | - | Geometry_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the area of the provided geometry. | [Area](/api_documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] | Geometry_Engine |
| IBounds | [BoundingBox](/api_documentation/oM/Dimensional/Geometry/BoundingBox) | Returns the global world axis oriented enclosing BoundingBox for all points of the geometry, i.e. the box with the smallest volume within which all the points on the geometry lie. | - | Geometry_Engine |
| IHashArray | [Double[]](https://learn.microsoft.com/en-us/dotnet/api/System.Double[]?view=netstandard-2.0) | Returns a signature of the input geometry, useful for distance-based comparisons and diffing.<br>The hash is computed as an array representing the coordinate of significant points taken on the geometry.<br>The number of points is reduced to the minimum essential to determine uniquely any geometry.<br>Additionally, the resulting points are transformed based on the source geometry type, to remove or minimize collisions.<br>(Any transformation so performed is translational only, in order to support geometrical tolerance, i.e. numerical distance, when comparing GeometryHashes downstream). | - | Geometry_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the IGeometry is planar, i.e. all of its parts fit in a single plane. | - | Geometry_Engine |
| IIsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - | Geometry_Engine |
| INormals | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Vector](/api_documentation/oM/Dimensional/Geometry/Vector)&gt; | Interface method that returns the list of vectors normal to any IGeometry. | - | Geometry_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Geometry is null and outputs relevant error message. | - | Geometry_Engine |
| ISubParts | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[IGeometry](/api_documentation/oM/Dimensional/Geometry/IGeometry)&gt; | - | - | Geometry_Engine |
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - | Geometry_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Cartesian.cs](https://github.com/BHoM/BHoM/blob/develop/Geometry_oM/CoordinateSystem\Cartesian.cs)

All history and changes of the class can be found by inspection the history.
