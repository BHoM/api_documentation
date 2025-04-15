---
title: IResult
---

# Analytical.Results.IResult

Base interface for all analytical results.
For expanded functionality, a result class should generally either implement the IResultItem or IResultCollection interface, or one of their sub-interfaces, rather than this interface directly.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IResult in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;Analytical.Results.[IResult](/om_documentation/oM/Analytical/Analytical/Results/IResult)&gt;
    -  Base.[IImmutable](/om_documentation/oM/Framework/Base/IImmutable)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Analytical.Results.[ICasedResult](/om_documentation/oM/Analytical/Analytical/Results/ICasedResult)
    - Analytical.Results.[IElement1DResult](/om_documentation/oM/Analytical/Analytical/Results/IElement1DResult)
    - Analytical.Results.[IMeshElementResult](/om_documentation/oM/Analytical/Analytical/Results/IMeshElementResult)
    - Analytical.Results.[IMeshResult](/om_documentation/oM/Analytical/Analytical/Results/IMeshResult%601)&lt;[T](/om_documentation/oM/Analytical/Analytical/Results/IMeshResult%601#t)&gt;
    - Analytical.Results.[IObjectIdResult](/om_documentation/oM/Analytical/Analytical/Results/IObjectIdResult)
    - Analytical.Results.[IObjectResult](/om_documentation/oM/Analytical/Analytical/Results/IObjectResult)
    - Analytical.Results.[IResultCollection](/om_documentation/oM/Analytical/Analytical/Results/IResultCollection%601)&lt;[T](/om_documentation/oM/Analytical/Analytical/Results/IResultCollection%601#t)&gt;
    - Analytical.Results.[IResultItem](/om_documentation/oM/Analytical/Analytical/Results/IResultItem)
    - Analytical.Results.[IResultSeries](/om_documentation/oM/Analytical/Analytical/Results/IResultSeries)
    - Analytical.Results.[ITimeStepResult](/om_documentation/oM/Analytical/Analytical/Results/ITimeStepResult)
    - LifeCycleAssessment.Results.[IElementResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/IElementResult%601)&lt;[T](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/IElementResult%601#t)&gt;
    - LifeCycleAssessment.Results.[IEnvironmentalResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/IEnvironmentalResult)
    - Structure.Results.[IBarDisplacement](/om_documentation/oM/Analytical/Structure/Results/IBarDisplacement)
    - Structure.Results.[IDisplacement](/om_documentation/oM/Analytical/Structure/Results/IDisplacement)
    - Structure.Results.[IReaction](/om_documentation/oM/Analytical/Structure/Results/IReaction)
    - Structure.Results.[IStructuralResult](/om_documentation/oM/Analytical/Structure/Results/IStructuralResult)
    - Structure.Results.[IMeshDisplacement](/om_documentation/oM/Analytical/Structure/Results/IMeshDisplacement)
    - Structure.Results.[INodeDisplacement](/om_documentation/oM/Analytical/Structure/Results/INodeDisplacement)


### Classes implementing this interface

??? bhom "The following classes are implementing this interface:"

    - Analytical.Elements.[ShortestPathResult](/om_documentation/oM/Analytical/Analytical/Elements/ShortestPathResult)
    - Environment.Results.Mesh.[MeshElementResult](/om_documentation/oM/Analytical/Environment/Results/Mesh/MeshElementResult)
    - Environment.Results.Mesh.[MeshResult](/om_documentation/oM/Analytical/Environment/Results/Mesh/MeshResult)
    - Environment.Results.Illuminance.[Lux](/om_documentation/oM/Analytical/Environment/Results/Illuminance/Lux)
    - Adapters.ETABS.Results.[SpandrelForce](/om_documentation/oM/Adapter/Adapters/ETABS/Results/SpandrelForce)
    - Adapters.ETABS.Results.[PierForce](/om_documentation/oM/Adapter/Adapters/ETABS/Results/PierForce)
    - Humans.ViewQuality.[Avalue](/om_documentation/oM/Physical/Humans/ViewQuality/Avalue)
    - Humans.ViewQuality.[Cvalue](/om_documentation/oM/Physical/Humans/ViewQuality/Cvalue)
    - Humans.ViewQuality.[Evalue](/om_documentation/oM/Physical/Humans/ViewQuality/Evalue)
    - Humans.ViewQuality.[ViewQualityResult](/om_documentation/oM/Physical/Humans/ViewQuality/ViewQualityResult)
    - LifeCycleAssessment.Results.[AbioticDepletionFossilResourcesElementResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/AbioticDepletionFossilResourcesElementResult)
    - LifeCycleAssessment.Results.[AbioticDepletionMineralsAndMetalsElementResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/AbioticDepletionMineralsAndMetalsElementResult)
    - LifeCycleAssessment.Results.[AcidificationElementResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/AcidificationElementResult)
    - LifeCycleAssessment.Results.[ClimateChangeBiogenicElementResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeBiogenicElementResult)
    - LifeCycleAssessment.Results.[ClimateChangeFossilElementResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeFossilElementResult)
    - LifeCycleAssessment.Results.[ClimateChangeLandUseElementResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeLandUseElementResult)
    - LifeCycleAssessment.Results.[ClimateChangeTotalElementResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeTotalElementResult)
    - LifeCycleAssessment.Results.[ClimateChangeTotalNoBiogenicElementResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeTotalNoBiogenicElementResult)
    - LifeCycleAssessment.Results.[ElementResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/ElementResult%601)&lt;[T](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/ElementResult%601#t)&gt;
    - LifeCycleAssessment.Results.[EutrophicationAquaticFreshwaterElementResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/EutrophicationAquaticFreshwaterElementResult)
    - LifeCycleAssessment.Results.[EutrophicationAquaticMarineElementResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/EutrophicationAquaticMarineElementResult)
    - LifeCycleAssessment.Results.[EutrophicationCMLElementResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/EutrophicationCMLElementResult)
    - LifeCycleAssessment.Results.[EutrophicationTerrestrialElementResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/EutrophicationTerrestrialElementResult)
    - LifeCycleAssessment.Results.[EutrophicationTRACIElementResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/EutrophicationTRACIElementResult)
    - LifeCycleAssessment.Results.[OzoneDepletionElementResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/OzoneDepletionElementResult)
    - LifeCycleAssessment.Results.[PhotochemicalOzoneCreationCMLElementResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/PhotochemicalOzoneCreationCMLElementResult)
    - LifeCycleAssessment.Results.[PhotochemicalOzoneCreationElementResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/PhotochemicalOzoneCreationElementResult)
    - LifeCycleAssessment.Results.[PhotochemicalOzoneCreationTRACIElementResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/PhotochemicalOzoneCreationTRACIElementResult)
    - LifeCycleAssessment.Results.[WaterDeprivationElementResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/WaterDeprivationElementResult)
    - LifeCycleAssessment.Results.[AbioticDepletionFossilResourcesMaterialResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/AbioticDepletionFossilResourcesMaterialResult)
    - LifeCycleAssessment.Results.[AbioticDepletionMineralsAndMetalsMaterialResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/AbioticDepletionMineralsAndMetalsMaterialResult)
    - LifeCycleAssessment.Results.[AcidificationMaterialResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/AcidificationMaterialResult)
    - LifeCycleAssessment.Results.[ClimateChangeBiogenicMaterialResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeBiogenicMaterialResult)
    - LifeCycleAssessment.Results.[ClimateChangeFossilMaterialResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeFossilMaterialResult)
    - LifeCycleAssessment.Results.[ClimateChangeLandUseMaterialResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeLandUseMaterialResult)
    - LifeCycleAssessment.Results.[ClimateChangeTotalMaterialResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeTotalMaterialResult)
    - LifeCycleAssessment.Results.[ClimateChangeTotalNoBiogenicMaterialResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/ClimateChangeTotalNoBiogenicMaterialResult)
    - LifeCycleAssessment.Results.[EutrophicationAquaticFreshwaterMaterialResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/EutrophicationAquaticFreshwaterMaterialResult)
    - LifeCycleAssessment.Results.[EutrophicationAquaticMarineMaterialResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/EutrophicationAquaticMarineMaterialResult)
    - LifeCycleAssessment.Results.[EutrophicationCMLMaterialResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/EutrophicationCMLMaterialResult)
    - LifeCycleAssessment.Results.[EutrophicationTerrestrialMaterialResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/EutrophicationTerrestrialMaterialResult)
    - LifeCycleAssessment.Results.[EutrophicationTRACIMaterialResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/EutrophicationTRACIMaterialResult)
    - LifeCycleAssessment.Results.[MaterialResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/MaterialResult)
    - LifeCycleAssessment.Results.[OzoneDepletionMaterialResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/OzoneDepletionMaterialResult)
    - LifeCycleAssessment.Results.[PhotochemicalOzoneCreationCMLMaterialResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/PhotochemicalOzoneCreationCMLMaterialResult)
    - LifeCycleAssessment.Results.[PhotochemicalOzoneCreationMaterialResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/PhotochemicalOzoneCreationMaterialResult)
    - LifeCycleAssessment.Results.[PhotochemicalOzoneCreationTRACIMaterialResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/PhotochemicalOzoneCreationTRACIMaterialResult)
    - LifeCycleAssessment.Results.[WaterDeprivationMaterialResult](/om_documentation/oM/Analytical/LifeCycleAssessment/Results/WaterDeprivationMaterialResult)
    - Lighting.Results.Mesh.[MeshElementResult](/om_documentation/oM/Analytical/Lighting/Results/Mesh/MeshElementResult)
    - Lighting.Results.Mesh.[MeshResult](/om_documentation/oM/Analytical/Lighting/Results/Mesh/MeshResult)
    - Lighting.Results.Illuminance.[Lux](/om_documentation/oM/Analytical/Lighting/Results/Illuminance/Lux)
    - Adapters.SAP2000.Results.[AISCSteelUtilisation](/om_documentation/oM/Adapter/Adapters/SAP2000/Results/AISCSteelUtilisation)
    - Search.[SearchResult](/om_documentation/oM/Framework/Search/SearchResult%601)&lt;[T](/om_documentation/oM/Framework/Search/SearchResult%601#t)&gt;
    - Structure.Results.[BarDeformation](/om_documentation/oM/Analytical/Structure/Results/BarDeformation)
    - Structure.Results.[BarDisplacement](/om_documentation/oM/Analytical/Structure/Results/BarDisplacement)
    - Structure.Results.[BarForce](/om_documentation/oM/Analytical/Structure/Results/BarForce)
    - Structure.Results.[BarModeShape](/om_documentation/oM/Analytical/Structure/Results/BarModeShape)
    - Structure.Results.[BarRequiredArea](/om_documentation/oM/Analytical/Structure/Results/BarRequiredArea)
    - Structure.Results.[BarResult](/om_documentation/oM/Analytical/Structure/Results/BarResult)
    - Structure.Results.[BarStrain](/om_documentation/oM/Analytical/Structure/Results/BarStrain)
    - Structure.Results.[BarStress](/om_documentation/oM/Analytical/Structure/Results/BarStress)
    - Structure.Results.[CompositeUtilisation](/om_documentation/oM/Analytical/Structure/Results/CompositeUtilisation)
    - Structure.Results.[SteelUtilisation](/om_documentation/oM/Analytical/Structure/Results/SteelUtilisation)
    - Structure.Results.[GlobalReactions](/om_documentation/oM/Analytical/Structure/Results/GlobalReactions)
    - Structure.Results.[ModalDynamics](/om_documentation/oM/Analytical/Structure/Results/ModalDynamics)
    - Structure.Results.[ModalMassAndFrequency](/om_documentation/oM/Analytical/Structure/Results/ModalMassAndFrequency)
    - Structure.Results.[StoreyDrift](/om_documentation/oM/Analytical/Structure/Results/StoreyDrift)
    - Structure.Results.[StructuralGlobalResult](/om_documentation/oM/Analytical/Structure/Results/StructuralGlobalResult)
    - Structure.Results.[MeshDisplacement](/om_documentation/oM/Analytical/Structure/Results/MeshDisplacement)
    - Structure.Results.[MeshElementResult](/om_documentation/oM/Analytical/Structure/Results/MeshElementResult)
    - Structure.Results.[MeshForce](/om_documentation/oM/Analytical/Structure/Results/MeshForce)
    - Structure.Results.[MeshModeShape](/om_documentation/oM/Analytical/Structure/Results/MeshModeShape)
    - Structure.Results.[MeshRequiredArea](/om_documentation/oM/Analytical/Structure/Results/MeshRequiredArea)
    - Structure.Results.[MeshResult](/om_documentation/oM/Analytical/Structure/Results/MeshResult)
    - Structure.Results.[MeshStress](/om_documentation/oM/Analytical/Structure/Results/MeshStress)
    - Structure.Results.[MeshVonMises](/om_documentation/oM/Analytical/Structure/Results/MeshVonMises)
    - Structure.Results.[NodeAcceleration](/om_documentation/oM/Analytical/Structure/Results/NodeAcceleration)
    - Structure.Results.[NodeDisplacement](/om_documentation/oM/Analytical/Structure/Results/NodeDisplacement)
    - Structure.Results.[NodeModalMass](/om_documentation/oM/Analytical/Structure/Results/NodeModalMass)
    - Structure.Results.[NodeModalResults](/om_documentation/oM/Analytical/Structure/Results/NodeModalResults)
    - Structure.Results.[NodeModeShape](/om_documentation/oM/Analytical/Structure/Results/NodeModeShape)
    - Structure.Results.[NodeReaction](/om_documentation/oM/Analytical/Structure/Results/NodeReaction)
    - Structure.Results.[NodeResult](/om_documentation/oM/Analytical/Structure/Results/NodeResult)
    - Structure.Results.[NodeVelocity](/om_documentation/oM/Analytical/Structure/Results/NodeVelocity)
    - Test.Results.[InputOutputComparison](/om_documentation/oM/Framework/Test/Results/InputOutputComparison)
    - Test.Results.[InputOutputComparisonDiffing](/om_documentation/oM/Framework/Test/Results/InputOutputComparisonDiffing)
    - Test.Results.[InputOutputComparisonSummary](/om_documentation/oM/Framework/Test/Results/InputOutputComparisonSummary)
    - Test.Results.[InputOutputDifference](/om_documentation/oM/Framework/Test/Results/InputOutputDifference)


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
