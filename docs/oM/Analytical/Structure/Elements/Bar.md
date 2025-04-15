---
title: Bar
---

# Structure.Elements.Bar

1D finite element for structural analysis. Linear 2-noded element defined by a start and end node.For structural conventions and orientation of the bar please see the [documentation](https://bhom.xyz/documentation/BHoM_oM/Structure_oM/BHoM-Structural-Conventions/).

## Class structure

### Implemented interfaces and base types

???+ bhom "The Bar in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)
    -  Dimensional.[IElement1D](/documentation/oM/Dimensional/Dimensional/IElement1D)
    -  Dimensional.[IElement](/documentation/oM/Dimensional/Dimensional/IElement)
    -  Dimensional.[IElementM](/documentation/oM/Dimensional/Dimensional/IElementM)
    -  Analytical.Elements.[ILink](/documentation/oM/Analytical/Analytical/Elements/ILink%601)&lt;Structure.Elements.[Node](/documentation/oM/Analytical/Structure/Elements/Node)&gt;
    -  Analytical.[IAnalytical](/documentation/oM/Analytical/Analytical/IAnalytical)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Start | [Node](/documentation/oM/Analytical/Structure/Elements/Node) | Defines the start position of the element. Note that Nodes can contain Supports which should not be confused with Releases. | - |
| End | [Node](/documentation/oM/Analytical/Structure/Elements/Node) | Defines the end position of the element. Note that Nodes can contain Supports which should not be confused with Releases. | - |
| SectionProperty | [ISectionProperty](/documentation/oM/Analytical/Structure/SectionProperties/ISectionProperty) | Section property of the bar, containing all sectional constants and material as well as profile geometry and dimensions, where applicable. | - |
| OrientationAngle | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Controls the local axis orientation of the bar <br>For non-vertical members the local z is aligned with the global Z and rotated with the orientation angle about the local x. <br>For vertical members the local y is aligned with the global Y and rotated with the orientation angle about the local x. <br>A bar is vertical if its projected length to the horizontal plane is less than 0.0001, i.e. a tolerance of 0.1mm on verticality. <br>For general structural conventions please see the [documentation](https://bhom.xyz/documentation/BHoM_oM/Structure_oM/BHoM-Structural-Conventions/). | [Angle](/documentation/oM/Dimensional/Quantities/Attributes/Angle) [rad] |
| Release | [BarRelease](/documentation/oM/Analytical/Structure/Constraints/BarRelease) | Defines the start and end release of the Bar. The releases defines how the bar is attached to its end nodes. If not set, full fixity will be assumed. | - |
| FEAType | [BarFEAType](/documentation/oM/Analytical/Structure/Elements/BarFEAType) | - | - |
| Support | [Constraint4DOF](/documentation/oM/Analytical/Structure/Constraints/Constraint4DOF) | Linear support for the bar. Three translational degrees of freedom and one rotational. The rotational DOF defines constraint about the axis of the bar. | - |
| Offset | [Offset](/documentation/oM/Analytical/Structure/Offsets/Offset) | Offset of the bar as two vectors, one per end node, in bar local coordinates. Defines offsets from centreline to be applied in analysis packages. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| AutoLengthOffset | [AutoLengthOffset](/documentation/oM/Adapter/Adapters/ETABS/Elements/AutoLengthOffset) | - | - | ETABS_Engine |
| BarAutoMesh | [BarAutoMesh](/documentation/oM/Adapter/Adapters/SAP2000/Elements/BarAutoMesh) | Returns the SAP2000 BarAutoMesh settings for a bar. You can also use the method FindFragment() with the type BarAutoMesh as an argument. | - | SAP2000_Engine |
| BarDesignProcedure | [BarDesignProcedure](/documentation/oM/Adapter/Adapters/SAP2000/Elements/BarDesignProcedure) | Returns the SAP2000 BarDesignProcedure settings for a bar. You can also use the method FindFragment() with the type BarDesignProcedure as an argument. | - | SAP2000_Engine |
| BarInsertionPoint | [BarInsertionPointLocation](/documentation/oM/Adapter/Adapters/SAP2000/BarInsertionPointLocation) | Returns the SAP2000 BarInsertionPointLocation settings for a bar. You can also use the method FindFragment() with the type BarInsertionPoint as an argument. | - | SAP2000_Engine |
| BarModifyStiffnessInsertionPoint | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if SAP2000 is set to modify the stiffness of a bar based on its insertion point. You can also use the method FindFragment() with the type BarInsertionPoint as an argument, and check the ModifyStiffness property of that fragment. | - | SAP2000_Engine |
| BarSectionTranformation | [TransformMatrix](/documentation/oM/Dimensional/Geometry/TransformMatrix) | Constructs the transformation matrix needed to move the section curves of the Bar from the default drawing position around the global origin to the start of the Bar and aligned with its tangent. | - | Structure_Engine |
| Bounds | [BoundingBox](/documentation/oM/Dimensional/Geometry/BoundingBox) | Queries the IElement1Ds BoundingBox. Acts on the ICurve definition of the IElement1D through the Geometry_Engine. | - | Spatial_Engine |
| CellularOpeningCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/documentation/oM/Dimensional/Geometry/ICurve)&gt; | Distributes a series of cellular openings along the centreline of the bar centreline. Method will fit in as many openings along the curve as it can, starting from the start of the curve.<br>An empty list is returned if the bar does not contain a cellular section. | - | Structure_Engine |
| Centreline | [Line](/documentation/oM/Dimensional/Geometry/Line) | Returns the centreline of the Bar as the line between the StratNode and EndNode. No offsets or similar is accounted for. | - | Structure_Engine |
| Centroid | [Point](/documentation/oM/Dimensional/Geometry/Point) | Queries the centre of weight for a IElement1Ds ICurve representation. | - | Spatial_Engine |
| CheckFlipBar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Evaluates if the Bar would have its endpoints flipped on Push to ETABS in ETABS16. | - | ETABS_Engine |
| ControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/documentation/oM/Dimensional/Geometry/Point)&gt; | Queries the control points of the one dimensional representation of the IElement1D. | - | Spatial_Engine |
| CoordinateSystem | [Cartesian](/documentation/oM/Dimensional/Geometry/CoordinateSystem/Cartesian) | Get the carteseian coordinate system descibring the position and local orientation of the Bar in the global coordinate system where the Bar tangent is the local x-axis and the normal is the local z-axis. | - | Structure_Engine |
| DominantVector | [Vector](/documentation/oM/Dimensional/Geometry/Vector) | Gets the the dominant vector (orientation) of an Element1D based on its lines lengths. | - | Spatial_Engine |
| ElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/documentation/oM/Dimensional/Geometry/ICurve)&gt; | Queries the defining curves of an IElement1D. | - | Spatial_Engine |
| ElementEmbodiedCarbon | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElementResult](/documentation/oM/Analytical/LifeCycleAssessment/Results/IElementResult%601)&lt;[MaterialResult](/documentation/oM/Analytical/LifeCycleAssessment/Results/MaterialResult)&gt;&gt; | Evaluates the embodied carbon on the provided element based on IStructE methodology of evaluation.<br>If you would like to evaluate other EPD metrics, please use one of the Query.EnvironmentalResults methods. <br>TemplateMaterials can be provided helping with picking the correct EPD corresponding to each material on the element. Please note that this evaluation method only support mass-based EPDs. | - | LifeCycleAssessment_Engine |
| ElementEnvironmentalMetrics | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[EnvironmentalMetric](/documentation/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetric)&gt;&gt; | Query the Environmental Product Declarations from any IElementM with a MaterialComposition composed of IEPD materials. | - | LifeCycleAssessment_Engine |
| ElementEpds | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[EnvironmentalProductDeclaration](/documentation/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalProductDeclaration)&gt; | Query the Environmental Product Declarations from any IElementM with a MaterialComposition composed of IEPD materials. | - | LifeCycleAssessment_Engine |
| ElementMaterialNames | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Query the element's MaterialComposition to form a Material Hint to aid in EPD-Material Mapping. | - | LifeCycleAssessment_Engine |
| ElementScope | [ScopeType](/documentation/oM/Analytical/LifeCycleAssessment/ScopeType) | Returns the enumerable type of the scope found on an element. | - | LifeCycleAssessment_Engine |
| ElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/documentation/oM/Dimensional/Geometry/Point)&gt; | Returns the discontinuity points from the defining ICurve of the IElement1D. | - | Spatial_Engine |
| EnvironmentalResults | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElementResult](/documentation/oM/Analytical/LifeCycleAssessment/Results/IElementResult%601)&lt;[MaterialResult](/documentation/oM/Analytical/LifeCycleAssessment/Results/MaterialResult)&gt;&gt; | Evaluates the EnvironmentalMetrics for the provided element and returns an ElementResult for each evaluated metric type.<br>Evaluation is done by extracting the material takeoff for the provided element, giving quantities and Materiality.<br>Each Material in the takeoff is then evaluated by finding the EnvironmentalProductDeclaration (EPD), either stored on the material or from the list of template materials.<br>Each metric, or filtered chosen metrics, on the EPD is then evaluated.<br>Finally, an element result is returned per metric type. Each element result being the sum result of all metrics of the same type. | - | LifeCycleAssessment_Engine |
| Extrude | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IGeometry](/documentation/oM/Dimensional/Geometry/IGeometry)&gt; | Computes an extrusion of the section along the Bar centreline. | - | Structure_Engine |
| Geometry3D | [IGeometry](/documentation/oM/Dimensional/Geometry/IGeometry) | Gets the BH.oM.Geometry.Extrusion out of the Bar as its Geometry3D. | - | Structure_Engine |
| HasReinforcement | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Returns true if the Bar has a ConcreteSection with BarRebarIntent defined with at least one IBarReinforcement in it. False if the Bar, ConcreteSection or BarRebarIntent is null or the IBarReinforcement count is zero. | - | Structure_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the area of the geometrical representation of an IElement. | [Area](/documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| IBounds | [BoundingBox](/documentation/oM/Dimensional/Geometry/BoundingBox) | Queries the IElements BoundingBox. Acts on the elements geometrical definition of the IElement through the Geometry_Engine. | - | Spatial_Engine |
| ICentroid | [Point](/documentation/oM/Dimensional/Geometry/Point) | Queries the centre of weight for the homogeneous geometrical representation of an IElement. | - | Spatial_Engine |
| IControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/documentation/oM/Dimensional/Geometry/Point)&gt; | Queries the control points of the geometrical representation of an IElement. | - | Spatial_Engine |
| IElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/documentation/oM/Dimensional/Geometry/ICurve)&gt; | Queries the geometricly defining curves of the IElements geometry. | - | Spatial_Engine |
| IElements0D | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElement0D](/documentation/oM/Dimensional/Dimensional/IElement0D)&gt; | Queries the IElement0Ds from a IElement1D. Returns null if no IElement0Ds are defined for the type of IElement1D. | - | Spatial_Engine |
| IElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/documentation/oM/Dimensional/Geometry/Point)&gt; | Returns the discontinuity points from the defining ICurves of the IElement. | - | Spatial_Engine |
| IGeneralMaterialTakeoff | [GeneralMaterialTakeoff](/documentation/oM/Physical/Physical/Materials/GeneralMaterialTakeoff) | Gets the unique Materials along with their volumes defining an object's make-up. | - | Matter_Engine |
| IGeometry | [ICurve](/documentation/oM/Dimensional/Geometry/ICurve) | Queries the defining geometrical object which all spatial operations will act on. | - | Spatial_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IIsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any of the curves defining an IElement is closer to itself than the tolerance at any two points (is self intersecting). In case of IElement2D, does not check for intersections between external and internal curves, or between different internal curves. | - | Spatial_Engine |
| IMaterialComposition | [MaterialComposition](/documentation/oM/Physical/Physical/Materials/MaterialComposition) | Gets the unique Materials along with their relative proportions defining an object's make-up. | - | Matter_Engine |
| InsertionPoint | [BarInsertionPoint](/documentation/oM/Adapter/Adapters/ETABS/BarInsertionPoint) | - | - | ETABS_Engine |
| IPrimaryPropertyName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns the name of an elements primary defining property | - | Facade_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Bar or its defining properties are null and outputs relevant error message. | - | Structure_Engine |
| ISolidVolume | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns an element's solid volume, i.e. the the volume of the element that had any materiality, excluding cavities, openings and voids. | [Volume](/documentation/oM/Dimensional/Quantities/Attributes/Volume) [m³] | Matter_Engine |
| IsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if the one dimensional representation of the IElement1D is closer to itself than the tolerance at any two points. | - | Spatial_Engine |
| IsVertical | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Bar is vertical. A Bar is vertical if its projected length to the horizontal plane is less than 0.0001, i.e. a tolerance of 0.1mm on verticality. <br>For general structural conventions please see the [documentation](https://bhom.xyz/documentation/BHoM_oM/Structure_oM/BHoM-Structural-Conventions/). | - | Structure_Engine |
| IVolumetricMaterialTakeoff | [VolumetricMaterialTakeoff](/documentation/oM/Physical/Physical/Materials/VolumetricMaterialTakeoff) | Gets the unique Materials along with their volumes defining an object's make-up. | - | Matter_Engine |
| Length | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the length of the IElement1Ds curve. | [Length](/documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Spatial_Engine |
| Mass | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the mass of a Bar as its solid volume (generally taken as length times section area) times density(ies) of its material. No offsets or similar are taken into account. | [Mass](/documentation/oM/Dimensional/Quantities/Attributes/Mass) [kg] | Structure_Engine |
| Mass | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Evaluates the mass of an object based its VolumetricMaterialTakeoff and Density. | [Mass](/documentation/oM/Dimensional/Quantities/Attributes/Mass) [kg] | Matter_Engine |
| MaterialComposition | [MaterialComposition](/documentation/oM/Physical/Physical/Materials/MaterialComposition) | Returns a Bar's homogeneous MaterialComposition. | - | Structure_Engine |
| ModifyStiffnessInsertionPoint | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - | ETABS_Engine |
| Normal | [Vector](/documentation/oM/Dimensional/Geometry/Vector) | Returns the bars local z-axis, generally the major axis direction of the section of the Bar. <br>For non - vertical members the local z-axis is aligned with the global Z-axis and rotated with the orientation angle around the local x-axis. <br>For vertical members the local y-axis is aligned with the global Y-axis and rotated with the orientation angle around the local x-axis. For this case the normal will be the vector orthogonal to the local x-axis and local y-axis. | - | Structure_Engine |
| QuantityTypes | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[QuantityType](/documentation/oM/Analytical/LifeCycleAssessment/QuantityType)&gt; | Query the QuantityType values from any IElementM object's MaterialComposition. | - | LifeCycleAssessment_Engine |
| ReinforcementLayout | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/documentation/oM/Dimensional/Geometry/ICurve)&gt; | Gets all the reinforcement centrelines in the Bar as a list of Curves. | - | Structure_Engine |
| ReinforcingBars | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IReinforcingBar](/documentation/oM/Physical/Physical/Reinforcement/IReinforcingBar)&gt; | Extract all physical ReinforcingBars from the structural Bar. Only extracts reinforcement for bars owning a ConcreteSection, for other section types, an empty list will be returned. | - | Structure_Engine |
| SolidVolume | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns a Bar's solid volume based on its SectionProperty area and the CentreLine length. | [Volume](/documentation/oM/Dimensional/Quantities/Attributes/Volume) [m³] | Structure_Engine |
| Tangent | [Vector](/documentation/oM/Dimensional/Geometry/Vector) | Gets the tangent Vector of a Bar as the direction Vector from StartNode to EndNode. No offsets or similar are taken into account. | - | Structure_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Bar.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Elements\Bar.cs)

All history and changes of the class can be found by inspection the history.
