---
title: PhotochemicalOzoneCreationTRACIMaterialResult
---

# <small>BH.oM.LifeCycleAssessment.Results.</small>**PhotochemicalOzoneCreationTRACIMaterialResult**

Result class for resulting Photochemical Ozone Creation as defined by the TRACI standard for a particular Material and EPD.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PhotochemicalOzoneCreationTRACIMaterialResult is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LifeCycleAssessment.Results.[MaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResults/MaterialResult)
    -  BH.oM.LifeCycleAssessment.Results.[IEnvironmentalResult](/api/oM/Analytical/LifeCycleAssessment/Results/IEnvironmentalResult)
    -  BH.oM.Analytical.Results.[IResultItem](/api/oM/Analytical/Analytical/Results/IResultItem)
    -  BH.oM.Analytical.Results.[IResult](/api/oM/Analytical/Analytical/Results/IResult)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;BH.oM.Analytical.Results.[IResult](/api/oM/Analytical/Analytical/Results/IResult)&gt;
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.LifeCycleAssessment.[ILifeCycleAssessmentPhaseData](/api/oM/Analytical/LifeCycleAssessment/ILifeCycleAssessmentPhaseData)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| A1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Photochemical Ozone Creation as defined by the TRACI standard relating to the Raw Material Supply module in the Product stage. | [PhotochemicalOzoneCreationTRACI](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI) [kg O₃ eq] |
| A2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Photochemical Ozone Creation as defined by the TRACI standard relating to the Transport module in the Product stage. | [PhotochemicalOzoneCreationTRACI](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI) [kg O₃ eq] |
| A3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Photochemical Ozone Creation as defined by the TRACI standard relating to the Manufacturing module in the Product stage. | [PhotochemicalOzoneCreationTRACI](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI) [kg O₃ eq] |
| A1toA3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Photochemical Ozone Creation as defined by the TRACI standard relating to the full Product stage. | [PhotochemicalOzoneCreationTRACI](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI) [kg O₃ eq] |
| A4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Photochemical Ozone Creation as defined by the TRACI standard relating to the Transport module in the Construction Process stage. | [PhotochemicalOzoneCreationTRACI](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI) [kg O₃ eq] |
| A5 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Photochemical Ozone Creation as defined by the TRACI standard relating to the Construction Installation Process module in the Construction Process stage. | [PhotochemicalOzoneCreationTRACI](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI) [kg O₃ eq] |
| B1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Photochemical Ozone Creation as defined by the TRACI standard relating to the Use module in the Use stage. | [PhotochemicalOzoneCreationTRACI](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI) [kg O₃ eq] |
| B2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Photochemical Ozone Creation as defined by the TRACI standard relating to the Maintenance module in the Use stage. | [PhotochemicalOzoneCreationTRACI](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI) [kg O₃ eq] |
| B3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Photochemical Ozone Creation as defined by the TRACI standard relating to the Repair module in the Use stage. | [PhotochemicalOzoneCreationTRACI](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI) [kg O₃ eq] |
| B4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Photochemical Ozone Creation as defined by the TRACI standard relating to the Replacement module in the Use stage. | [PhotochemicalOzoneCreationTRACI](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI) [kg O₃ eq] |
| B5 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Photochemical Ozone Creation as defined by the TRACI standard relating to the Refurbishment module in the Use stage. | [PhotochemicalOzoneCreationTRACI](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI) [kg O₃ eq] |
| B6 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Photochemical Ozone Creation as defined by the TRACI standard relating to the Operational Energy Use module in the Use stage. | [PhotochemicalOzoneCreationTRACI](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI) [kg O₃ eq] |
| B7 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Photochemical Ozone Creation as defined by the TRACI standard relating to the Operational Water Use module in the Use stage. | [PhotochemicalOzoneCreationTRACI](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI) [kg O₃ eq] |
| B1toB7 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Photochemical Ozone Creation as defined by the TRACI standard relating to the full Use Stage. | [PhotochemicalOzoneCreationTRACI](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI) [kg O₃ eq] |
| C1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Photochemical Ozone Creation as defined by the TRACI standard relating to the De-construction Demolition module in the End of Life stage. | [PhotochemicalOzoneCreationTRACI](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI) [kg O₃ eq] |
| C2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Photochemical Ozone Creation as defined by the TRACI standard relating to the Transport module in the End of Life stage. | [PhotochemicalOzoneCreationTRACI](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI) [kg O₃ eq] |
| C3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Photochemical Ozone Creation as defined by the TRACI standard relating to the Waste Processing module in the End of Life stage. | [PhotochemicalOzoneCreationTRACI](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI) [kg O₃ eq] |
| C4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Photochemical Ozone Creation as defined by the TRACI standard relating to the Disposal module in the End of Life stage. | [PhotochemicalOzoneCreationTRACI](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI) [kg O₃ eq] |
| C1toC4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Photochemical Ozone Creation as defined by the TRACI standard relating to the full End of Life stage. | [PhotochemicalOzoneCreationTRACI](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI) [kg O₃ eq] |
| D | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Photochemical Ozone Creation as defined by the TRACI standard relating to benefits and loads beyond the system boundary. | [PhotochemicalOzoneCreationTRACI](/api/oM/Dimensional/Quantities/Attributes/PhotochemicalOzoneCreationTRACI) [kg O₃ eq] |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| MaterialName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the physical material evaluated. | - |
| EnvironmentalProductDeclarationName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the Environmental Product Declaration evaluated. | - |
| MetricType | [EnvironmentalMetrics](/api/oM/Analytical/LifeCycleAssessment/Enums/EnvironmentalMetrics) | Enum indicating the metric type the object relates to. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| AllIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of identifier types. This is all properties tagged with any IdentifierAttribute. | - | Results_Engine |
| ATotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total sum of values from all A-phases (A1-A5) with a set value (all values not NaN). | - | LifeCycleAssessment_Engine |
| BTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total sum of values from all B-phases (B1-B7) with a set value (all values not NaN). | - | LifeCycleAssessment_Engine |
| CTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total sum of values from all C-phases (C1-C4) with a set value (all values not NaN). | - | LifeCycleAssessment_Engine |
| IPhaseDataValues | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt; | Gets the values corresponding to the values of all phases as a list of doubles. | - | LifeCycleAssessment_Engine |
| ObjectIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of ObjectIdentifier types. This is all properties tagged with the ObjectIdentifierAttribute. | - | Results_Engine |
| ResultPropertyKeys | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Returns the result value carrying properties available for the result type provided. Currently only supported for IResultItem and IResultCollection&lt;IResultItem&gt; type results. | - | Results_Engine |
| ScenarioIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of Scenario types. This is all properties tagged with the ScenarioIdentifierAttribute. | - | Results_Engine |
| Total | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total sum of values from all phases with a set value (all values not NaN). | - | LifeCycleAssessment_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PhotochemicalOzoneCreationTRACIMaterialResult : BH.oM.LifeCycleAssessment.Results.MaterialResult,
BH.oM.LifeCycleAssessment.Results.IEnvironmentalResult,
BH.oM.Analytical.Results.IResultItem,
BH.oM.Analytical.Results.IResult,
BH.oM.Base.IObject,
System.IComparable<BH.oM.Analytical.Results.IResult>,
BH.oM.Base.IImmutable,
BH.oM.LifeCycleAssessment.ILifeCycleAssessmentPhaseData
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [PhotochemicalOzoneCreationTRACIMaterialResult.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/Results\MaterialResults\PhotochemicalOzoneCreationTRACIMaterialResult.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LifeCycleAssessment_oM/Results/PhotochemicalOzoneCreationTRACIMaterialResult.json"
}
```

The JSON Schema is available on github here:

- [PhotochemicalOzoneCreationTRACIMaterialResult.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LifeCycleAssessment_oM/Results/PhotochemicalOzoneCreationTRACIMaterialResult.json)
