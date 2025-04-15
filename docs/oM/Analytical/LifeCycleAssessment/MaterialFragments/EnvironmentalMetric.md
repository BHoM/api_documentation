---
title: EnvironmentalMetric
---

# LifeCycleAssessment.MaterialFragments.EnvironmentalMetric

Base class for all environmental metrics.

## Class structure

### Implemented interfaces and base types

???+ bhom "The EnvironmentalMetric in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/om_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)
    -  LifeCycleAssessment.[ILifeCycleAssessmentPhaseData](/om_documentation/oM/Analytical/LifeCycleAssessment/ILifeCycleAssessmentPhaseData)
    -  Base.[IImmutable](/om_documentation/oM/Framework/Base/IImmutable)


### Classes inheriting from this class

???+ bhom "The following classes are inheriting from this class:"

    - LifeCycleAssessment.MaterialFragments.[AbioticDepletionFossilResourcesMetric](/om_documentation/oM/Analytical/LifeCycleAssessment/MaterialFragments/AbioticDepletionFossilResourcesMetric)
    - LifeCycleAssessment.MaterialFragments.[AbioticDepletionMineralsAndMetalsMetric](/om_documentation/oM/Analytical/LifeCycleAssessment/MaterialFragments/AbioticDepletionMineralsAndMetalsMetric)
    - LifeCycleAssessment.MaterialFragments.[AcidificationMetric](/om_documentation/oM/Analytical/LifeCycleAssessment/MaterialFragments/AcidificationMetric)
    - LifeCycleAssessment.MaterialFragments.[ClimateChangeBiogenicMetric](/om_documentation/oM/Analytical/LifeCycleAssessment/MaterialFragments/ClimateChangeBiogenicMetric)
    - LifeCycleAssessment.MaterialFragments.[ClimateChangeFossilMetric](/om_documentation/oM/Analytical/LifeCycleAssessment/MaterialFragments/ClimateChangeFossilMetric)
    - LifeCycleAssessment.MaterialFragments.[ClimateChangeLandUseMetric](/om_documentation/oM/Analytical/LifeCycleAssessment/MaterialFragments/ClimateChangeLandUseMetric)
    - LifeCycleAssessment.MaterialFragments.[ClimateChangeTotalMetric](/om_documentation/oM/Analytical/LifeCycleAssessment/MaterialFragments/ClimateChangeTotalMetric)
    - LifeCycleAssessment.MaterialFragments.[ClimateChangeTotalNoBiogenicMetric](/om_documentation/oM/Analytical/LifeCycleAssessment/MaterialFragments/ClimateChangeTotalNoBiogenicMetric)
    - LifeCycleAssessment.MaterialFragments.[EutrophicationAquaticFreshwaterMetric](/om_documentation/oM/Analytical/LifeCycleAssessment/MaterialFragments/EutrophicationAquaticFreshwaterMetric)
    - LifeCycleAssessment.MaterialFragments.[EutrophicationAquaticMarineMetric](/om_documentation/oM/Analytical/LifeCycleAssessment/MaterialFragments/EutrophicationAquaticMarineMetric)
    - LifeCycleAssessment.MaterialFragments.[EutrophicationCMLMetric](/om_documentation/oM/Analytical/LifeCycleAssessment/MaterialFragments/EutrophicationCMLMetric)
    - LifeCycleAssessment.MaterialFragments.[EutrophicationTerrestrialMetric](/om_documentation/oM/Analytical/LifeCycleAssessment/MaterialFragments/EutrophicationTerrestrialMetric)
    - LifeCycleAssessment.MaterialFragments.[EutrophicationTRACIMetric](/om_documentation/oM/Analytical/LifeCycleAssessment/MaterialFragments/EutrophicationTRACIMetric)
    - LifeCycleAssessment.MaterialFragments.[OzoneDepletionMetric](/om_documentation/oM/Analytical/LifeCycleAssessment/MaterialFragments/OzoneDepletionMetric)
    - LifeCycleAssessment.MaterialFragments.[PhotochemicalOzoneCreationCMLMetric](/om_documentation/oM/Analytical/LifeCycleAssessment/MaterialFragments/PhotochemicalOzoneCreationCMLMetric)
    - LifeCycleAssessment.MaterialFragments.[PhotochemicalOzoneCreationMetric](/om_documentation/oM/Analytical/LifeCycleAssessment/MaterialFragments/PhotochemicalOzoneCreationMetric)
    - LifeCycleAssessment.MaterialFragments.[PhotochemicalOzoneCreationTRACIMetric](/om_documentation/oM/Analytical/LifeCycleAssessment/MaterialFragments/PhotochemicalOzoneCreationTRACIMetric)
    - LifeCycleAssessment.MaterialFragments.[WaterDeprivationMetric](/om_documentation/oM/Analytical/LifeCycleAssessment/MaterialFragments/WaterDeprivationMetric)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| MetricType | [EnvironmentalMetrics](/om_documentation/oM/Analytical/LifeCycleAssessment/EnvironmentalMetrics) | Enum indicating the metric type the object relates to. | - |
| A1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Data relating to the Raw Material Supply module in the Product stage. | - |
| A2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Data relating to the Transport module in the Product stage. | - |
| A3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Data relating to the Manufacturing module in the Product stage. | - |
| A1toA3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Data relating to the full Product stage. | - |
| A4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Data relating to the Transport module in the Construction Process stage. | - |
| A5 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Data relating to the Construction Installation Process module in the Construction Process stage. | - |
| B1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Data relating to the Use module in the Use stage. | - |
| B2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Data relating to the Maintenance module in the Use stage. | - |
| B3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Data relating to the Repair module in the Use stage. | - |
| B4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Data relating to the Replacement module in the Use stage. | - |
| B5 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Data relating to the Refurbishment module in the Use stage. | - |
| B6 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Data relating to the Operational Energy Use module in the Use stage. | - |
| B7 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Data relating to the Operational Water Use module in the Use stage. | - |
| B1toB7 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Data relating to the full Use Stage. | - |
| C1 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Data relating to the De-construction Demolition module in the End of Life stage. | - |
| C2 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Data relating to the Transport module in the End of Life stage. | - |
| C3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Data relating to the Waste Processing module in the End of Life stage. | - |
| C4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Data relating to the Disposal module in the End of Life stage. | - |
| C1toC4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Data relating to the full End of Life stage. | - |
| D | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Data relating to benefits and loads beyond the system boundary. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/om_documentation/oM/Framework/Base/FragmentSet) | - | - |
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

- [EnvironmentalMetric.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/MaterialFragments/EnvironmentalMetrics/EnvironmentalMetric.cs)

All history and changes of the class can be found by inspection the history.
