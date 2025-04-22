---
title: IGeometry
---

# Geometry.IGeometry

The parent interface for all primative geometrical objects.
IGeometry implements IObject - and not IBHoMObject. Equally primative geometrical objects do not inherit from the base BHoMObject class either. As primatives, the additional base BHoM properties are omitted for both efficency and performace.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IGeometry in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Geometry.[IBoundary](/api_documentation/oM/Dimensional/Geometry/IBoundary)
    - Geometry.[ICurve](/api_documentation/oM/Dimensional/Geometry/ICurve)
    - Geometry.[IPolyCurve](/api_documentation/oM/Dimensional/Geometry/IPolyCurve)
    - Geometry.[IPolyline](/api_documentation/oM/Dimensional/Geometry/IPolyline)
    - Geometry.[ISolid](/api_documentation/oM/Dimensional/Geometry/ISolid)
    - Geometry.[ISurface](/api_documentation/oM/Dimensional/Geometry/ISurface)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Geometry.[Arc](/api_documentation/oM/Dimensional/Geometry/Arc)
    - Geometry.[BoundaryCurve](/api_documentation/oM/Dimensional/Geometry/BoundaryCurve)
    - Geometry.[Circle](/api_documentation/oM/Dimensional/Geometry/Circle)
    - Geometry.[Ellipse](/api_documentation/oM/Dimensional/Geometry/Ellipse)
    - Geometry.[Line](/api_documentation/oM/Dimensional/Geometry/Line)
    - Geometry.[NurbsCurve](/api_documentation/oM/Dimensional/Geometry/NurbsCurve)
    - Geometry.[PolyCurve](/api_documentation/oM/Dimensional/Geometry/PolyCurve)
    - Geometry.[Polygon](/api_documentation/oM/Dimensional/Geometry/Polygon)
    - Geometry.[Polyline](/api_documentation/oM/Dimensional/Geometry/Polyline)
    - Geometry.[CellRelation](/api_documentation/oM/Dimensional/Geometry/CellRelation)
    - Geometry.[Face](/api_documentation/oM/Dimensional/Geometry/Face)
    - Geometry.[Mesh](/api_documentation/oM/Dimensional/Geometry/Mesh)
    - Geometry.[Mesh3D](/api_documentation/oM/Dimensional/Geometry/Mesh3D)
    - Geometry.[BoundingBox](/api_documentation/oM/Dimensional/Geometry/BoundingBox)
    - Geometry.[CompositeGeometry](/api_documentation/oM/Dimensional/Geometry/CompositeGeometry)
    - Geometry.[Quaternion](/api_documentation/oM/Dimensional/Geometry/Quaternion)
    - Geometry.[SurfaceTrim](/api_documentation/oM/Dimensional/Geometry/SurfaceTrim)
    - Geometry.[TransformMatrix](/api_documentation/oM/Dimensional/Geometry/TransformMatrix)
    - Geometry.[BoundaryRepresentation](/api_documentation/oM/Dimensional/Geometry/BoundaryRepresentation)
    - Geometry.[Cone](/api_documentation/oM/Dimensional/Geometry/Cone)
    - Geometry.[Cuboid](/api_documentation/oM/Dimensional/Geometry/Cuboid)
    - Geometry.[Cylinder](/api_documentation/oM/Dimensional/Geometry/Cylinder)
    - Geometry.[Sphere](/api_documentation/oM/Dimensional/Geometry/Sphere)
    - Geometry.[Torus](/api_documentation/oM/Dimensional/Geometry/Torus)
    - Geometry.[Extrusion](/api_documentation/oM/Dimensional/Geometry/Extrusion)
    - Geometry.[Loft](/api_documentation/oM/Dimensional/Geometry/Loft)
    - Geometry.[NurbsSurface](/api_documentation/oM/Dimensional/Geometry/NurbsSurface)
    - Geometry.[Pipe](/api_documentation/oM/Dimensional/Geometry/Pipe)
    - Geometry.[PlanarSurface](/api_documentation/oM/Dimensional/Geometry/PlanarSurface)
    - Geometry.[PolySurface](/api_documentation/oM/Dimensional/Geometry/PolySurface)
    - Geometry.[Basis](/api_documentation/oM/Dimensional/Geometry/Basis)
    - Geometry.[Plane](/api_documentation/oM/Dimensional/Geometry/Plane)
    - Geometry.[Point](/api_documentation/oM/Dimensional/Geometry/Point)
    - Geometry.[Vector](/api_documentation/oM/Dimensional/Geometry/Vector)
    - Geometry.CoordinateSystem.[Cartesian](/api_documentation/oM/Dimensional/Geometry/CoordinateSystem/Cartesian)
    - Graphics.[RenderMesh](/api_documentation/oM/Graphics/Graphics/RenderMesh)
    - Graphics.[RenderPoint](/api_documentation/oM/Graphics/Graphics/RenderPoint)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
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

The interface is defined in C#. The class definition is available on github:

- [IGeometry.cs](https://github.com/BHoM/BHoM/blob/develop/Geometry_oM/Interface/IGeometry.cs)

All history and changes of the class can be found by inspection the history.
