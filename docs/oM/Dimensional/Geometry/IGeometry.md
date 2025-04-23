---
title: IGeometry
---

# Geometry.IGeometry

The parent interface for all primative geometrical objects.
IGeometry implements IObject - and not IBHoMObject. Equally primative geometrical objects do not inherit from the base BHoMObject class either. As primatives, the additional base BHoM properties are omitted for both efficency and performace.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IGeometry in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/api/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Geometry.[IBoundary](/api/oM/Dimensional/Geometry/IBoundary)
    - Geometry.[ICurve](/api/oM/Dimensional/Geometry/ICurve)
    - Geometry.[IPolyCurve](/api/oM/Dimensional/Geometry/IPolyCurve)
    - Geometry.[IPolyline](/api/oM/Dimensional/Geometry/IPolyline)
    - Geometry.[ISolid](/api/oM/Dimensional/Geometry/ISolid)
    - Geometry.[ISurface](/api/oM/Dimensional/Geometry/ISurface)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Geometry.[Arc](/api/oM/Dimensional/Geometry/Arc)
    - Geometry.[BoundaryCurve](/api/oM/Dimensional/Geometry/BoundaryCurve)
    - Geometry.[Circle](/api/oM/Dimensional/Geometry/Circle)
    - Geometry.[Ellipse](/api/oM/Dimensional/Geometry/Ellipse)
    - Geometry.[Line](/api/oM/Dimensional/Geometry/Line)
    - Geometry.[NurbsCurve](/api/oM/Dimensional/Geometry/NurbsCurve)
    - Geometry.[PolyCurve](/api/oM/Dimensional/Geometry/PolyCurve)
    - Geometry.[Polygon](/api/oM/Dimensional/Geometry/Polygon)
    - Geometry.[Polyline](/api/oM/Dimensional/Geometry/Polyline)
    - Geometry.[CellRelation](/api/oM/Dimensional/Geometry/CellRelation)
    - Geometry.[Face](/api/oM/Dimensional/Geometry/Face)
    - Geometry.[Mesh](/api/oM/Dimensional/Geometry/Mesh)
    - Geometry.[Mesh3D](/api/oM/Dimensional/Geometry/Mesh3D)
    - Geometry.[BoundingBox](/api/oM/Dimensional/Geometry/BoundingBox)
    - Geometry.[CompositeGeometry](/api/oM/Dimensional/Geometry/CompositeGeometry)
    - Geometry.[Quaternion](/api/oM/Dimensional/Geometry/Quaternion)
    - Geometry.[SurfaceTrim](/api/oM/Dimensional/Geometry/SurfaceTrim)
    - Geometry.[TransformMatrix](/api/oM/Dimensional/Geometry/TransformMatrix)
    - Geometry.[BoundaryRepresentation](/api/oM/Dimensional/Geometry/BoundaryRepresentation)
    - Geometry.[Cone](/api/oM/Dimensional/Geometry/Cone)
    - Geometry.[Cuboid](/api/oM/Dimensional/Geometry/Cuboid)
    - Geometry.[Cylinder](/api/oM/Dimensional/Geometry/Cylinder)
    - Geometry.[Sphere](/api/oM/Dimensional/Geometry/Sphere)
    - Geometry.[Torus](/api/oM/Dimensional/Geometry/Torus)
    - Geometry.[Extrusion](/api/oM/Dimensional/Geometry/Extrusion)
    - Geometry.[Loft](/api/oM/Dimensional/Geometry/Loft)
    - Geometry.[NurbsSurface](/api/oM/Dimensional/Geometry/NurbsSurface)
    - Geometry.[Pipe](/api/oM/Dimensional/Geometry/Pipe)
    - Geometry.[PlanarSurface](/api/oM/Dimensional/Geometry/PlanarSurface)
    - Geometry.[PolySurface](/api/oM/Dimensional/Geometry/PolySurface)
    - Geometry.[Basis](/api/oM/Dimensional/Geometry/Basis)
    - Geometry.[Plane](/api/oM/Dimensional/Geometry/Plane)
    - Geometry.[Point](/api/oM/Dimensional/Geometry/Point)
    - Geometry.[Vector](/api/oM/Dimensional/Geometry/Vector)
    - Geometry.CoordinateSystem.[Cartesian](/api/oM/Dimensional/Geometry/CoordinateSystem/Cartesian)
    - Graphics.[RenderMesh](/api/oM/Graphics/Graphics/RenderMesh)
    - Graphics.[RenderPoint](/api/oM/Graphics/Graphics/RenderPoint)


## Properties

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


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IGeometry.cs](https://github.com/BHoM/BHoM/blob/develop/Geometry_oM/Interface/IGeometry.cs)

All history and changes of the class can be found by inspection the history.
