---
title: IResult
---

# Analytical.Results.IResult

Base interface for all analytical results.
For expanded functionality, a result class should generally either implement the IResultItem or IResultCollection interface, or one of their sub-interfaces, rather than this interface directly.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IResult in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;Analytical.Results.[IResult](/api/oM/Analytical/Analytical/Results/IResult)&gt;
    -  Base.[IImmutable](/api/oM/Framework/Base/IImmutable)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Analytical.Results.[ICasedResult](/api/oM/Analytical/Analytical/Results/ICasedResult)
    - Analytical.Results.[IElement1DResult](/api/oM/Analytical/Analytical/Results/IElement1DResult)
    - Analytical.Results.[IMeshElementResult](/api/oM/Analytical/Analytical/Results/IMeshElementResult)
    - Analytical.Results.[IMeshResult](/api/oM/Analytical/Analytical/Results/IMeshResult%601)&lt;[T](/api/oM/Analytical/Analytical/Results/IMeshResult%601#t)&gt;
    - Analytical.Results.[IObjectIdResult](/api/oM/Analytical/Analytical/Results/IObjectIdResult)
    - Analytical.Results.[IObjectResult](/api/oM/Analytical/Analytical/Results/IObjectResult)
    - Analytical.Results.[IResultCollection](/api/oM/Analytical/Analytical/Results/IResultCollection%601)&lt;[T](/api/oM/Analytical/Analytical/Results/IResultCollection%601#t)&gt;
    - Analytical.Results.[IResultItem](/api/oM/Analytical/Analytical/Results/IResultItem)
    - Analytical.Results.[IResultSeries](/api/oM/Analytical/Analytical/Results/IResultSeries)
    - Analytical.Results.[ITimeStepResult](/api/oM/Analytical/Analytical/Results/ITimeStepResult)
    - LifeCycleAssessment.Results.[IElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/IElementResult%601)&lt;[T](/api/oM/Analytical/LifeCycleAssessment/Results/IElementResult%601#t)&gt;
    - LifeCycleAssessment.Results.[IEnvironmentalResult](/api/oM/Analytical/LifeCycleAssessment/Results/IEnvironmentalResult)
    - Structure.Results.[IBarDisplacement](/api/oM/Analytical/Structure/Results/IBarDisplacement)
    - Structure.Results.[IDisplacement](/api/oM/Analytical/Structure/Results/IDisplacement)
    - Structure.Results.[IReaction](/api/oM/Analytical/Structure/Results/IReaction)
    - Structure.Results.[IStructuralResult](/api/oM/Analytical/Structure/Results/IStructuralResult)
    - Structure.Results.[IMeshDisplacement](/api/oM/Analytical/Structure/Results/IMeshDisplacement)
    - Structure.Results.[INodeDisplacement](/api/oM/Analytical/Structure/Results/INodeDisplacement)


### Classes implementing this interface

??? bhom "The following classes are implementing this interface:"

    - Analytical.Elements.[ShortestPathResult](/api/oM/Analytical/Analytical/Elements/ShortestPathResult)
    - Environment.Results.Mesh.[MeshElementResult](/api/oM/Analytical/Environment/Results/Mesh/MeshElementResult)
    - Environment.Results.Mesh.[MeshResult](/api/oM/Analytical/Environment/Results/Mesh/MeshResult)
    - Environment.Results.Illuminance.[Lux](/api/oM/Analytical/Environment/Results/Illuminance/Lux)
    - Adapters.ETABS.Results.[SpandrelForce](/api/oM/Adapter/Adapters/ETABS/Results/SpandrelForce)
    - Adapters.ETABS.Results.[PierForce](/api/oM/Adapter/Adapters/ETABS/Results/PierForce)
    - Humans.ViewQuality.[Avalue](/api/oM/Physical/Humans/ViewQuality/Avalue)
    - Humans.ViewQuality.[Cvalue](/api/oM/Physical/Humans/ViewQuality/Cvalue)
    - Humans.ViewQuality.[Evalue](/api/oM/Physical/Humans/ViewQuality/Evalue)
    - Humans.ViewQuality.[ViewQualityResult](/api/oM/Physical/Humans/ViewQuality/ViewQualityResult)
    - LifeCycleAssessment.Results.[AbioticDepletionFossilResourcesElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/AbioticDepletionFossilResourcesElementResult)
    - LifeCycleAssessment.Results.[AbioticDepletionMineralsAndMetalsElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/AbioticDepletionMineralsAndMetalsElementResult)
    - LifeCycleAssessment.Results.[AcidificationElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/AcidificationElementResult)
    - LifeCycleAssessment.Results.[ClimateChangeBiogenicElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeBiogenicElementResult)
    - LifeCycleAssessment.Results.[ClimateChangeFossilElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeFossilElementResult)
    - LifeCycleAssessment.Results.[ClimateChangeLandUseElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeLandUseElementResult)
    - LifeCycleAssessment.Results.[ClimateChangeTotalElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeTotalElementResult)
    - LifeCycleAssessment.Results.[ClimateChangeTotalNoBiogenicElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeTotalNoBiogenicElementResult)
    - LifeCycleAssessment.Results.[ElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResult%601)&lt;[T](/api/oM/Analytical/LifeCycleAssessment/Results/ElementResult%601#t)&gt;
    - LifeCycleAssessment.Results.[EutrophicationAquaticFreshwaterElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/EutrophicationAquaticFreshwaterElementResult)
    - LifeCycleAssessment.Results.[EutrophicationAquaticMarineElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/EutrophicationAquaticMarineElementResult)
    - LifeCycleAssessment.Results.[EutrophicationCMLElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/EutrophicationCMLElementResult)
    - LifeCycleAssessment.Results.[EutrophicationTerrestrialElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/EutrophicationTerrestrialElementResult)
    - LifeCycleAssessment.Results.[EutrophicationTRACIElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/EutrophicationTRACIElementResult)
    - LifeCycleAssessment.Results.[OzoneDepletionElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/OzoneDepletionElementResult)
    - LifeCycleAssessment.Results.[PhotochemicalOzoneCreationCMLElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/PhotochemicalOzoneCreationCMLElementResult)
    - LifeCycleAssessment.Results.[PhotochemicalOzoneCreationElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/PhotochemicalOzoneCreationElementResult)
    - LifeCycleAssessment.Results.[PhotochemicalOzoneCreationTRACIElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/PhotochemicalOzoneCreationTRACIElementResult)
    - LifeCycleAssessment.Results.[WaterDeprivationElementResult](/api/oM/Analytical/LifeCycleAssessment/Results/WaterDeprivationElementResult)
    - LifeCycleAssessment.Results.[AbioticDepletionFossilResourcesMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/AbioticDepletionFossilResourcesMaterialResult)
    - LifeCycleAssessment.Results.[AbioticDepletionMineralsAndMetalsMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/AbioticDepletionMineralsAndMetalsMaterialResult)
    - LifeCycleAssessment.Results.[AcidificationMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/AcidificationMaterialResult)
    - LifeCycleAssessment.Results.[ClimateChangeBiogenicMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeBiogenicMaterialResult)
    - LifeCycleAssessment.Results.[ClimateChangeFossilMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeFossilMaterialResult)
    - LifeCycleAssessment.Results.[ClimateChangeLandUseMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeLandUseMaterialResult)
    - LifeCycleAssessment.Results.[ClimateChangeTotalMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeTotalMaterialResult)
    - LifeCycleAssessment.Results.[ClimateChangeTotalNoBiogenicMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeTotalNoBiogenicMaterialResult)
    - LifeCycleAssessment.Results.[EutrophicationAquaticFreshwaterMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/EutrophicationAquaticFreshwaterMaterialResult)
    - LifeCycleAssessment.Results.[EutrophicationAquaticMarineMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/EutrophicationAquaticMarineMaterialResult)
    - LifeCycleAssessment.Results.[EutrophicationCMLMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/EutrophicationCMLMaterialResult)
    - LifeCycleAssessment.Results.[EutrophicationTerrestrialMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/EutrophicationTerrestrialMaterialResult)
    - LifeCycleAssessment.Results.[EutrophicationTRACIMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/EutrophicationTRACIMaterialResult)
    - LifeCycleAssessment.Results.[MaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/MaterialResult)
    - LifeCycleAssessment.Results.[OzoneDepletionMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/OzoneDepletionMaterialResult)
    - LifeCycleAssessment.Results.[PhotochemicalOzoneCreationCMLMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/PhotochemicalOzoneCreationCMLMaterialResult)
    - LifeCycleAssessment.Results.[PhotochemicalOzoneCreationMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/PhotochemicalOzoneCreationMaterialResult)
    - LifeCycleAssessment.Results.[PhotochemicalOzoneCreationTRACIMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/PhotochemicalOzoneCreationTRACIMaterialResult)
    - LifeCycleAssessment.Results.[WaterDeprivationMaterialResult](/api/oM/Analytical/LifeCycleAssessment/Results/WaterDeprivationMaterialResult)
    - Lighting.Results.Mesh.[MeshElementResult](/api/oM/Analytical/Lighting/Results/Mesh/MeshElementResult)
    - Lighting.Results.Mesh.[MeshResult](/api/oM/Analytical/Lighting/Results/Mesh/MeshResult)
    - Lighting.Results.Illuminance.[Lux](/api/oM/Analytical/Lighting/Results/Illuminance/Lux)
    - Adapters.SAP2000.Results.[AISCSteelUtilisation](/api/oM/Adapter/Adapters/SAP2000/Results/AISCSteelUtilisation)
    - Search.[SearchResult](/api/oM/Framework/Search/SearchResult%601)&lt;[T](/api/oM/Framework/Search/SearchResult%601#t)&gt;
    - Structure.Results.[BarDeformation](/api/oM/Analytical/Structure/Results/BarDeformation)
    - Structure.Results.[BarDisplacement](/api/oM/Analytical/Structure/Results/BarDisplacement)
    - Structure.Results.[BarForce](/api/oM/Analytical/Structure/Results/BarForce)
    - Structure.Results.[BarModeShape](/api/oM/Analytical/Structure/Results/BarModeShape)
    - Structure.Results.[BarRequiredArea](/api/oM/Analytical/Structure/Results/BarRequiredArea)
    - Structure.Results.[BarResult](/api/oM/Analytical/Structure/Results/BarResult)
    - Structure.Results.[BarStrain](/api/oM/Analytical/Structure/Results/BarStrain)
    - Structure.Results.[BarStress](/api/oM/Analytical/Structure/Results/BarStress)
    - Structure.Results.[CompositeUtilisation](/api/oM/Analytical/Structure/Results/CompositeUtilisation)
    - Structure.Results.[SteelUtilisation](/api/oM/Analytical/Structure/Results/SteelUtilisation)
    - Structure.Results.[GlobalReactions](/api/oM/Analytical/Structure/Results/GlobalReactions)
    - Structure.Results.[ModalDynamics](/api/oM/Analytical/Structure/Results/ModalDynamics)
    - Structure.Results.[ModalMassAndFrequency](/api/oM/Analytical/Structure/Results/ModalMassAndFrequency)
    - Structure.Results.[StoreyDrift](/api/oM/Analytical/Structure/Results/StoreyDrift)
    - Structure.Results.[StructuralGlobalResult](/api/oM/Analytical/Structure/Results/StructuralGlobalResult)
    - Structure.Results.[MeshDisplacement](/api/oM/Analytical/Structure/Results/MeshDisplacement)
    - Structure.Results.[MeshElementResult](/api/oM/Analytical/Structure/Results/MeshElementResult)
    - Structure.Results.[MeshForce](/api/oM/Analytical/Structure/Results/MeshForce)
    - Structure.Results.[MeshModeShape](/api/oM/Analytical/Structure/Results/MeshModeShape)
    - Structure.Results.[MeshRequiredArea](/api/oM/Analytical/Structure/Results/MeshRequiredArea)
    - Structure.Results.[MeshResult](/api/oM/Analytical/Structure/Results/MeshResult)
    - Structure.Results.[MeshStress](/api/oM/Analytical/Structure/Results/MeshStress)
    - Structure.Results.[MeshVonMises](/api/oM/Analytical/Structure/Results/MeshVonMises)
    - Structure.Results.[NodeAcceleration](/api/oM/Analytical/Structure/Results/NodeAcceleration)
    - Structure.Results.[NodeDisplacement](/api/oM/Analytical/Structure/Results/NodeDisplacement)
    - Structure.Results.[NodeModalMass](/api/oM/Analytical/Structure/Results/NodeModalMass)
    - Structure.Results.[NodeModalResults](/api/oM/Analytical/Structure/Results/NodeModalResults)
    - Structure.Results.[NodeModeShape](/api/oM/Analytical/Structure/Results/NodeModeShape)
    - Structure.Results.[NodeReaction](/api/oM/Analytical/Structure/Results/NodeReaction)
    - Structure.Results.[NodeResult](/api/oM/Analytical/Structure/Results/NodeResult)
    - Structure.Results.[NodeVelocity](/api/oM/Analytical/Structure/Results/NodeVelocity)
    - Test.Results.[InputOutputComparison](/api/oM/Framework/Test/Results/InputOutputComparison)
    - Test.Results.[InputOutputComparisonDiffing](/api/oM/Framework/Test/Results/InputOutputComparisonDiffing)
    - Test.Results.[InputOutputComparisonSummary](/api/oM/Framework/Test/Results/InputOutputComparisonSummary)
    - Test.Results.[InputOutputDifference](/api/oM/Framework/Test/Results/InputOutputDifference)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| AllIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of identifier types. This is all properties tagged with any IdentifierAttribute. | - | Results_Engine |
| ObjectIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of ObjectIdentifier types. This is all properties tagged with the ObjectIdentifierAttribute. | - | Results_Engine |
| ResultPropertyKeys | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Returns the result value carrying properties available for the result type provided. Currently only supported for IResultItem and IResultCollection&lt;IResultItem&gt; type results. | - | Results_Engine |
| ScenarioIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of Scenario types. This is all properties tagged with the ScenarioIdentifierAttribute. | - | Results_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IResult.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Results\IResult.cs)

All history and changes of the class can be found by inspection the history.
