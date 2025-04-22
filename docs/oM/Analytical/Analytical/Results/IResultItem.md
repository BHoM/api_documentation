---
title: IResultItem
---

# Analytical.Results.IResultItem

Base interface to flag that the result is a simple result line.
A class implementing the IResultItem interface should only contain basic properties such as doubles, ints, strings, DateTime and similar.
For instance, a class implementing this interface could be represented as a single row in a table (e.g. Excel or a SQL database) with its properties explicitly readable.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IResultItem in inheriting from the following base type(s) and implements the following interfaces:"

    -  Analytical.Results.[IResult](/api_documentation/oM/Analytical/Analytical/Results/IResult)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;Analytical.Results.[IResult](/api_documentation/oM/Analytical/Analytical/Results/IResult)&gt;
    -  Base.[IImmutable](/api_documentation/oM/Framework/Base/IImmutable)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - LifeCycleAssessment.Results.[IElementResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/IElementResult%601)&lt;[T](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/IElementResult%601#t)&gt;
    - LifeCycleAssessment.Results.[IEnvironmentalResult](/api_documentation/oM/Analytical/LifeCycleAssessment/Results/IEnvironmentalResult)
    - Structure.Results.[IBarDisplacement](/api_documentation/oM/Analytical/Structure/Results/IBarDisplacement)
    - Structure.Results.[IDisplacement](/api_documentation/oM/Analytical/Structure/Results/IDisplacement)
    - Structure.Results.[IReaction](/api_documentation/oM/Analytical/Structure/Results/IReaction)
    - Structure.Results.[IMeshDisplacement](/api_documentation/oM/Analytical/Structure/Results/IMeshDisplacement)
    - Structure.Results.[INodeDisplacement](/api_documentation/oM/Analytical/Structure/Results/INodeDisplacement)


### Classes implementing this interface

??? bhom "The following classes are implementing this interface:"

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
    - Structure.Results.[BarDeformation](/api_documentation/oM/Analytical/Structure/Results/BarDeformation)
    - Structure.Results.[BarDisplacement](/api_documentation/oM/Analytical/Structure/Results/BarDisplacement)
    - Structure.Results.[BarForce](/api_documentation/oM/Analytical/Structure/Results/BarForce)
    - Structure.Results.[BarModeShape](/api_documentation/oM/Analytical/Structure/Results/BarModeShape)
    - Structure.Results.[BarRequiredArea](/api_documentation/oM/Analytical/Structure/Results/BarRequiredArea)
    - Structure.Results.[BarStrain](/api_documentation/oM/Analytical/Structure/Results/BarStrain)
    - Structure.Results.[BarStress](/api_documentation/oM/Analytical/Structure/Results/BarStress)
    - Structure.Results.[CompositeUtilisation](/api_documentation/oM/Analytical/Structure/Results/CompositeUtilisation)
    - Structure.Results.[SteelUtilisation](/api_documentation/oM/Analytical/Structure/Results/SteelUtilisation)
    - Structure.Results.[GlobalReactions](/api_documentation/oM/Analytical/Structure/Results/GlobalReactions)
    - Structure.Results.[ModalDynamics](/api_documentation/oM/Analytical/Structure/Results/ModalDynamics)
    - Structure.Results.[ModalMassAndFrequency](/api_documentation/oM/Analytical/Structure/Results/ModalMassAndFrequency)
    - Structure.Results.[StoreyDrift](/api_documentation/oM/Analytical/Structure/Results/StoreyDrift)
    - Structure.Results.[StructuralGlobalResult](/api_documentation/oM/Analytical/Structure/Results/StructuralGlobalResult)
    - Structure.Results.[MeshDisplacement](/api_documentation/oM/Analytical/Structure/Results/MeshDisplacement)
    - Structure.Results.[MeshForce](/api_documentation/oM/Analytical/Structure/Results/MeshForce)
    - Structure.Results.[MeshModeShape](/api_documentation/oM/Analytical/Structure/Results/MeshModeShape)
    - Structure.Results.[MeshRequiredArea](/api_documentation/oM/Analytical/Structure/Results/MeshRequiredArea)
    - Structure.Results.[MeshStress](/api_documentation/oM/Analytical/Structure/Results/MeshStress)
    - Structure.Results.[MeshVonMises](/api_documentation/oM/Analytical/Structure/Results/MeshVonMises)
    - Structure.Results.[NodeAcceleration](/api_documentation/oM/Analytical/Structure/Results/NodeAcceleration)
    - Structure.Results.[NodeDisplacement](/api_documentation/oM/Analytical/Structure/Results/NodeDisplacement)
    - Structure.Results.[NodeModalMass](/api_documentation/oM/Analytical/Structure/Results/NodeModalMass)
    - Structure.Results.[NodeModalResults](/api_documentation/oM/Analytical/Structure/Results/NodeModalResults)
    - Structure.Results.[NodeModeShape](/api_documentation/oM/Analytical/Structure/Results/NodeModeShape)
    - Structure.Results.[NodeReaction](/api_documentation/oM/Analytical/Structure/Results/NodeReaction)
    - Structure.Results.[NodeVelocity](/api_documentation/oM/Analytical/Structure/Results/NodeVelocity)


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

- [IResultItem.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Results\IResultItem.cs)

All history and changes of the class can be found by inspection the history.
