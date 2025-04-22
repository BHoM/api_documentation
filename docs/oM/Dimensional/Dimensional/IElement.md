---
title: IElement
---

# Dimensional.IElement

The common base interface for all the Spatial Dimensional Objects.This interface should not be implemented directly, only through its sub-interfaces.Methods operating on IElement assume a specific implementation of one or other of the sub-interfaces (i.e. IElement0D, IElement1D, IElement2D)

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IElement in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Analytical.Elements.[IEdge](/api_documentation/oM/Analytical/Analytical/Elements/IEdge)
    - Analytical.Elements.[ILink](/api_documentation/oM/Analytical/Analytical/Elements/ILink%601)&lt;[TNode](/api_documentation/oM/Analytical/Analytical/Elements/ILink%601#tnode)&gt;
    - Analytical.Elements.[INode](/api_documentation/oM/Analytical/Analytical/Elements/INode)
    - Analytical.Elements.[IOpening](/api_documentation/oM/Analytical/Analytical/Elements/IOpening%601)&lt;[TEdge](/api_documentation/oM/Analytical/Analytical/Elements/IOpening%601#tedge)&gt;
    - Analytical.Elements.[IPanel](/api_documentation/oM/Analytical/Analytical/Elements/IPanel%602)&lt;[TEdge](/api_documentation/oM/Analytical/Analytical/Elements/IPanel%602#tedge), [TOpening](/api_documentation/oM/Analytical/Analytical/Elements/IPanel%602#topening)&gt;
    - Analytical.Elements.[IRegion](/api_documentation/oM/Analytical/Analytical/Elements/IRegion)
    - Dimensional.[IElement0D](/api_documentation/oM/Dimensional/Dimensional/IElement0D)
    - Dimensional.[IElement1D](/api_documentation/oM/Dimensional/Dimensional/IElement1D)
    - Dimensional.[IElement2D](/api_documentation/oM/Dimensional/Dimensional/IElement2D)
    - Dimensional.[IElement3D](/api_documentation/oM/Dimensional/Dimensional/IElement3D)
    - Geometry.[IBoundary](/api_documentation/oM/Dimensional/Geometry/IBoundary)
    - Geometry.[ICurve](/api_documentation/oM/Dimensional/Geometry/ICurve)
    - Geometry.[IPolyCurve](/api_documentation/oM/Dimensional/Geometry/IPolyCurve)
    - Geometry.[IPolyline](/api_documentation/oM/Dimensional/Geometry/IPolyline)
    - MEP.System.[IFlow](/api_documentation/oM/Analytical/MEP/System/IFlow)
    - Physical.Elements.[IFramingElement](/api_documentation/oM/Physical/Physical/Elements/IFramingElement)
    - Physical.Elements.[IOpening](/api_documentation/oM/Physical/Physical/Elements/IOpening)
    - Physical.Elements.[ISurface](/api_documentation/oM/Physical/Physical/Elements/ISurface)


### Classes implementing this interface

??? bhom "The following classes are implementing this interface:"

    - Architecture.Elements.[Ceiling](/api_documentation/oM/Analytical/Architecture/Elements/Ceiling)
    - Architecture.Elements.[CeilingTile](/api_documentation/oM/Analytical/Architecture/Elements/CeilingTile)
    - Architecture.Elements.[Room](/api_documentation/oM/Analytical/Architecture/Elements/Room)
    - Architecture.BuildersWork.[Opening](/api_documentation/oM/Analytical/Architecture/BuildersWork/Opening)
    - Environment.Elements.[Edge](/api_documentation/oM/Analytical/Environment/Elements/Edge)
    - Environment.Elements.[Opening](/api_documentation/oM/Analytical/Environment/Elements/Opening)
    - Environment.Elements.[Panel](/api_documentation/oM/Analytical/Environment/Elements/Panel)
    - Environment.Elements.[Space](/api_documentation/oM/Analytical/Environment/Elements/Space)
    - Environment.Elements.[Zone](/api_documentation/oM/Analytical/Environment/Elements/Zone)
    - Environment.Analysis.[Node](/api_documentation/oM/Analytical/Environment/Analysis/Node)
    - Facade.Elements.[CurtainWall](/api_documentation/oM/Analytical/Facade/Elements/CurtainWall)
    - Facade.Elements.[FrameEdge](/api_documentation/oM/Analytical/Facade/Elements/FrameEdge)
    - Facade.Elements.[Opening](/api_documentation/oM/Analytical/Facade/Elements/Opening)
    - Facade.Elements.[Panel](/api_documentation/oM/Analytical/Facade/Elements/Panel)
    - Geometry.[Arc](/api_documentation/oM/Dimensional/Geometry/Arc)
    - Geometry.[BoundaryCurve](/api_documentation/oM/Dimensional/Geometry/BoundaryCurve)
    - Geometry.[Circle](/api_documentation/oM/Dimensional/Geometry/Circle)
    - Geometry.[Ellipse](/api_documentation/oM/Dimensional/Geometry/Ellipse)
    - Geometry.[Line](/api_documentation/oM/Dimensional/Geometry/Line)
    - Geometry.[NurbsCurve](/api_documentation/oM/Dimensional/Geometry/NurbsCurve)
    - Geometry.[PolyCurve](/api_documentation/oM/Dimensional/Geometry/PolyCurve)
    - Geometry.[Polygon](/api_documentation/oM/Dimensional/Geometry/Polygon)
    - Geometry.[Polyline](/api_documentation/oM/Dimensional/Geometry/Polyline)
    - Geometry.[PlanarSurface](/api_documentation/oM/Dimensional/Geometry/PlanarSurface)
    - Geometry.[Point](/api_documentation/oM/Dimensional/Geometry/Point)
    - Graphics.[RenderPoint](/api_documentation/oM/Graphics/Graphics/RenderPoint)
    - Adapters.GSA.Elements.[Spacer](/api_documentation/oM/Adapter/Adapters/GSA/Elements/Spacer)
    - Lighting.Elements.[Luminaire](/api_documentation/oM/Analytical/Lighting/Elements/Luminaire)
    - Lighting.Analysis.[Node](/api_documentation/oM/Analytical/Lighting/Analysis/Node)
    - MEP.System.[CableTray](/api_documentation/oM/Analytical/MEP/System/CableTray)
    - MEP.System.[Duct](/api_documentation/oM/Analytical/MEP/System/Duct)
    - MEP.System.[FlowSystem](/api_documentation/oM/Analytical/MEP/System/FlowSystem)
    - MEP.System.[Node](/api_documentation/oM/Analytical/MEP/System/Node)
    - MEP.System.[Pipe](/api_documentation/oM/Analytical/MEP/System/Pipe)
    - MEP.System.[WireSegment](/api_documentation/oM/Analytical/MEP/System/WireSegment)
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
    - Physical.Elements.[Beam](/api_documentation/oM/Physical/Physical/Elements/Beam)
    - Physical.Elements.[Bracing](/api_documentation/oM/Physical/Physical/Elements/Bracing)
    - Physical.Elements.[Cable](/api_documentation/oM/Physical/Physical/Elements/Cable)
    - Physical.Elements.[Column](/api_documentation/oM/Physical/Physical/Elements/Column)
    - Physical.Elements.[Door](/api_documentation/oM/Physical/Physical/Elements/Door)
    - Physical.Elements.[Floor](/api_documentation/oM/Physical/Physical/Elements/Floor)
    - Physical.Elements.[MeshElement](/api_documentation/oM/Physical/Physical/Elements/MeshElement)
    - Physical.Elements.[PadFoundation](/api_documentation/oM/Physical/Physical/Elements/PadFoundation)
    - Physical.Elements.[Pile](/api_documentation/oM/Physical/Physical/Elements/Pile)
    - Physical.Elements.[Roof](/api_documentation/oM/Physical/Physical/Elements/Roof)
    - Physical.Elements.[Void](/api_documentation/oM/Physical/Physical/Elements/Void)
    - Physical.Elements.[Wall](/api_documentation/oM/Physical/Physical/Elements/Wall)
    - Physical.Elements.[Window](/api_documentation/oM/Physical/Physical/Elements/Window)
    - Security.Elements.[CameraDevice](/api_documentation/oM/Analytical/Security/Elements/CameraDevice)
    - Spatial.SettingOut.[Grid](/api_documentation/oM/Dimensional/Spatial/SettingOut/Grid)
    - Structure.Reinforcement.[ReinforcementRegion](/api_documentation/oM/Analytical/Structure/Reinforcement/ReinforcementRegion)
    - Structure.Elements.[Bar](/api_documentation/oM/Analytical/Structure/Elements/Bar)
    - Structure.Elements.[Edge](/api_documentation/oM/Analytical/Structure/Elements/Edge)
    - Structure.Elements.[Node](/api_documentation/oM/Analytical/Structure/Elements/Node)
    - Structure.Elements.[Opening](/api_documentation/oM/Analytical/Structure/Elements/Opening)
    - Structure.Elements.[PadFoundation](/api_documentation/oM/Analytical/Structure/Elements/PadFoundation)
    - Structure.Elements.[Panel](/api_documentation/oM/Analytical/Structure/Elements/Panel)
    - Structure.Elements.[Pile](/api_documentation/oM/Analytical/Structure/Elements/Pile)
    - Structure.Elements.[Stem](/api_documentation/oM/Analytical/Structure/Elements/Stem)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the area of the geometrical representation of an IElement. | [Area](/api_documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| IBounds | [BoundingBox](/api_documentation/oM/Dimensional/Geometry/BoundingBox) | Queries the IElements BoundingBox. Acts on the elements geometrical definition of the IElement through the Geometry_Engine. | - | Spatial_Engine |
| ICentroid | [Point](/api_documentation/oM/Dimensional/Geometry/Point) | Queries the centre of weight for the homogeneous geometrical representation of an IElement. | - | Spatial_Engine |
| IControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api_documentation/oM/Dimensional/Geometry/Point)&gt; | Queries the control points of the geometrical representation of an IElement. | - | Spatial_Engine |
| IElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api_documentation/oM/Dimensional/Geometry/ICurve)&gt; | Queries the geometricly defining curves of the IElements geometry. | - | Spatial_Engine |
| IElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api_documentation/oM/Dimensional/Geometry/Point)&gt; | Returns the discontinuity points from the defining ICurves of the IElement. | - | Spatial_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IIsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any of the curves defining an IElement is closer to itself than the tolerance at any two points (is self intersecting). In case of IElement2D, does not check for intersections between external and internal curves, or between different internal curves. | - | Spatial_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IElement.cs](https://github.com/BHoM/BHoM/blob/develop/Dimensional_oM/IElement.cs)

All history and changes of the class can be found by inspection the history.
