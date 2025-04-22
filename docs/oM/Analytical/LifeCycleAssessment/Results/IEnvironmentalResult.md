---
title: IEnvironmentalResult
---

# LifeCycleAssessment.Results.IEnvironmentalResult

Base interface for all Life Cycle Assessment results.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IEnvironmentalResult in inheriting from the following base type(s) and implements the following interfaces:"

    -  Analytical.Results.[IResultItem](/api_documentation/oM/Analytical/Analytical/Results/IResultItem)
    -  Analytical.Results.[IResult](/api_documentation/oM/Analytical/Analytical/Results/IResult)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;Analytical.Results.[IResult](/api_documentation/oM/Analytical/Analytical/Results/IResult)&gt;
    -  Base.[IImmutable](/api_documentation/oM/Framework/Base/IImmutable)
    -  LifeCycleAssessment.[ILifeCycleAssessmentPhaseData](/api_documentation/oM/Analytical/LifeCycleAssessment/ILifeCycleAssessmentPhaseData)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - LifeCycleAssessment.Results.[IElementResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/IElementResult%601)&lt;[T](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/IElementResult%601#t)&gt;


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - LifeCycleAssessment.Results.[AbioticDepletionFossilResourcesElementResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/AbioticDepletionFossilResourcesElementResult)
    - LifeCycleAssessment.Results.[AbioticDepletionMineralsAndMetalsElementResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/AbioticDepletionMineralsAndMetalsElementResult)
    - LifeCycleAssessment.Results.[AcidificationElementResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/AcidificationElementResult)
    - LifeCycleAssessment.Results.[ClimateChangeBiogenicElementResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeBiogenicElementResult)
    - LifeCycleAssessment.Results.[ClimateChangeFossilElementResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeFossilElementResult)
    - LifeCycleAssessment.Results.[ClimateChangeLandUseElementResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeLandUseElementResult)
    - LifeCycleAssessment.Results.[ClimateChangeTotalElementResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeTotalElementResult)
    - LifeCycleAssessment.Results.[ClimateChangeTotalNoBiogenicElementResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeTotalNoBiogenicElementResult)
    - LifeCycleAssessment.Results.[ElementResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/ElementResult%601)&lt;[T](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/ElementResult%601#t)&gt;
    - LifeCycleAssessment.Results.[EutrophicationAquaticFreshwaterElementResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/EutrophicationAquaticFreshwaterElementResult)
    - LifeCycleAssessment.Results.[EutrophicationAquaticMarineElementResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/EutrophicationAquaticMarineElementResult)
    - LifeCycleAssessment.Results.[EutrophicationCMLElementResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/EutrophicationCMLElementResult)
    - LifeCycleAssessment.Results.[EutrophicationTerrestrialElementResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/EutrophicationTerrestrialElementResult)
    - LifeCycleAssessment.Results.[EutrophicationTRACIElementResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/EutrophicationTRACIElementResult)
    - LifeCycleAssessment.Results.[OzoneDepletionElementResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/OzoneDepletionElementResult)
    - LifeCycleAssessment.Results.[PhotochemicalOzoneCreationCMLElementResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/PhotochemicalOzoneCreationCMLElementResult)
    - LifeCycleAssessment.Results.[PhotochemicalOzoneCreationElementResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/PhotochemicalOzoneCreationElementResult)
    - LifeCycleAssessment.Results.[PhotochemicalOzoneCreationTRACIElementResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/PhotochemicalOzoneCreationTRACIElementResult)
    - LifeCycleAssessment.Results.[WaterDeprivationElementResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/WaterDeprivationElementResult)
    - LifeCycleAssessment.Results.[AbioticDepletionFossilResourcesMaterialResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/AbioticDepletionFossilResourcesMaterialResult)
    - LifeCycleAssessment.Results.[AbioticDepletionMineralsAndMetalsMaterialResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/AbioticDepletionMineralsAndMetalsMaterialResult)
    - LifeCycleAssessment.Results.[AcidificationMaterialResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/AcidificationMaterialResult)
    - LifeCycleAssessment.Results.[ClimateChangeBiogenicMaterialResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeBiogenicMaterialResult)
    - LifeCycleAssessment.Results.[ClimateChangeFossilMaterialResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeFossilMaterialResult)
    - LifeCycleAssessment.Results.[ClimateChangeLandUseMaterialResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeLandUseMaterialResult)
    - LifeCycleAssessment.Results.[ClimateChangeTotalMaterialResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeTotalMaterialResult)
    - LifeCycleAssessment.Results.[ClimateChangeTotalNoBiogenicMaterialResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeTotalNoBiogenicMaterialResult)
    - LifeCycleAssessment.Results.[EutrophicationAquaticFreshwaterMaterialResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/EutrophicationAquaticFreshwaterMaterialResult)
    - LifeCycleAssessment.Results.[EutrophicationAquaticMarineMaterialResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/EutrophicationAquaticMarineMaterialResult)
    - LifeCycleAssessment.Results.[EutrophicationCMLMaterialResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/EutrophicationCMLMaterialResult)
    - LifeCycleAssessment.Results.[EutrophicationTerrestrialMaterialResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/EutrophicationTerrestrialMaterialResult)
    - LifeCycleAssessment.Results.[EutrophicationTRACIMaterialResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/EutrophicationTRACIMaterialResult)
    - LifeCycleAssessment.Results.[MaterialResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/MaterialResult)
    - LifeCycleAssessment.Results.[OzoneDepletionMaterialResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/OzoneDepletionMaterialResult)
    - LifeCycleAssessment.Results.[PhotochemicalOzoneCreationCMLMaterialResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/PhotochemicalOzoneCreationCMLMaterialResult)
    - LifeCycleAssessment.Results.[PhotochemicalOzoneCreationMaterialResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/PhotochemicalOzoneCreationMaterialResult)
    - LifeCycleAssessment.Results.[PhotochemicalOzoneCreationTRACIMaterialResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/PhotochemicalOzoneCreationTRACIMaterialResult)
    - LifeCycleAssessment.Results.[WaterDeprivationMaterialResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/WaterDeprivationMaterialResult)


## Properties

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

The interface is defined in C#. The class definition is available on github:

- [IEnvironmentalResult.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/Results\IEnvironmentalResult.cs)

All history and changes of the class can be found by inspection the history.
