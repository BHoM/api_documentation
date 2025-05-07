---
title: ClimateChangeLandUseMetric
---

# <small>BH.oM.LifeCycleAssessment.MaterialFragments.</small>**ClimateChangeLandUseMetric**

Climate Change - Land Use and Land Use Change, measured in kg CO2 eq (Carbon Dioxide equivalent, also referred to as embodied carbon), refers to the exploitation of land and its resources, which contributes to global warming. This environmental indicator forms part of an Environmental Product Declaration and should be evaluated based on the Quantity Type stated on the Environmental Product Declaration.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ClimateChangeLandUseMetric is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LifeCycleAssessment.MaterialFragments.[EnvironmentalMetric](/api/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetrics/EnvironmentalMetric)
    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.LifeCycleAssessment.[ILifeCycleAssessmentPhaseData](/api/oM/Analytical/LifeCycleAssessment/ILifeCycleAssessmentPhaseData)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| A1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Climate change - Land Use and Land Use Change relating to the Raw Material Supply module in the Product stage. | [ClimateChangePerQuantity](/api/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity) [kg CO2 eq per unit] |
| A2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Climate change - Land Use and Land Use Change relating to the Transport module in the Product stage. | [ClimateChangePerQuantity](/api/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity) [kg CO2 eq per unit] |
| A3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Climate change - Land Use and Land Use Change relating to the Manufacturing module in the Product stage. | [ClimateChangePerQuantity](/api/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity) [kg CO2 eq per unit] |
| A1toA3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Climate change - Land Use and Land Use Change relating to the full Product stage. | [ClimateChangePerQuantity](/api/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity) [kg CO2 eq per unit] |
| A4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Climate change - Land Use and Land Use Change relating to the Transport module in the Construction Process stage. | [ClimateChangePerQuantity](/api/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity) [kg CO2 eq per unit] |
| A5 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Climate change - Land Use and Land Use Change relating to the Construction Installation Process module in the Construction Process stage. | [ClimateChangePerQuantity](/api/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity) [kg CO2 eq per unit] |
| B1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Climate change - Land Use and Land Use Change relating to the Use module in the Use stage. | [ClimateChangePerQuantity](/api/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity) [kg CO2 eq per unit] |
| B2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Climate change - Land Use and Land Use Change relating to the Maintenance module in the Use stage. | [ClimateChangePerQuantity](/api/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity) [kg CO2 eq per unit] |
| B3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Climate change - Land Use and Land Use Change relating to the Repair module in the Use stage. | [ClimateChangePerQuantity](/api/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity) [kg CO2 eq per unit] |
| B4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Climate change - Land Use and Land Use Change relating to the Replacement module in the Use stage. | [ClimateChangePerQuantity](/api/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity) [kg CO2 eq per unit] |
| B5 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Climate change - Land Use and Land Use Change relating to the Refurbishment module in the Use stage. | [ClimateChangePerQuantity](/api/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity) [kg CO2 eq per unit] |
| B6 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Climate change - Land Use and Land Use Change relating to the Operational Energy Use module in the Use stage. | [ClimateChangePerQuantity](/api/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity) [kg CO2 eq per unit] |
| B7 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Climate change - Land Use and Land Use Change relating to the Operational Water Use module in the Use stage. | [ClimateChangePerQuantity](/api/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity) [kg CO2 eq per unit] |
| B1toB7 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Climate change - Land Use and Land Use Change relating to the full Use Stage. | [ClimateChangePerQuantity](/api/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity) [kg CO2 eq per unit] |
| C1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Climate change - Land Use and Land Use Change relating to the De-construction Demolition module in the End of Life stage. | [ClimateChangePerQuantity](/api/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity) [kg CO2 eq per unit] |
| C2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Climate change - Land Use and Land Use Change relating to the Transport module in the End of Life stage. | [ClimateChangePerQuantity](/api/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity) [kg CO2 eq per unit] |
| C3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Climate change - Land Use and Land Use Change relating to the Waste Processing module in the End of Life stage. | [ClimateChangePerQuantity](/api/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity) [kg CO2 eq per unit] |
| C4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Climate change - Land Use and Land Use Change relating to the Disposal module in the End of Life stage. | [ClimateChangePerQuantity](/api/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity) [kg CO2 eq per unit] |
| C1toC4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Climate change - Land Use and Land Use Change relating to the full End of Life stage. | [ClimateChangePerQuantity](/api/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity) [kg CO2 eq per unit] |
| D | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Climate change - Land Use and Land Use Change relating to benefits and loads beyond the system boundary. | [ClimateChangePerQuantity](/api/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity) [kg CO2 eq per unit] |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| MetricType | [EnvironmentalMetrics](/api/oM/Analytical/LifeCycleAssessment/Enums/EnvironmentalMetrics) | Enum indicating the metric type the object relates to. | - |
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| ATotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total sum of values from all A-phases (A1-A5) with a set value (all values not NaN). | - | LifeCycleAssessment_Engine |
| BTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total sum of values from all B-phases (B1-B7) with a set value (all values not NaN). | - | LifeCycleAssessment_Engine |
| CTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total sum of values from all C-phases (C1-C4) with a set value (all values not NaN). | - | LifeCycleAssessment_Engine |
| IPhaseDataValues | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt; | Gets the values corresponding to the values of all phases as a list of doubles. | - | LifeCycleAssessment_Engine |
| Total | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total sum of values from all phases with a set value (all values not NaN). | - | LifeCycleAssessment_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ClimateChangeLandUseMetric : BH.oM.LifeCycleAssessment.MaterialFragments.EnvironmentalMetric,
BH.oM.Base.BHoMObject,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.LifeCycleAssessment.ILifeCycleAssessmentPhaseData,
BH.oM.Base.IImmutable
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [ClimateChangeLandUseMetric.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/MaterialFragments\EnvironmentalMetrics\ClimateChangeLandUseMetric.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LifeCycleAssessment_oM/MaterialFragments/ClimateChangeLandUseMetric.json"
}
```

The JSON Schema is available on github here:

- [ClimateChangeLandUseMetric.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LifeCycleAssessment_oM/MaterialFragments/ClimateChangeLandUseMetric.json)
