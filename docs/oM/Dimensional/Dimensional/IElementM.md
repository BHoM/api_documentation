---
title: IElementM
---

# Dimensional.IElementM

Enables Mass based operations to be performed on elements with materiality
Ensures the material composition of a physical object is represented, defined as proportions of discrete types of material forming the object's total solid volume.
Objects implementing this Interface will be required to implement some base methods for getting and setting data in a way that maintains the object's other properties.


[Documentation link](https://bhom.xyz/documentation/BHoM_oM/Dimensional_oM/IElement-required-extension-methods/)

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IElementM in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/api/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - MEP.System.[IFlow](/api/oM/Analytical/MEP/System/IFlow)
    - Physical.Elements.[IFramingElement](/api/oM/Physical/Physical/Elements/IFramingElement)
    - Physical.Elements.[ISolid](/api/oM/Physical/Physical/Elements/ISolid)
    - Physical.Elements.[ISurface](/api/oM/Physical/Physical/Elements/ISurface)
    - Structure.Elements.[IAreaElement](/api/oM/Analytical/Structure/Elements/IAreaElement)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Environment.Elements.[Opening](/api/oM/Analytical/Environment/Elements/Opening)
    - Environment.Elements.[Panel](/api/oM/Analytical/Environment/Elements/Panel)
    - Facade.Elements.[CurtainWall](/api/oM/Analytical/Facade/Elements/CurtainWall)
    - Facade.Elements.[FrameEdge](/api/oM/Analytical/Facade/Elements/FrameEdge)
    - Facade.Elements.[Opening](/api/oM/Analytical/Facade/Elements/Opening)
    - Facade.Elements.[Panel](/api/oM/Analytical/Facade/Elements/Panel)
    - MEP.System.[CableTray](/api/oM/Analytical/MEP/System/CableTray)
    - MEP.System.[Duct](/api/oM/Analytical/MEP/System/Duct)
    - MEP.System.[FlowSystem](/api/oM/Analytical/MEP/System/FlowSystem)
    - MEP.System.[Pipe](/api/oM/Analytical/MEP/System/Pipe)
    - MEP.System.[Wire](/api/oM/Analytical/MEP/System/Wire)
    - MEP.System.[WireSegment](/api/oM/Analytical/MEP/System/WireSegment)
    - Physical.Elements.[Beam](/api/oM/Physical/Physical/Elements/Beam)
    - Physical.Elements.[Bracing](/api/oM/Physical/Physical/Elements/Bracing)
    - Physical.Elements.[Cable](/api/oM/Physical/Physical/Elements/Cable)
    - Physical.Elements.[Column](/api/oM/Physical/Physical/Elements/Column)
    - Physical.Elements.[Door](/api/oM/Physical/Physical/Elements/Door)
    - Physical.Elements.[ExplicitBulk](/api/oM/Physical/Physical/Elements/ExplicitBulk)
    - Physical.Elements.[Floor](/api/oM/Physical/Physical/Elements/Floor)
    - Physical.Elements.[PadFoundation](/api/oM/Physical/Physical/Elements/PadFoundation)
    - Physical.Elements.[Pile](/api/oM/Physical/Physical/Elements/Pile)
    - Physical.Elements.[PileFoundation](/api/oM/Physical/Physical/Elements/PileFoundation)
    - Physical.Elements.[Roof](/api/oM/Physical/Physical/Elements/Roof)
    - Physical.Elements.[SolidBulk](/api/oM/Physical/Physical/Elements/SolidBulk)
    - Physical.Elements.[Wall](/api/oM/Physical/Physical/Elements/Wall)
    - Physical.Elements.[Window](/api/oM/Physical/Physical/Elements/Window)
    - Security.Elements.[CameraDevice](/api/oM/Analytical/Security/Elements/CameraDevice)
    - Structure.Elements.[Bar](/api/oM/Analytical/Structure/Elements/Bar)
    - Structure.Elements.[FEMesh](/api/oM/Analytical/Structure/Elements/FEMesh)
    - Structure.Elements.[PadFoundation](/api/oM/Analytical/Structure/Elements/PadFoundation)
    - Structure.Elements.[Panel](/api/oM/Analytical/Structure/Elements/Panel)
    - Structure.Elements.[Pile](/api/oM/Analytical/Structure/Elements/Pile)
    - Structure.Elements.[PileFoundation](/api/oM/Analytical/Structure/Elements/PileFoundation)
    - Structure.Elements.[RetainingWall](/api/oM/Analytical/Structure/Elements/RetainingWall)
    - Structure.Elements.[Stem](/api/oM/Analytical/Structure/Elements/Stem)
    - Structure.Elements.[Surface](/api/oM/Analytical/Structure/Elements/Surface)


## Properties

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

The interface is defined in C#. The class definition is available on github:

- [IElementM.cs](https://github.com/BHoM/BHoM/blob/develop/Dimensional_oM/IElementM.cs)

All history and changes of the class can be found by inspection the history.
