---
title: IElement1D
---

# Dimensional.IElement1D

Enables geometrical operations to be performed on a Curve based spatial element, whilst preserving all other object properties as unchanged. /nObjects implementing this interface will be required to implement some base methods for getting and setting data in a way that maintains the object's other properties.

[Documentation link](https://bhom.xyz/documentation/BHoM_oM/Dimensional_oM/IElement-required-extension-methods/)

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IElement1D in inheriting from the following base type(s) and implements the following interfaces:"

    -  Dimensional.[IElement](/om_documentation/oM/Dimensional/Dimensional/IElement)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Analytical.Elements.[IEdge](/om_documentation/oM/Analytical/Analytical/Elements/IEdge)
    - Analytical.Elements.[ILink](/om_documentation/oM/Analytical/Analytical/Elements/ILink%601)&lt;[TNode](/om_documentation/oM/Analytical/Analytical/Elements/ILink%601#tnode)&gt;
    - Geometry.[IBoundary](/om_documentation/oM/Dimensional/Geometry/IBoundary)
    - Geometry.[ICurve](/om_documentation/oM/Dimensional/Geometry/ICurve)
    - Geometry.[IPolyCurve](/om_documentation/oM/Dimensional/Geometry/IPolyCurve)
    - Geometry.[IPolyline](/om_documentation/oM/Dimensional/Geometry/IPolyline)
    - MEP.System.[IFlow](/om_documentation/oM/Analytical/MEP/System/IFlow)
    - Physical.Elements.[IFramingElement](/om_documentation/oM/Physical/Physical/Elements/IFramingElement)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Environment.Elements.[Edge](/om_documentation/oM/Analytical/Environment/Elements/Edge)
    - Facade.Elements.[FrameEdge](/om_documentation/oM/Analytical/Facade/Elements/FrameEdge)
    - Geometry.[Arc](/om_documentation/oM/Dimensional/Geometry/Arc)
    - Geometry.[BoundaryCurve](/om_documentation/oM/Dimensional/Geometry/BoundaryCurve)
    - Geometry.[Circle](/om_documentation/oM/Dimensional/Geometry/Circle)
    - Geometry.[Ellipse](/om_documentation/oM/Dimensional/Geometry/Ellipse)
    - Geometry.[Line](/om_documentation/oM/Dimensional/Geometry/Line)
    - Geometry.[NurbsCurve](/om_documentation/oM/Dimensional/Geometry/NurbsCurve)
    - Geometry.[PolyCurve](/om_documentation/oM/Dimensional/Geometry/PolyCurve)
    - Geometry.[Polygon](/om_documentation/oM/Dimensional/Geometry/Polygon)
    - Geometry.[Polyline](/om_documentation/oM/Dimensional/Geometry/Polyline)
    - Adapters.GSA.Elements.[Spacer](/om_documentation/oM/Adapter/Adapters/GSA/Elements/Spacer)
    - MEP.System.[CableTray](/om_documentation/oM/Analytical/MEP/System/CableTray)
    - MEP.System.[Duct](/om_documentation/oM/Analytical/MEP/System/Duct)
    - MEP.System.[FlowSystem](/om_documentation/oM/Analytical/MEP/System/FlowSystem)
    - MEP.System.[Pipe](/om_documentation/oM/Analytical/MEP/System/Pipe)
    - MEP.System.[WireSegment](/om_documentation/oM/Analytical/MEP/System/WireSegment)
    - Physical.Elements.[Beam](/om_documentation/oM/Physical/Physical/Elements/Beam)
    - Physical.Elements.[Bracing](/om_documentation/oM/Physical/Physical/Elements/Bracing)
    - Physical.Elements.[Cable](/om_documentation/oM/Physical/Physical/Elements/Cable)
    - Physical.Elements.[Column](/om_documentation/oM/Physical/Physical/Elements/Column)
    - Physical.Elements.[Pile](/om_documentation/oM/Physical/Physical/Elements/Pile)
    - Spatial.SettingOut.[Grid](/om_documentation/oM/Dimensional/Spatial/SettingOut/Grid)
    - Structure.Elements.[Bar](/om_documentation/oM/Analytical/Structure/Elements/Bar)
    - Structure.Elements.[Edge](/om_documentation/oM/Analytical/Structure/Elements/Edge)
    - Structure.Elements.[Pile](/om_documentation/oM/Analytical/Structure/Elements/Pile)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Bounds | [BoundingBox](/om_documentation/oM/Dimensional/Geometry/BoundingBox) | Queries the IElement1Ds BoundingBox. Acts on the ICurve definition of the IElement1D through the Geometry_Engine. | - | Spatial_Engine |
| Centroid | [Point](/om_documentation/oM/Dimensional/Geometry/Point) | Queries the centre of weight for a IElement1Ds ICurve representation. | - | Spatial_Engine |
| ControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/om_documentation/oM/Dimensional/Geometry/Point)&gt; | Queries the control points of the one dimensional representation of the IElement1D. | - | Spatial_Engine |
| DominantVector | [Vector](/om_documentation/oM/Dimensional/Geometry/Vector) | Gets the the dominant vector (orientation) of an Element1D based on its lines lengths. | - | Spatial_Engine |
| ElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/om_documentation/oM/Dimensional/Geometry/ICurve)&gt; | Queries the defining curves of an IElement1D. | - | Spatial_Engine |
| ElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/om_documentation/oM/Dimensional/Geometry/Point)&gt; | Returns the discontinuity points from the defining ICurve of the IElement1D. | - | Spatial_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the area of the geometrical representation of an IElement. | [Area](/om_documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| IBounds | [BoundingBox](/om_documentation/oM/Dimensional/Geometry/BoundingBox) | Queries the IElements BoundingBox. Acts on the elements geometrical definition of the IElement through the Geometry_Engine. | - | Spatial_Engine |
| ICentroid | [Point](/om_documentation/oM/Dimensional/Geometry/Point) | Queries the centre of weight for the homogeneous geometrical representation of an IElement. | - | Spatial_Engine |
| IControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/om_documentation/oM/Dimensional/Geometry/Point)&gt; | Queries the control points of the geometrical representation of an IElement. | - | Spatial_Engine |
| IElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/om_documentation/oM/Dimensional/Geometry/ICurve)&gt; | Queries the geometricly defining curves of the IElements geometry. | - | Spatial_Engine |
| IElements0D | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElement0D](/om_documentation/oM/Dimensional/Dimensional/IElement0D)&gt; | Queries the IElement0Ds from a IElement1D. Returns null if no IElement0Ds are defined for the type of IElement1D. | - | Spatial_Engine |
| IElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/om_documentation/oM/Dimensional/Geometry/Point)&gt; | Returns the discontinuity points from the defining ICurves of the IElement. | - | Spatial_Engine |
| IGeometry | [ICurve](/om_documentation/oM/Dimensional/Geometry/ICurve) | Queries the defining geometrical object which all spatial operations will act on. | - | Spatial_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IIsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any of the curves defining an IElement is closer to itself than the tolerance at any two points (is self intersecting). In case of IElement2D, does not check for intersections between external and internal curves, or between different internal curves. | - | Spatial_Engine |
| IPrimaryPropertyName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns the name of an elements primary defining property | - | Facade_Engine |
| IsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the one dimensional representation of the IElement1D is closer to itself than the tolerance at any two points. | - | Spatial_Engine |
| Length | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the length of the IElement1Ds curve. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Spatial_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IElement1D.cs](https://github.com/BHoM/BHoM/blob/develop/Dimensional_oM/IElement1D.cs)

All history and changes of the class can be found by inspection the history.
