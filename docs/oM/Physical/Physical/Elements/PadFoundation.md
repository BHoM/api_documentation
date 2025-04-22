---
title: PadFoundation
---

# Physical.Elements.PadFoundation

Physical representation of a flat pad foundation (parallel top and bottom faces).

## Class structure

### Implemented interfaces and base types

???+ bhom "The PadFoundation in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Physical.[IPhysical](/api_documentation/oM/Physical/Physical/IPhysical)
    -  Dimensional.[IElement2D](/api_documentation/oM/Dimensional/Dimensional/IElement2D)
    -  Dimensional.[IElement](/api_documentation/oM/Dimensional/Dimensional/IElement)
    -  Dimensional.[IElementM](/api_documentation/oM/Dimensional/Dimensional/IElementM)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Location | [PlanarSurface](/api_documentation/oM/Dimensional/Geometry/PlanarSurface) | PlanarSurface defining the top face of a pad foundation. | - |
| Construction | [IConstruction](/api_documentation/oM/Physical/Physical/Constructions/IConstruction) | Construction of the pad foundation defining its thickness and Material. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Area | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the IElement2Ds area defined as the area confined by the outline curves subtracting the area of the internal elements. | [Area](/api_documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| Bounds | [BoundingBox](/api_documentation/oM/Dimensional/Geometry/BoundingBox) | Queries the IElement2Ds BoundingBox. Acts on the element curve definition of the IElement2D through the Geometry_Engine. | - | Spatial_Engine |
| Centroid | [Point](/api_documentation/oM/Dimensional/Geometry/Point) | Queries the centre of area for a IElement2Ds surface representation. For an IElement2D with homogeneous material and thickness this will also be the centre of weight. | - | Spatial_Engine |
| ControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api_documentation/oM/Dimensional/Geometry/Point)&gt; | Queries the control points of the element curve representation of the IElement2D. | - | Spatial_Engine |
| DominantVector | [Vector](/api_documentation/oM/Dimensional/Geometry/Vector) | Gets the the dominant vector (orientation) of an Element2D based on its lines lengths. | - | Spatial_Engine |
| ElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api_documentation/oM/Dimensional/Geometry/ICurve)&gt; | Queries the geometricly defining curves of the IElement2Ds surface. | - | Spatial_Engine |
| ElementEmbodiedCarbon | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElementResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/IElementResult%601)&lt;[MaterialResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/MaterialResult)&gt;&gt; | Evaluates the embodied carbon on the provided element based on IStructE methodology of evaluation.<br>If you would like to evaluate other EPD metrics, please use one of the Query.EnvironmentalResults methods. <br>TemplateMaterials can be provided helping with picking the correct EPD corresponding to each material on the element. Please note that this evaluation method only support mass-based EPDs. | - | LifeCycleAssessment_Engine |
| ElementEnvironmentalMetrics | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[EnvironmentalMetric](/api_documentation/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetric)&gt;&gt; | Query the Environmental Product Declarations from any IElementM with a MaterialComposition composed of IEPD materials. | - | LifeCycleAssessment_Engine |
| ElementEpds | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[EnvironmentalProductDeclaration](/api_documentation/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalProductDeclaration)&gt; | Query the Environmental Product Declarations from any IElementM with a MaterialComposition composed of IEPD materials. | - | LifeCycleAssessment_Engine |
| ElementMaterialNames | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Query the element's MaterialComposition to form a Material Hint to aid in EPD-Material Mapping. | - | LifeCycleAssessment_Engine |
| ElementScope | [ScopeType](/api_documentation/oM/Analytical/LifeCycleAssessment/ScopeType) | Returns the enumerable type of the scope found on an element. | - | LifeCycleAssessment_Engine |
| ElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api_documentation/oM/Dimensional/Geometry/Point)&gt; | Returns the discontinuity points from the defining ICurves of the IElement2D. | - | Spatial_Engine |
| EnvironmentalResults | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElementResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/IElementResult%601)&lt;[MaterialResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/MaterialResult)&gt;&gt; | Evaluates the EnvironmentalMetrics for the provided element and returns an ElementResult for each evaluated metric type.<br>Evaluation is done by extracting the material takeoff for the provided element, giving quantities and Materiality.<br>Each Material in the takeoff is then evaluated by finding the EnvironmentalProductDeclaration (EPD), either stored on the material or from the list of template materials.<br>Each metric, or filtered chosen metrics, on the EPD is then evaluated.<br>Finally, an element result is returned per metric type. Each element result being the sum result of all metrics of the same type. | - | LifeCycleAssessment_Engine |
| ExternalElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api_documentation/oM/Dimensional/Geometry/ICurve)&gt; | Queries the geometricly defining external curves of the IElement2Ds surface. | - | Spatial_Engine |
| ExternalPolyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api_documentation/oM/Dimensional/Geometry/Polyline)&gt; | Returns the External Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| Geometry | [IGeometry](/api_documentation/oM/Dimensional/Geometry/IGeometry) | Gets the geometry of a PadFoundation as a surface. Method required for automatic display in UI packages. | - | Physical_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Queries the area of the geometrical representation of an IElement. | [Area](/api_documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| IBounds | [BoundingBox](/api_documentation/oM/Dimensional/Geometry/BoundingBox) | Queries the IElements BoundingBox. Acts on the elements geometrical definition of the IElement through the Geometry_Engine. | - | Spatial_Engine |
| ICentroid | [Point](/api_documentation/oM/Dimensional/Geometry/Point) | Queries the centre of weight for the homogeneous geometrical representation of an IElement. | - | Spatial_Engine |
| IControlPoints | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api_documentation/oM/Dimensional/Geometry/Point)&gt; | Queries the control points of the geometrical representation of an IElement. | - | Spatial_Engine |
| IElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api_documentation/oM/Dimensional/Geometry/ICurve)&gt; | Queries the geometricly defining curves of the IElements geometry. | - | Spatial_Engine |
| IElementVertices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api_documentation/oM/Dimensional/Geometry/Point)&gt; | Returns the discontinuity points from the defining ICurves of the IElement. | - | Spatial_Engine |
| IGeneralMaterialTakeoff | [GeneralMaterialTakeoff](/api_documentation/oM/Physical/Physical/Materials/GeneralMaterialTakeoff) | Gets the unique Materials along with their volumes defining an object's make-up. | - | Matter_Engine |
| IInternalElements2D | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElement2D](/api_documentation/oM/Dimensional/Dimensional/IElement2D)&gt; | Queries the IElement2Ds internal IElement2Ds. Returns a empty list for objects without definied internal elements | - | Spatial_Engine |
| IIsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IIsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any of the curves defining an IElement is closer to itself than the tolerance at any two points (is self intersecting). In case of IElement2D, does not check for intersections between external and internal curves, or between different internal curves. | - | Spatial_Engine |
| IMaterialComposition | [MaterialComposition](/api_documentation/oM/Physical/Physical/Materials/MaterialComposition) | Gets the unique Materials along with their relative proportions defining an object's make-up. | - | Matter_Engine |
| INewInternalElement2D | [IElement2D](/api_documentation/oM/Dimensional/Dimensional/IElement2D) | Creates a IElement2D of a type which can be assigned to the IElement2D. | - | Spatial_Engine |
| InternalElementCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api_documentation/oM/Dimensional/Geometry/ICurve)&gt; | Queries the geometricly defining internal curves, such as Openings, of the IElement2Ds surface. | - | Spatial_Engine |
| InternalOutlineCurves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[PolyCurve](/api_documentation/oM/Dimensional/Geometry/PolyCurve)&gt; | Queries the IElement2Ds internal IElement2Ds outline curves. | - | Spatial_Engine |
| InternalPolyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api_documentation/oM/Dimensional/Geometry/Polyline)&gt; | Returns the Internal Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| IOutlineElements1D | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElement1D](/api_documentation/oM/Dimensional/Dimensional/IElement1D)&gt; | Returns every IElement1D which makes up the exterior perimeter of the IElement2D. | - | Spatial_Engine |
| IPrimaryPropertyName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns the name of an elements primary defining construction property | - | Facade_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a PadFoundation is null and outputs relevant error message. | - | Physical_Engine |
| ISolidVolume | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns an element's solid volume, i.e. the the volume of the element that had any materiality, excluding cavities, openings and voids. | [Volume](/api_documentation/oM/Dimensional/Quantities/Attributes/Volume) [m³] | Matter_Engine |
| IsPlanar | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether all control points of an element lie in a single plane. | - | Spatial_Engine |
| IsSelfIntersecting | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if any of the element curves of the IElement2D is closer to itself than the tolerance at any two points. Does not check for intersections between external and internal curves, or between different internal curves. | - | Spatial_Engine |
| IVolumetricMaterialTakeoff | [VolumetricMaterialTakeoff](/api_documentation/oM/Physical/Physical/Materials/VolumetricMaterialTakeoff) | Gets the unique Materials along with their volumes defining an object's make-up. | - | Matter_Engine |
| Mass | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Evaluates the mass of an object based its VolumetricMaterialTakeoff and Density. | [Mass](/api_documentation/oM/Dimensional/Quantities/Attributes/Mass) [kg] | Matter_Engine |
| MaterialComposition | [MaterialComposition](/api_documentation/oM/Physical/Physical/Materials/MaterialComposition) | Gets all the Materials a PadFoundation is composed of and in which ratios. | - | Physical_Engine |
| Normal | [Vector](/api_documentation/oM/Dimensional/Geometry/Vector) | Returns the normal to the IElement2D which is perpendicular to its plane and oriented according to the right hand rule in relation to the outline curve. | - | Spatial_Engine |
| OutlineCurve | [PolyCurve](/api_documentation/oM/Dimensional/Geometry/PolyCurve) | Returns a single polycurve outline created from the external elements. | - | Spatial_Engine |
| OutlineElements1D | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElement1D](/api_documentation/oM/Dimensional/Dimensional/IElement1D)&gt; | Gets the external outline elements of a PadFoundation. | - | Physical_Engine |
| Polyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api_documentation/oM/Dimensional/Geometry/Polyline)&gt; | Returns a Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| QuantityTypes | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[QuantityType](/api_documentation/oM/Analytical/LifeCycleAssessment/QuantityType)&gt; | Query the QuantityType values from any IElementM object's MaterialComposition. | - | LifeCycleAssessment_Engine |
| SolidVolume | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the solid volume of a PadFoundation based on the thickness and area. | [Volume](/api_documentation/oM/Dimensional/Quantities/Attributes/Volume) [m³] | Physical_Engine |
| VolumetricMaterialTakeoff | [VolumetricMaterialTakeoff](/api_documentation/oM/Physical/Physical/Materials/VolumetricMaterialTakeoff) | Gets the volumetric material takeoff from a PadFoundation. | - | Physical_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [PadFoundation.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/Elements\PadFoundation.cs)

All history and changes of the class can be found by inspection the history.
