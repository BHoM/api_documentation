---
title: ClimateChangeLandUseMaterialResult
---

# <small>BH.oM.LifeCycleAssessment.</small>**ClimateChangeLandUseMaterialResult**

Result class for resulting Climate change - Land Use and Land Use Change for a particular Material and EPD.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ClimateChangeLandUseMaterialResult is inheriting from the following base type(s) and implements the following interfaces:"

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
| A1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Climate change - Land Use and Land Use Change relating to the Raw Material Supply module in the Product stage. | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |
| A2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Climate change - Land Use and Land Use Change relating to the Transport module in the Product stage. | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |
| A3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Climate change - Land Use and Land Use Change relating to the Manufacturing module in the Product stage. | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |
| A1toA3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Climate change - Land Use and Land Use Change relating to the full Product stage. | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |
| A4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Climate change - Land Use and Land Use Change relating to the Transport module in the Construction Process stage. | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |
| A5 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Climate change - Land Use and Land Use Change relating to the Construction Installation Process module in the Construction Process stage. | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |
| B1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Climate change - Land Use and Land Use Change relating to the Use module in the Use stage. | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |
| B2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Climate change - Land Use and Land Use Change relating to the Maintenance module in the Use stage. | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |
| B3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Climate change - Land Use and Land Use Change relating to the Repair module in the Use stage. | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |
| B4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Climate change - Land Use and Land Use Change relating to the Replacement module in the Use stage. | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |
| B5 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Climate change - Land Use and Land Use Change relating to the Refurbishment module in the Use stage. | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |
| B6 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Climate change - Land Use and Land Use Change relating to the Operational Energy Use module in the Use stage. | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |
| B7 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Climate change - Land Use and Land Use Change relating to the Operational Water Use module in the Use stage. | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |
| B1toB7 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Climate change - Land Use and Land Use Change relating to the full Use Stage. | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |
| C1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Climate change - Land Use and Land Use Change relating to the De-construction Demolition module in the End of Life stage. | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |
| C2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Climate change - Land Use and Land Use Change relating to the Transport module in the End of Life stage. | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |
| C3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Climate change - Land Use and Land Use Change relating to the Waste Processing module in the End of Life stage. | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |
| C4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Climate change - Land Use and Land Use Change relating to the Disposal module in the End of Life stage. | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |
| C1toC4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Climate change - Land Use and Land Use Change relating to the full End of Life stage. | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |
| D | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Resulting Climate change - Land Use and Land Use Change relating to benefits and loads beyond the system boundary. | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |


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
public class ClimateChangeLandUseMaterialResult : BH.oM.LifeCycleAssessment.Results.MaterialResult,
BH.oM.LifeCycleAssessment.Results.IEnvironmentalResult,
BH.oM.Analytical.Results.IResultItem,
BH.oM.Analytical.Results.IResult,
BH.oM.Base.IObject,
System.IComparable<BH.oM.Analytical.Results.IResult>,
BH.oM.Base.IImmutable,
BH.oM.LifeCycleAssessment.ILifeCycleAssessmentPhaseData
```

Assembly: LifeCycleAssessment_oM.dll

The class is defined in C#. The class definition is available on github:

- [ClimateChangeLandUseMaterialResult.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/Results\MaterialResults\ClimateChangeLandUseMaterialResult.cs)

All history and changes of the class can be found by inspection the history.
