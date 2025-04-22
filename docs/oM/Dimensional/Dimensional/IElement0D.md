---
title: IElement0D
---

# Dimensional.IElement0D

Enables geometrical operations to be performed on a Point based spatial element, whilst preserving all other object properties as unchanged. /nObjects implementing this interface will be required to implement some base methods for getting and setting data in a way that maintains the object's other properties.

[Documentation link](https://bhom.xyz/documentation/BHoM_oM/Dimensional_oM/IElement-required-extension-methods/)

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IElement0D in inheriting from the following base type(s) and implements the following interfaces:"

    -  Dimensional.[IElement](/api_documentation/oM/Dimensional/Dimensional/IElement)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Analytical.Elements.[INode](/api_documentation/oM/Analytical/Analytical/Elements/INode)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Architecture.BuildersWork.[Opening](/api_documentation/oM/Analytical/Architecture/BuildersWork/Opening)
    - Environment.Analysis.[Node](/api_documentation/oM/Analytical/Environment/Analysis/Node)
    - Geometry.[Point](/api_documentation/oM/Dimensional/Geometry/Point)
    - Graphics.[RenderPoint](/api_documentation/oM/Graphics/Graphics/RenderPoint)
    - Lighting.Elements.[Luminaire](/api_documentation/oM/Analytical/Lighting/Elements/Luminaire)
    - Lighting.Analysis.[Node](/api_documentation/oM/Analytical/Lighting/Analysis/Node)
    - MEP.System.[Node](/api_documentation/oM/Analytical/MEP/System/Node)
    - MEP.System.Fittings.[Fitting](/api_documentation/oM/Analytical/MEP/System/Fittings/Fitting)
    - MEP.System.Dampers.[Damper](/api_documentation/oM/Analytical/MEP/System/Dampers/Damper)
    - MEP.System.Dampers.[VolumeDamper](/api_documentation/oM/Analytical/MEP/System/Dampers/VolumeDamper)
    - MEP.System.Dampers.[Valve](/api_documentation/oM/Analytical/MEP/System/Dampers/Valve)
    - MEP.Fixtures.[AirTerminal](/api_documentation/oM/Analytical/MEP/Fixtures/AirTerminal)
    - MEP.Fixtures.[ElectricalFixture](/api_documentation/oM/Analytical/MEP/Fixtures/ElectricalFixture)
    - MEP.Fixtures.[FireAlarmDevice](/api_documentation/oM/Analytical/MEP/Fixtures/FireAlarmDevice)
    - MEP.Fixtures.[LightFixture](/api_documentation/oM/Analytical/MEP/Fixtures/LightFixture)
    - MEP.Fixtures.[PlumbingFixture](/api_documentation/oM/Analytical/MEP/Fixtures/PlumbingFixture)
    - MEP.Equipment.[ElectricalEquipment](/api_documentation/oM/Analytical/MEP/Equipment/ElectricalEquipment)
    - MEP.Equipment.[MechanicalEquipment](/api_documentation/oM/Analytical/MEP/Equipment/MechanicalEquipment)
    - Security.Elements.[CameraDevice](/api_documentation/oM/Analytical/Security/Elements/CameraDevice)
    - Structure.Elements.[Node](/api_documentation/oM/Analytical/Structure/Elements/Node)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Bounds | [BoundingBox](/api_documentation/oM/Dimensional/Geometry/BoundingBox) | Queries the IElement0Ds BoundingBox. Acts on the Point definition of the IElement0D through the Geometry_Engine. | - | Spatial_Engine |
| Centroid | [Point](/api_documentation/oM/Dimensional/Geometry/Point) | Queries the centre of weight for the homogeneous geometrical representation of an IElement0D. Always returns the point location due to zero-dimensionality of an IElement0D. | - | Spatial_Engine |
| ControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api_documentation/oM/Dimensional/Geometry/Point)&gt; | Queries the control points of the geometrical representation of an IElement0D. Always returns the point location due to zero-dimensionality of an IElement0D. | - | Spatial_Engine |
| ElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api_documentation/oM/Dimensional/Geometry/ICurve)&gt; | Queries the defining curves of an IElement0D. Always returns empty collection due to zero-dimensionality of an IElement0D. | - | Spatial_Engine |
| ElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api_documentation/oM/Dimensional/Geometry/Point)&gt; | Returns the point from the IElement0D. Mainly to accomodate the interface method. | - | Spatial_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the area of the geometrical representation of an IElement. | [Area](/api_documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| IBounds | [BoundingBox](/api_documentation/oM/Dimensional/Geometry/BoundingBox) | Queries the IElements BoundingBox. Acts on the elements geometrical definition of the IElement through the Geometry_Engine. | - | Spatial_Engine |
| ICentroid | [Point](/api_documentation/oM/Dimensional/Geometry/Point) | Queries the centre of weight for the homogeneous geometrical representation of an IElement. | - | Spatial_Engine |
| IControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api_documentation/oM/Dimensional/Geometry/Point)&gt; | Queries the control points of the geometrical representation of an IElement. | - | Spatial_Engine |
| IElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api_documentation/oM/Dimensional/Geometry/ICurve)&gt; | Queries the geometricly defining curves of the IElements geometry. | - | Spatial_Engine |
| IElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api_documentation/oM/Dimensional/Geometry/Point)&gt; | Returns the discontinuity points from the defining ICurves of the IElement. | - | Spatial_Engine |
| IGeometry | [Point](/api_documentation/oM/Dimensional/Geometry/Point) | Queries the defining geometrical object which all spatial operations will act on. | - | Spatial_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IIsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any of the curves defining an IElement is closer to itself than the tolerance at any two points (is self intersecting). In case of IElement2D, does not check for intersections between external and internal curves, or between different internal curves. | - | Spatial_Engine |
| IsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the one dimensional representation of the IElement0D is closer to itself than the tolerance at any two points. Always false because a zero-dimensional IElement0D does not consist of curves. | - | Spatial_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IElement0D.cs](https://github.com/BHoM/BHoM/blob/develop/Dimensional_oM/IElement0D.cs)

All history and changes of the class can be found by inspection the history.
