---
title: EutrophicationCMLMetric
---

# LifeCycleAssessment.MaterialFragments.EutrophicationCMLMetric

Eutrophication (refers to EN 15804+A1), measured in kg [PO₄]³⁻ eq, and refers to the natural process that results from accumulation of nutrients. This environmental indicator forms part of an Environmental Product Declaration and should be evaluated based on the Quantity Type stated on the Environmental Product Declaration.

## Class structure

### Implemented interfaces and base types

???+ bhom "The EutrophicationCMLMetric in inheriting from the following base type(s) and implements the following interfaces:"

    -  LifeCycleAssessment.MaterialFragments.[EnvironmentalMetric](/api_documentation/oM/Analytical/LifeCycleAssessment/MaterialFragments/EnvironmentalMetric)
    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  LifeCycleAssessment.[ILifeCycleAssessmentPhaseData](/api_documentation/oM/Analytical/LifeCycleAssessment/ILifeCycleAssessmentPhaseData)
    -  Base.[IImmutable](/api_documentation/oM/Framework/Base/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| A1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Eutrophication (EN 15804+A1) relating to the Raw Material Supply module in the Product stage. | [EutrophicationCMLPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity) [kg [PO₄]³⁻ eq per unit] |
| A2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Eutrophication (EN 15804+A1) relating to the Transport module in the Product stage. | [EutrophicationCMLPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity) [kg [PO₄]³⁻ eq per unit] |
| A3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Eutrophication (EN 15804+A1) relating to the Manufacturing module in the Product stage. | [EutrophicationCMLPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity) [kg [PO₄]³⁻ eq per unit] |
| A1toA3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Eutrophication (EN 15804+A1) relating to the full Product stage. | [EutrophicationCMLPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity) [kg [PO₄]³⁻ eq per unit] |
| A4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Eutrophication (EN 15804+A1) relating to the Transport module in the Construction Process stage. | [EutrophicationCMLPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity) [kg [PO₄]³⁻ eq per unit] |
| A5 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Eutrophication (EN 15804+A1) relating to the Construction Installation Process module in the Construction Process stage. | [EutrophicationCMLPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity) [kg [PO₄]³⁻ eq per unit] |
| B1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Eutrophication (EN 15804+A1) relating to the Use module in the Use stage. | [EutrophicationCMLPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity) [kg [PO₄]³⁻ eq per unit] |
| B2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Eutrophication (EN 15804+A1) relating to the Maintenance module in the Use stage. | [EutrophicationCMLPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity) [kg [PO₄]³⁻ eq per unit] |
| B3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Eutrophication (EN 15804+A1) relating to the Repair module in the Use stage. | [EutrophicationCMLPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity) [kg [PO₄]³⁻ eq per unit] |
| B4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Eutrophication (EN 15804+A1) relating to the Replacement module in the Use stage. | [EutrophicationCMLPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity) [kg [PO₄]³⁻ eq per unit] |
| B5 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Eutrophication (EN 15804+A1) relating to the Refurbishment module in the Use stage. | [EutrophicationCMLPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity) [kg [PO₄]³⁻ eq per unit] |
| B6 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Eutrophication (EN 15804+A1) relating to the Operational Energy Use module in the Use stage. | [EutrophicationCMLPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity) [kg [PO₄]³⁻ eq per unit] |
| B7 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Eutrophication (EN 15804+A1) relating to the Operational Water Use module in the Use stage. | [EutrophicationCMLPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity) [kg [PO₄]³⁻ eq per unit] |
| B1toB7 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Eutrophication (EN 15804+A1) relating to the full Use Stage. | [EutrophicationCMLPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity) [kg [PO₄]³⁻ eq per unit] |
| C1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Eutrophication (EN 15804+A1) relating to the De-construction Demolition module in the End of Life stage. | [EutrophicationCMLPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity) [kg [PO₄]³⁻ eq per unit] |
| C2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Eutrophication (EN 15804+A1) relating to the Transport module in the End of Life stage. | [EutrophicationCMLPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity) [kg [PO₄]³⁻ eq per unit] |
| C3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Eutrophication (EN 15804+A1) relating to the Waste Processing module in the End of Life stage. | [EutrophicationCMLPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity) [kg [PO₄]³⁻ eq per unit] |
| C4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Eutrophication (EN 15804+A1) relating to the Disposal module in the End of Life stage. | [EutrophicationCMLPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity) [kg [PO₄]³⁻ eq per unit] |
| C1toC4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Eutrophication (EN 15804+A1) relating to the full End of Life stage. | [EutrophicationCMLPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity) [kg [PO₄]³⁻ eq per unit] |
| D | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Eutrophication (EN 15804+A1) relating to benefits and loads beyond the system boundary. | [EutrophicationCMLPerQuantity](/api_documentation/oM/Dimensional/Quantities/Attributes/EutrophicationCMLPerQuantity) [kg [PO₄]³⁻ eq per unit] |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| MetricType | [EnvironmentalMetrics](/api_documentation/oM/Analytical/LifeCycleAssessment/EnvironmentalMetrics) | Enum indicating the metric type the object relates to. | - |
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
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

The class is defined in C#. The class definition is available on github:

- [EutrophicationCMLMetric.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/MaterialFragments/EnvironmentalMetrics/EutrophicationCMLMetric.cs)

All history and changes of the class can be found by inspection the history.
