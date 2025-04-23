---
title: Wire
---

# MEP.System.Wire

Wire object to work within an MEP systems.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Wire in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  Dimensional.[IElementM](/api/oM/Dimensional/Dimensional/IElementM)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| WireSegments | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[WireSegment](/api/oM/Analytical/MEP/System/WireSegment)&gt; | Collection of WireSegments. | - |


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
| ElementEmbodiedCarbon | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/IElementResult%601)&lt;[MaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResult)&gt;&gt; | Evaluates the embodied carbon on the provided element based on IStructE methodology of evaluation.<br>If you would like to evaluate other EPD metrics, please use one of the Query.EnvironmentalResults methods. <br>TemplateMaterials can be provided helping with picking the correct EPD corresponding to each material on the element. Please note that this evaluation method only support mass-based EPDs. | - | LifeCycleAssessment_Engine |
| ElementEnvironmentalMetrics | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[EnvironmentalMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetric)&gt;&gt; | Query the Environmental Product Declarations from any IElementM with a MaterialComposition composed of IEPD materials. | - | LifeCycleAssessment_Engine |
| ElementEpds | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[EnvironmentalProductDeclaration](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalProductDeclaration)&gt; | Query the Environmental Product Declarations from any IElementM with a MaterialComposition composed of IEPD materials. | - | LifeCycleAssessment_Engine |
| ElementMaterialNames | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Query the element's MaterialComposition to form a Material Hint to aid in EPD-Material Mapping. | - | LifeCycleAssessment_Engine |
| ElementScope | [ScopeType](/api/oM/Analytical/LifeCycleAssessment/ScopeType) | Returns the enumerable type of the scope found on an element. | - | LifeCycleAssessment_Engine |
| EnvironmentalResults | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/IElementResult%601)&lt;[MaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResult)&gt;&gt; | Evaluates the EnvironmentalMetrics for the provided element and returns an ElementResult for each evaluated metric type.<br>Evaluation is done by extracting the material takeoff for the provided element, giving quantities and Materiality.<br>Each Material in the takeoff is then evaluated by finding the EnvironmentalProductDeclaration (EPD), either stored on the material or from the list of template materials.<br>Each metric, or filtered chosen metrics, on the EPD is then evaluated.<br>Finally, an element result is returned per metric type. Each element result being the sum result of all metrics of the same type. | - | LifeCycleAssessment_Engine |
| IGeneralMaterialTakeoff | [GeneralMaterialTakeoff](/api/oM/Physical/Physical/Materials/GeneralMaterialTakeoff) | Gets the unique Materials along with their volumes defining an object's make-up. | - | Matter_Engine |
| IMaterialComposition | [MaterialComposition](/api/oM/Physical/Physical/Materials/MaterialComposition) | Gets the unique Materials along with their relative proportions defining an object's make-up. | - | Matter_Engine |
| ISolidVolume | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns an element's solid volume, i.e. the the volume of the element that had any materiality, excluding cavities, openings and voids. | [Volume](/api/oM/Dimensional/Quantities/Attributes/Volume) [m³] | Matter_Engine |
| IVolumetricMaterialTakeoff | [VolumetricMaterialTakeoff](/api/oM/Physical/Physical/Materials/VolumetricMaterialTakeoff) | Gets the unique Materials along with their volumes defining an object's make-up. | - | Matter_Engine |
| Mass | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Evaluates the mass of an object based its VolumetricMaterialTakeoff and Density. | [Mass](/api/oM/Dimensional/Quantities/Attributes/Mass) [kg] | Matter_Engine |
| QuantityTypes | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[QuantityType](/api/oM/Analytical/LifeCycleAssessment/QuantityType)&gt; | Query the QuantityType values from any IElementM object's MaterialComposition. | - | LifeCycleAssessment_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Wire.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/System\Wire.cs)

All history and changes of the class can be found by inspection the history.
