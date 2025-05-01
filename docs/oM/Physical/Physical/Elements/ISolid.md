---
title: ISolid
---

# <small>BH.oM.Physical.Elements.</small>**ISolid**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISolid is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Physical.[IPhysical](/api/oM/Physical/Physical/IPhysical)
    -  BH.oM.Dimensional.[IElementM](/api/oM/Dimensional/Dimensional/IElementM)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Physical.Elements.[SolidBulk](/api/oM/Physical/Physical/Elements/SolidBulk)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Geometry | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ISolid](/api/oM/Dimensional/Geometry/Solid/ISolid)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| ElementEmbodiedCarbon | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/IElementResult)&lt;[MaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/MaterialResult)&gt;&gt; | Evaluates the embodied carbon on the provided element based on IStructE methodology of evaluation.<br>If you would like to evaluate other EPD metrics, please use one of the Query.EnvironmentalResults methods. <br>TemplateMaterials can be provided helping with picking the correct EPD corresponding to each material on the element. Please note that this evaluation method only support mass-based EPDs. | - | LifeCycleAssessment_Engine |
| ElementEnvironmentalMetrics | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[EnvironmentalMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/EnvironmentalMetric)&gt;&gt; | Query the Environmental Product Declarations from any IElementM with a MaterialComposition composed of IEPD materials. | - | LifeCycleAssessment_Engine |
| ElementEpds | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[EnvironmentalProductDeclaration](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalProductDeclaration)&gt; | Query the Environmental Product Declarations from any IElementM with a MaterialComposition composed of IEPD materials. | - | LifeCycleAssessment_Engine |
| ElementMaterialNames | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Query the element's MaterialComposition to form a Material Hint to aid in EPD-Material Mapping. | - | LifeCycleAssessment_Engine |
| ElementScope | [ScopeType](/api/oM/Analytical/LifeCycleAssessment/Enums/ScopeType) | Returns the enumerable type of the scope found on an element. | - | LifeCycleAssessment_Engine |
| EnvironmentalResults | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResults/IElementResult)&lt;[MaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/MaterialResult)&gt;&gt; | Evaluates the EnvironmentalMetrics for the provided element and returns an ElementResult for each evaluated metric type.<br>Evaluation is done by extracting the material takeoff for the provided element, giving quantities and Materiality.<br>Each Material in the takeoff is then evaluated by finding the EnvironmentalProductDeclaration (EPD), either stored on the material or from the list of template materials.<br>Each metric, or filtered chosen metrics, on the EPD is then evaluated.<br>Finally, an element result is returned per metric type. Each element result being the sum result of all metrics of the same type. | - | LifeCycleAssessment_Engine |
| ExternalPolyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api/oM/Dimensional/Geometry/Curve/Polyline)&gt; | Returns the External Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| IGeneralMaterialTakeoff | [GeneralMaterialTakeoff](/api/oM/Physical/Physical/Materials/GeneralMaterialTakeoff) | Gets the unique Materials along with their volumes defining an object's make-up. | - | Matter_Engine |
| IMaterialComposition | [MaterialComposition](/api/oM/Physical/Physical/Materials/MaterialComposition) | Gets the unique Materials along with their relative proportions defining an object's make-up. | - | Matter_Engine |
| InternalPolyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api/oM/Dimensional/Geometry/Curve/Polyline)&gt; | Returns the Internal Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| ISolidVolume | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns an element's solid volume, i.e. the the volume of the element that had any materiality, excluding cavities, openings and voids. | [Volume](/api/oM/Dimensional/Quantities/Attributes/Volume) [m³] | Matter_Engine |
| IVolumetricMaterialTakeoff | [VolumetricMaterialTakeoff](/api/oM/Physical/Physical/Materials/VolumetricMaterialTakeoff) | Gets the unique Materials along with their volumes defining an object's make-up. | - | Matter_Engine |
| Mass | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Evaluates the mass of an object based its VolumetricMaterialTakeoff and Density. | [Mass](/api/oM/Dimensional/Quantities/Attributes/Mass) [kg] | Matter_Engine |
| Polyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api/oM/Dimensional/Geometry/Curve/Polyline)&gt; | Returns a Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| QuantityTypes | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[QuantityType](/api/oM/Analytical/LifeCycleAssessment/Enums/QuantityType)&gt; | Query the QuantityType values from any IElementM object's MaterialComposition. | - | LifeCycleAssessment_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface ISolid : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Physical.IPhysical, BH.oM.Dimensional.IElementM
```

Assembly: Physical_oM.dll

The C# interface definition is available on github:

- [ISolid.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/Elements\ISolid.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Physical_oM/Elements/ISolid.json"
}
```

The JSON Schema is available on github here:

- [ISolid.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Physical_oM/Elements/ISolid.json)
