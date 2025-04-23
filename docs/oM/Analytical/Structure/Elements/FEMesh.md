---
title: FEMesh
---

# Structure.Elements.FEMesh

2D finite element mesh for structural analysis. Defined by a list of nodes and faces.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FEMesh in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  Structure.Elements.[IAreaElement](/api/oM/Analytical/Structure/Elements/IAreaElement)
    -  Dimensional.[IElementM](/api/oM/Dimensional/Dimensional/IElementM)
    -  Analytical.Elements.[IMesh](/api/oM/Analytical/Analytical/Elements/IMesh%602)&lt;Structure.Elements.[Node](/api/oM/Analytical/Structure/Elements/Node), Structure.Elements.[FEMeshFace](/api/oM/Analytical/Structure/Elements/FEMeshFace)&gt;
    -  Analytical.[IAnalytical](/api/oM/Analytical/Analytical/IAnalytical)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Nodes | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Node](/api/oM/Analytical/Structure/Elements/Node)&gt; | The nodes of the FEMesh. Mesh faces reference these nodes by their position in this list, so it is important to maintain the order. | - |
| Faces | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[FEMeshFace](/api/oM/Analytical/Structure/Elements/FEMeshFace)&gt; | The faces of the FEMesh. Each face contains a list of indices referring to the nodes in the node list it is connecting. | - |
| Property | [ISurfaceProperty](/api/oM/Analytical/Structure/SurfaceProperties/ISurfaceProperty) | Defines the thickness property and material of the FEMesh. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Area | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the area of a FEMesh as the sum of the area of all faces. Quad faces will be triangulated to perform the area calculation. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Structure_Engine |
| CoordinateSystem | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Cartesian](/api/oM/Dimensional/Geometry/CoordinateSystem/Cartesian)&gt; | Get the Cartesian coordinate system descibring the position and local orientation of the FEMeshFaces of the FEMesh in the global coordinate system where the z-axis is the normal of the FEMeshFace and the x and y axes are the directions of the local in-plane axes. | - | Structure_Engine |
| ElementEmbodiedCarbon | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/IElementResult%601)&lt;[MaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResult)&gt;&gt; | Evaluates the embodied carbon on the provided element based on IStructE methodology of evaluation.<br>If you would like to evaluate other EPD metrics, please use one of the Query.EnvironmentalResults methods. <br>TemplateMaterials can be provided helping with picking the correct EPD corresponding to each material on the element. Please note that this evaluation method only support mass-based EPDs. | - | LifeCycleAssessment_Engine |
| ElementEnvironmentalMetrics | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[EnvironmentalMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetric)&gt;&gt; | Query the Environmental Product Declarations from any IElementM with a MaterialComposition composed of IEPD materials. | - | LifeCycleAssessment_Engine |
| ElementEpds | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[EnvironmentalProductDeclaration](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalProductDeclaration)&gt; | Query the Environmental Product Declarations from any IElementM with a MaterialComposition composed of IEPD materials. | - | LifeCycleAssessment_Engine |
| ElementMaterialNames | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Query the element's MaterialComposition to form a Material Hint to aid in EPD-Material Mapping. | - | LifeCycleAssessment_Engine |
| ElementScope | [ScopeType](/api/oM/Analytical/LifeCycleAssessment/ScopeType) | Returns the enumerable type of the scope found on an element. | - | LifeCycleAssessment_Engine |
| EnvironmentalResults | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/IElementResult%601)&lt;[MaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResult)&gt;&gt; | Evaluates the EnvironmentalMetrics for the provided element and returns an ElementResult for each evaluated metric type.<br>Evaluation is done by extracting the material takeoff for the provided element, giving quantities and Materiality.<br>Each Material in the takeoff is then evaluated by finding the EnvironmentalProductDeclaration (EPD), either stored on the material or from the list of template materials.<br>Each metric, or filtered chosen metrics, on the EPD is then evaluated.<br>Finally, an element result is returned per metric type. Each element result being the sum result of all metrics of the same type. | - | LifeCycleAssessment_Engine |
| IArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the area of an IAreaElement. | [Area](/api/oM/Dimensional/Quantities/Attributes/Area) [m²] | Structure_Engine |
| IEdges | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/ICurve)&gt; | Extracts all the edge curves from an AreaElement. | - | Structure_Engine |
| IGeneralMaterialTakeoff | [GeneralMaterialTakeoff](/api/oM/Physical/Physical/Materials/GeneralMaterialTakeoff) | Gets the unique Materials along with their volumes defining an object's make-up. | - | Matter_Engine |
| IIsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if an AreaElement is null and outputs relevant error message. | - | Structure_Engine |
| IMaterialComposition | [MaterialComposition](/api/oM/Physical/Physical/Materials/MaterialComposition) | Gets the unique Materials along with their relative proportions defining an object's make-up. | - | Matter_Engine |
| INormal | [Vector](/api/oM/Dimensional/Geometry/Vector) | Returns the local z-axis of the IAreaElement. | - | Structure_Engine |
| IPointGrid | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Point)&gt; | Generates a rectangular grid of points on an IAreaElement. Used for load visualisation. | - | Structure_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if an FEMesh or its defining properties are null and outputs relevant error message. | - | Structure_Engine |
| ISolidVolume | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns an element's solid volume, i.e. the the volume of the element that had any materiality, excluding cavities, openings and voids. | [Volume](/api/oM/Dimensional/Quantities/Attributes/Volume) [m³] | Matter_Engine |
| IVolumetricMaterialTakeoff | [VolumetricMaterialTakeoff](/api/oM/Physical/Physical/Materials/VolumetricMaterialTakeoff) | Gets the unique Materials along with their volumes defining an object's make-up. | - | Matter_Engine |
| LocalOrientations | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Basis](/api/oM/Dimensional/Geometry/Basis)&gt; | Get the Vector basis system descibring the local axes orientation of the faces of the FEMesh in the global coordinate system where the z-axis is the normal of each face and the x and y axes are the directions of the local in-plane axes. | - | Structure_Engine |
| Mass | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Evaluates the mass of an object based its VolumetricMaterialTakeoff and Density. | [Mass](/api/oM/Dimensional/Quantities/Attributes/Mass) [kg] | Matter_Engine |
| MaterialComposition | [MaterialComposition](/api/oM/Physical/Physical/Materials/MaterialComposition) | Returns an AreaElement's homogeneous MaterialComposition. | - | Structure_Engine |
| Normals | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Vector](/api/oM/Dimensional/Geometry/Vector)&gt; | Returns the local z-axes of all FEMeshFaces in the FEMesh. Can only extract normals for 3 or 4-sided faces. | - | Structure_Engine |
| PointGrid | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Point](/api/oM/Dimensional/Geometry/Point)&gt;&gt; | Generates a rectangular grid of points on the each face of the FEMesh. Used for load visualisation. | - | Structure_Engine |
| QuantityTypes | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[QuantityType](/api/oM/Analytical/LifeCycleAssessment/QuantityType)&gt; | Query the QuantityType values from any IElementM object's MaterialComposition. | - | LifeCycleAssessment_Engine |
| SolidVolume | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns a IAreaElement's solid volume as the area of the element times the average thickness of its SurfaceProperty. The average thickness is evaluated as if it was applied to an infinite plane. | [Volume](/api/oM/Dimensional/Quantities/Attributes/Volume) [m³] | Structure_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [FEMesh.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Elements\FEMesh.cs)

All history and changes of the class can be found by inspection the history.
