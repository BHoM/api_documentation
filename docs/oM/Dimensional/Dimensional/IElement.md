---
title: IElement
---

# Dimensional.IElement

The common base interface for all the Spatial Dimensional Objects.This interface should not be implemented directly, only through its sub-interfaces.Methods operating on IElement assume a specific implementation of one or other of the sub-interfaces (i.e. IElement0D, IElement1D, IElement2D)

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IElement in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Analytical.Elements.[IEdge](/documentation/oM/Analytical/Analytical/Elements/IEdge)
    - Analytical.Elements.[ILink](/documentation/oM/Analytical/Analytical/Elements/ILink%601)&lt;[TNode](/documentation/oM/Analytical/Analytical/Elements/ILink%601#tnode)&gt;
    - Analytical.Elements.[INode](/documentation/oM/Analytical/Analytical/Elements/INode)
    - Analytical.Elements.[IOpening](/documentation/oM/Analytical/Analytical/Elements/IOpening%601)&lt;[TEdge](/documentation/oM/Analytical/Analytical/Elements/IOpening%601#tedge)&gt;
    - Analytical.Elements.[IPanel](/documentation/oM/Analytical/Analytical/Elements/IPanel%602)&lt;[TEdge](/documentation/oM/Analytical/Analytical/Elements/IPanel%602#tedge), [TOpening](/documentation/oM/Analytical/Analytical/Elements/IPanel%602#topening)&gt;
    - Analytical.Elements.[IRegion](/documentation/oM/Analytical/Analytical/Elements/IRegion)
    - Dimensional.[IElement0D](/documentation/oM/Dimensional/Dimensional/IElement0D)
    - Dimensional.[IElement1D](/documentation/oM/Dimensional/Dimensional/IElement1D)
    - Dimensional.[IElement2D](/documentation/oM/Dimensional/Dimensional/IElement2D)
    - Dimensional.[IElement3D](/documentation/oM/Dimensional/Dimensional/IElement3D)
    - Geometry.[IBoundary](/documentation/oM/Dimensional/Geometry/IBoundary)
    - Geometry.[ICurve](/documentation/oM/Dimensional/Geometry/ICurve)
    - Geometry.[IPolyCurve](/documentation/oM/Dimensional/Geometry/IPolyCurve)
    - Geometry.[IPolyline](/documentation/oM/Dimensional/Geometry/IPolyline)
    - MEP.System.[IFlow](/documentation/oM/Analytical/MEP/System/IFlow)
    - Physical.Elements.[IFramingElement](/documentation/oM/Physical/Physical/Elements/IFramingElement)
    - Physical.Elements.[IOpening](/documentation/oM/Physical/Physical/Elements/IOpening)
    - Physical.Elements.[ISurface](/documentation/oM/Physical/Physical/Elements/ISurface)


### Classes implementing this interface

??? bhom "The following classes are implementing this interface:"

    - Architecture.Elements.[Ceiling](/documentation/oM/Analytical/Architecture/Elements/Ceiling)
    - Architecture.Elements.[CeilingTile](/documentation/oM/Analytical/Architecture/Elements/CeilingTile)
    - Architecture.Elements.[Room](/documentation/oM/Analytical/Architecture/Elements/Room)
    - Architecture.BuildersWork.[Opening](/documentation/oM/Analytical/Architecture/BuildersWork/Opening)
    - Environment.Elements.[Edge](/documentation/oM/Analytical/Environment/Elements/Edge)
    - Environment.Elements.[Opening](/documentation/oM/Analytical/Environment/Elements/Opening)
    - Environment.Elements.[Panel](/documentation/oM/Analytical/Environment/Elements/Panel)
    - Environment.Elements.[Space](/documentation/oM/Analytical/Environment/Elements/Space)
    - Environment.Elements.[Zone](/documentation/oM/Analytical/Environment/Elements/Zone)
    - Environment.Analysis.[Node](/documentation/oM/Analytical/Environment/Analysis/Node)
    - Facade.Elements.[CurtainWall](/documentation/oM/Analytical/Facade/Elements/CurtainWall)
    - Facade.Elements.[FrameEdge](/documentation/oM/Analytical/Facade/Elements/FrameEdge)
    - Facade.Elements.[Opening](/documentation/oM/Analytical/Facade/Elements/Opening)
    - Facade.Elements.[Panel](/documentation/oM/Analytical/Facade/Elements/Panel)
    - Geometry.[Arc](/documentation/oM/Dimensional/Geometry/Arc)
    - Geometry.[BoundaryCurve](/documentation/oM/Dimensional/Geometry/BoundaryCurve)
    - Geometry.[Circle](/documentation/oM/Dimensional/Geometry/Circle)
    - Geometry.[Ellipse](/documentation/oM/Dimensional/Geometry/Ellipse)
    - Geometry.[Line](/documentation/oM/Dimensional/Geometry/Line)
    - Geometry.[NurbsCurve](/documentation/oM/Dimensional/Geometry/NurbsCurve)
    - Geometry.[PolyCurve](/documentation/oM/Dimensional/Geometry/PolyCurve)
    - Geometry.[Polygon](/documentation/oM/Dimensional/Geometry/Polygon)
    - Geometry.[Polyline](/documentation/oM/Dimensional/Geometry/Polyline)
    - Geometry.[PlanarSurface](/documentation/oM/Dimensional/Geometry/PlanarSurface)
    - Geometry.[Point](/documentation/oM/Dimensional/Geometry/Point)
    - Graphics.[RenderPoint](/documentation/oM/Graphics/Graphics/RenderPoint)
    - Adapters.GSA.Elements.[Spacer](/documentation/oM/Adapter/Adapters/GSA/Elements/Spacer)
    - Lighting.Elements.[Luminaire](/documentation/oM/Analytical/Lighting/Elements/Luminaire)
    - Lighting.Analysis.[Node](/documentation/oM/Analytical/Lighting/Analysis/Node)
    - MEP.System.[CableTray](/documentation/oM/Analytical/MEP/System/CableTray)
    - MEP.System.[Duct](/documentation/oM/Analytical/MEP/System/Duct)
    - MEP.System.[FlowSystem](/documentation/oM/Analytical/MEP/System/FlowSystem)
    - MEP.System.[Node](/documentation/oM/Analytical/MEP/System/Node)
    - MEP.System.[Pipe](/documentation/oM/Analytical/MEP/System/Pipe)
    - MEP.System.[WireSegment](/documentation/oM/Analytical/MEP/System/WireSegment)
    - MEP.System.Fittings.[Fitting](/documentation/oM/Analytical/MEP/System/Fittings/Fitting)
    - MEP.System.Dampers.[Damper](/documentation/oM/Analytical/MEP/System/Dampers/Damper)
    - MEP.System.Dampers.[VolumeDamper](/documentation/oM/Analytical/MEP/System/Dampers/VolumeDamper)
    - MEP.System.Dampers.[Valve](/documentation/oM/Analytical/MEP/System/Dampers/Valve)
    - MEP.Fixtures.[AirTerminal](/documentation/oM/Analytical/MEP/Fixtures/AirTerminal)
    - MEP.Fixtures.[ElectricalFixture](/documentation/oM/Analytical/MEP/Fixtures/ElectricalFixture)
    - MEP.Fixtures.[FireAlarmDevice](/documentation/oM/Analytical/MEP/Fixtures/FireAlarmDevice)
    - MEP.Fixtures.[LightFixture](/documentation/oM/Analytical/MEP/Fixtures/LightFixture)
    - MEP.Fixtures.[PlumbingFixture](/documentation/oM/Analytical/MEP/Fixtures/PlumbingFixture)
    - MEP.Equipment.[ElectricalEquipment](/documentation/oM/Analytical/MEP/Equipment/ElectricalEquipment)
    - MEP.Equipment.[MechanicalEquipment](/documentation/oM/Analytical/MEP/Equipment/MechanicalEquipment)
    - Physical.Elements.[Beam](/documentation/oM/Physical/Physical/Elements/Beam)
    - Physical.Elements.[Bracing](/documentation/oM/Physical/Physical/Elements/Bracing)
    - Physical.Elements.[Cable](/documentation/oM/Physical/Physical/Elements/Cable)
    - Physical.Elements.[Column](/documentation/oM/Physical/Physical/Elements/Column)
    - Physical.Elements.[Door](/documentation/oM/Physical/Physical/Elements/Door)
    - Physical.Elements.[Floor](/documentation/oM/Physical/Physical/Elements/Floor)
    - Physical.Elements.[MeshElement](/documentation/oM/Physical/Physical/Elements/MeshElement)
    - Physical.Elements.[PadFoundation](/documentation/oM/Physical/Physical/Elements/PadFoundation)
    - Physical.Elements.[Pile](/documentation/oM/Physical/Physical/Elements/Pile)
    - Physical.Elements.[Roof](/documentation/oM/Physical/Physical/Elements/Roof)
    - Physical.Elements.[Void](/documentation/oM/Physical/Physical/Elements/Void)
    - Physical.Elements.[Wall](/documentation/oM/Physical/Physical/Elements/Wall)
    - Physical.Elements.[Window](/documentation/oM/Physical/Physical/Elements/Window)
    - Security.Elements.[CameraDevice](/documentation/oM/Analytical/Security/Elements/CameraDevice)
    - Spatial.SettingOut.[Grid](/documentation/oM/Dimensional/Spatial/SettingOut/Grid)
    - Structure.Reinforcement.[ReinforcementRegion](/documentation/oM/Analytical/Structure/Reinforcement/ReinforcementRegion)
    - Structure.Elements.[Bar](/documentation/oM/Analytical/Structure/Elements/Bar)
    - Structure.Elements.[Edge](/documentation/oM/Analytical/Structure/Elements/Edge)
    - Structure.Elements.[Node](/documentation/oM/Analytical/Structure/Elements/Node)
    - Structure.Elements.[Opening](/documentation/oM/Analytical/Structure/Elements/Opening)
    - Structure.Elements.[PadFoundation](/documentation/oM/Analytical/Structure/Elements/PadFoundation)
    - Structure.Elements.[Panel](/documentation/oM/Analytical/Structure/Elements/Panel)
    - Structure.Elements.[Pile](/documentation/oM/Analytical/Structure/Elements/Pile)
    - Structure.Elements.[Stem](/documentation/oM/Analytical/Structure/Elements/Stem)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the area of the geometrical representation of an IElement. | [Area](/documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| IBounds | [BoundingBox](/documentation/oM/Dimensional/Geometry/BoundingBox) | Queries the IElements BoundingBox. Acts on the elements geometrical definition of the IElement through the Geometry_Engine. | - | Spatial_Engine |
| ICentroid | [Point](/documentation/oM/Dimensional/Geometry/Point) | Queries the centre of weight for the homogeneous geometrical representation of an IElement. | - | Spatial_Engine |
| IControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/documentation/oM/Dimensional/Geometry/Point)&gt; | Queries the control points of the geometrical representation of an IElement. | - | Spatial_Engine |
| IElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/documentation/oM/Dimensional/Geometry/ICurve)&gt; | Queries the geometricly defining curves of the IElements geometry. | - | Spatial_Engine |
| IElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/documentation/oM/Dimensional/Geometry/Point)&gt; | Returns the discontinuity points from the defining ICurves of the IElement. | - | Spatial_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IIsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any of the curves defining an IElement is closer to itself than the tolerance at any two points (is self intersecting). In case of IElement2D, does not check for intersections between external and internal curves, or between different internal curves. | - | Spatial_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IElement.cs](https://github.com/BHoM/BHoM/blob/develop/Dimensional_oM/IElement.cs)

All history and changes of the class can be found by inspection the history.
