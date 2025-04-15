---
title: IElement2D
---

# Dimensional.IElement2D

Enables geometrical operations to be performed on an edge curve based two-dimensional spatial element, whilst preserving all other object properties as unchanged. /nThe interface expects the outline to be constructed of IElement1D elements and allows for internal IElement2D elements.Objects implementing this interface will be required to implement some base methods for getting and setting data in a way that maintains the object's other properties

[Documentation link](https://bhom.xyz/documentation/BHoM_oM/Dimensional_oM/IElement-required-extension-methods/)

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IElement2D in inheriting from the following base type(s) and implements the following interfaces:"

    -  Dimensional.[IElement](/documentation/oM/Dimensional/Dimensional/IElement)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Analytical.Elements.[IOpening](/documentation/oM/Analytical/Analytical/Elements/IOpening%601)&lt;[TEdge](/documentation/oM/Analytical/Analytical/Elements/IOpening%601#tedge)&gt;
    - Analytical.Elements.[IPanel](/documentation/oM/Analytical/Analytical/Elements/IPanel%602)&lt;[TEdge](/documentation/oM/Analytical/Analytical/Elements/IPanel%602#tedge), [TOpening](/documentation/oM/Analytical/Analytical/Elements/IPanel%602#topening)&gt;
    - Analytical.Elements.[IRegion](/documentation/oM/Analytical/Analytical/Elements/IRegion)
    - Physical.Elements.[IOpening](/documentation/oM/Physical/Physical/Elements/IOpening)
    - Physical.Elements.[ISurface](/documentation/oM/Physical/Physical/Elements/ISurface)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Architecture.Elements.[Ceiling](/documentation/oM/Analytical/Architecture/Elements/Ceiling)
    - Architecture.Elements.[CeilingTile](/documentation/oM/Analytical/Architecture/Elements/CeilingTile)
    - Architecture.Elements.[Room](/documentation/oM/Analytical/Architecture/Elements/Room)
    - Environment.Elements.[Opening](/documentation/oM/Analytical/Environment/Elements/Opening)
    - Environment.Elements.[Panel](/documentation/oM/Analytical/Environment/Elements/Panel)
    - Environment.Elements.[Space](/documentation/oM/Analytical/Environment/Elements/Space)
    - Environment.Elements.[Zone](/documentation/oM/Analytical/Environment/Elements/Zone)
    - Facade.Elements.[CurtainWall](/documentation/oM/Analytical/Facade/Elements/CurtainWall)
    - Facade.Elements.[Opening](/documentation/oM/Analytical/Facade/Elements/Opening)
    - Facade.Elements.[Panel](/documentation/oM/Analytical/Facade/Elements/Panel)
    - Geometry.[PlanarSurface](/documentation/oM/Dimensional/Geometry/PlanarSurface)
    - Physical.Elements.[Door](/documentation/oM/Physical/Physical/Elements/Door)
    - Physical.Elements.[Floor](/documentation/oM/Physical/Physical/Elements/Floor)
    - Physical.Elements.[PadFoundation](/documentation/oM/Physical/Physical/Elements/PadFoundation)
    - Physical.Elements.[Roof](/documentation/oM/Physical/Physical/Elements/Roof)
    - Physical.Elements.[Void](/documentation/oM/Physical/Physical/Elements/Void)
    - Physical.Elements.[Wall](/documentation/oM/Physical/Physical/Elements/Wall)
    - Physical.Elements.[Window](/documentation/oM/Physical/Physical/Elements/Window)
    - Structure.Reinforcement.[ReinforcementRegion](/documentation/oM/Analytical/Structure/Reinforcement/ReinforcementRegion)
    - Structure.Elements.[Opening](/documentation/oM/Analytical/Structure/Elements/Opening)
    - Structure.Elements.[PadFoundation](/documentation/oM/Analytical/Structure/Elements/PadFoundation)
    - Structure.Elements.[Panel](/documentation/oM/Analytical/Structure/Elements/Panel)
    - Structure.Elements.[Stem](/documentation/oM/Analytical/Structure/Elements/Stem)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Area | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the IElement2Ds area defined as the area confined by the outline curves subtracting the area of the internal elements. | [Area](/documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| Bounds | [BoundingBox](/documentation/oM/Dimensional/Geometry/BoundingBox) | Queries the IElement2Ds BoundingBox. Acts on the element curve definition of the IElement2D through the Geometry_Engine. | - | Spatial_Engine |
| Centroid | [Point](/documentation/oM/Dimensional/Geometry/Point) | Queries the centre of area for a IElement2Ds surface representation. For an IElement2D with homogeneous material and thickness this will also be the centre of weight. | - | Spatial_Engine |
| ControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/documentation/oM/Dimensional/Geometry/Point)&gt; | Queries the control points of the element curve representation of the IElement2D. | - | Spatial_Engine |
| DominantVector | [Vector](/documentation/oM/Dimensional/Geometry/Vector) | Gets the the dominant vector (orientation) of an Element2D based on its lines lengths. | - | Spatial_Engine |
| ElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/documentation/oM/Dimensional/Geometry/ICurve)&gt; | Queries the geometricly defining curves of the IElement2Ds surface. | - | Spatial_Engine |
| ElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/documentation/oM/Dimensional/Geometry/Point)&gt; | Returns the discontinuity points from the defining ICurves of the IElement2D. | - | Spatial_Engine |
| ExternalElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/documentation/oM/Dimensional/Geometry/ICurve)&gt; | Queries the geometricly defining external curves of the IElement2Ds surface. | - | Spatial_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the area of the geometrical representation of an IElement. | [Area](/documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| IBounds | [BoundingBox](/documentation/oM/Dimensional/Geometry/BoundingBox) | Queries the IElements BoundingBox. Acts on the elements geometrical definition of the IElement through the Geometry_Engine. | - | Spatial_Engine |
| ICentroid | [Point](/documentation/oM/Dimensional/Geometry/Point) | Queries the centre of weight for the homogeneous geometrical representation of an IElement. | - | Spatial_Engine |
| IControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/documentation/oM/Dimensional/Geometry/Point)&gt; | Queries the control points of the geometrical representation of an IElement. | - | Spatial_Engine |
| IElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/documentation/oM/Dimensional/Geometry/ICurve)&gt; | Queries the geometricly defining curves of the IElements geometry. | - | Spatial_Engine |
| IElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/documentation/oM/Dimensional/Geometry/Point)&gt; | Returns the discontinuity points from the defining ICurves of the IElement. | - | Spatial_Engine |
| IInternalElements2D | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElement2D](/documentation/oM/Dimensional/Dimensional/IElement2D)&gt; | Queries the IElement2Ds internal IElement2Ds. Returns a empty list for objects without definied internal elements | - | Spatial_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IIsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any of the curves defining an IElement is closer to itself than the tolerance at any two points (is self intersecting). In case of IElement2D, does not check for intersections between external and internal curves, or between different internal curves. | - | Spatial_Engine |
| INewInternalElement2D | [IElement2D](/documentation/oM/Dimensional/Dimensional/IElement2D) | Creates a IElement2D of a type which can be assigned to the IElement2D. | - | Spatial_Engine |
| InternalElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/documentation/oM/Dimensional/Geometry/ICurve)&gt; | Queries the geometricly defining internal curves, such as Openings, of the IElement2Ds surface. | - | Spatial_Engine |
| InternalOutlineCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[PolyCurve](/documentation/oM/Dimensional/Geometry/PolyCurve)&gt; | Queries the IElement2Ds internal IElement2Ds outline curves. | - | Spatial_Engine |
| IOutlineElements1D | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElement1D](/documentation/oM/Dimensional/Dimensional/IElement1D)&gt; | Returns every IElement1D which makes up the exterior perimeter of the IElement2D. | - | Spatial_Engine |
| IPrimaryPropertyName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns the name of an elements primary defining construction property | - | Facade_Engine |
| IsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any of the element curves of the IElement2D is closer to itself than the tolerance at any two points. Does not check for intersections between external and internal curves, or between different internal curves. | - | Spatial_Engine |
| Normal | [Vector](/documentation/oM/Dimensional/Geometry/Vector) | Returns the normal to the IElement2D which is perpendicular to its plane and oriented according to the right hand rule in relation to the outline curve. | - | Spatial_Engine |
| OutlineCurve | [PolyCurve](/documentation/oM/Dimensional/Geometry/PolyCurve) | Returns a single polycurve outline created from the external elements. | - | Spatial_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IElement2D.cs](https://github.com/BHoM/BHoM/blob/develop/Dimensional_oM/IElement2D.cs)

All history and changes of the class can be found by inspection the history.
