---
title: ICasedResult
---

# Analytical.Results.ICasedResult

Interface for results that correspond to a particular case.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ICasedResult in inheriting from the following base type(s) and implements the following interfaces:"

    -  Analytical.Results.[IResult](/api/oM/Analytical/Analytical/Results/IResult)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;Analytical.Results.[IResult](/api/oM/Analytical/Analytical/Results/IResult)&gt;
    -  Base.[IImmutable](/api/oM/Framework/Base/IImmutable)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Structure.Results.[IBarDisplacement](/api/oM/Analytical/Structure/Results/IBarDisplacement)
    - Structure.Results.[IDisplacement](/api/oM/Analytical/Structure/Results/IDisplacement)
    - Structure.Results.[IReaction](/api/oM/Analytical/Structure/Results/IReaction)
    - Structure.Results.[IStructuralResult](/api/oM/Analytical/Structure/Results/IStructuralResult)
    - Structure.Results.[IMeshDisplacement](/api/oM/Analytical/Structure/Results/IMeshDisplacement)
    - Structure.Results.[INodeDisplacement](/api/oM/Analytical/Structure/Results/INodeDisplacement)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

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
    - Lighting.Results.Mesh.[MeshElementResult](/api/oM/Analytical/Lighting/Results/Mesh/MeshElementResult)
    - Lighting.Results.Mesh.[MeshResult](/api/oM/Analytical/Lighting/Results/Mesh/MeshResult)
    - Lighting.Results.Illuminance.[Lux](/api/oM/Analytical/Lighting/Results/Illuminance/Lux)
    - Adapters.SAP2000.Results.[AISCSteelUtilisation](/api/oM/Adapter/Adapters/SAP2000/Results/AISCSteelUtilisation)
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
    - Test.Results.[InputOutputComparisonDiffing](/api/oM/Framework/Test/Results/InputOutputComparisonDiffing)
    - Test.Results.[InputOutputComparisonSummary](/api/oM/Framework/Test/Results/InputOutputComparisonSummary)
    - Test.Results.[InputOutputDifference](/api/oM/Framework/Test/Results/InputOutputDifference)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ResultCase | [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=netstandard-2.0) | The identifier for the case analysed that generated the result. | - |


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

- [ICasedResult.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Results\ICasedResult.cs)

All history and changes of the class can be found by inspection the history.
