---
title: ICasedResult
---

# Analytical.Results.ICasedResult

Interface for results that correspond to a particular case.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ICasedResult in inheriting from the following base type(s) and implements the following interfaces:"

    -  Analytical.Results.[IResult](/api_documentation/oM/Analytical/Analytical/Results/IResult)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;Analytical.Results.[IResult](/api_documentation/oM/Analytical/Analytical/Results/IResult)&gt;
    -  Base.[IImmutable](/api_documentation/oM/Framework/Base/IImmutable)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Structure.Results.[IBarDisplacement](/api_documentation/oM/Analytical/Structure/Results/IBarDisplacement)
    - Structure.Results.[IDisplacement](/api_documentation/oM/Analytical/Structure/Results/IDisplacement)
    - Structure.Results.[IReaction](/api_documentation/oM/Analytical/Structure/Results/IReaction)
    - Structure.Results.[IStructuralResult](/api_documentation/oM/Analytical/Structure/Results/IStructuralResult)
    - Structure.Results.[IMeshDisplacement](/api_documentation/oM/Analytical/Structure/Results/IMeshDisplacement)
    - Structure.Results.[INodeDisplacement](/api_documentation/oM/Analytical/Structure/Results/INodeDisplacement)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Analytical.Elements.[ShortestPathResult](/api_documentation/oM/Analytical/Analytical/Elements/ShortestPathResult)
    - Environment.Results.Mesh.[MeshElementResult](/api_documentation/oM/Analytical/Environment/Results/Mesh/MeshElementResult)
    - Environment.Results.Mesh.[MeshResult](/api_documentation/oM/Analytical/Environment/Results/Mesh/MeshResult)
    - Environment.Results.Illuminance.[Lux](/api_documentation/oM/Analytical/Environment/Results/Illuminance/Lux)
    - Adapters.ETABS.Results.[SpandrelForce](/api_documentation/oM/Adapter/Adapters/ETABS/Results/SpandrelForce)
    - Adapters.ETABS.Results.[PierForce](/api_documentation/oM/Adapter/Adapters/ETABS/Results/PierForce)
    - Humans.ViewQuality.[Avalue](/api_documentation/oM/Physical/Humans/ViewQuality/Avalue)
    - Humans.ViewQuality.[Cvalue](/api_documentation/oM/Physical/Humans/ViewQuality/Cvalue)
    - Humans.ViewQuality.[Evalue](/api_documentation/oM/Physical/Humans/ViewQuality/Evalue)
    - Humans.ViewQuality.[ViewQualityResult](/api_documentation/oM/Physical/Humans/ViewQuality/ViewQualityResult)
    - Lighting.Results.Mesh.[MeshElementResult](/api_documentation/oM/Analytical/Lighting/Results/Mesh/MeshElementResult)
    - Lighting.Results.Mesh.[MeshResult](/api_documentation/oM/Analytical/Lighting/Results/Mesh/MeshResult)
    - Lighting.Results.Illuminance.[Lux](/api_documentation/oM/Analytical/Lighting/Results/Illuminance/Lux)
    - Adapters.SAP2000.Results.[AISCSteelUtilisation](/api_documentation/oM/Adapter/Adapters/SAP2000/Results/AISCSteelUtilisation)
    - Structure.Results.[BarDeformation](/api_documentation/oM/Analytical/Structure/Results/BarDeformation)
    - Structure.Results.[BarDisplacement](/api_documentation/oM/Analytical/Structure/Results/BarDisplacement)
    - Structure.Results.[BarForce](/api_documentation/oM/Analytical/Structure/Results/BarForce)
    - Structure.Results.[BarModeShape](/api_documentation/oM/Analytical/Structure/Results/BarModeShape)
    - Structure.Results.[BarRequiredArea](/api_documentation/oM/Analytical/Structure/Results/BarRequiredArea)
    - Structure.Results.[BarResult](/api_documentation/oM/Analytical/Structure/Results/BarResult)
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
    - Structure.Results.[MeshElementResult](/api_documentation/oM/Analytical/Structure/Results/MeshElementResult)
    - Structure.Results.[MeshForce](/api_documentation/oM/Analytical/Structure/Results/MeshForce)
    - Structure.Results.[MeshModeShape](/api_documentation/oM/Analytical/Structure/Results/MeshModeShape)
    - Structure.Results.[MeshRequiredArea](/api_documentation/oM/Analytical/Structure/Results/MeshRequiredArea)
    - Structure.Results.[MeshResult](/api_documentation/oM/Analytical/Structure/Results/MeshResult)
    - Structure.Results.[MeshStress](/api_documentation/oM/Analytical/Structure/Results/MeshStress)
    - Structure.Results.[MeshVonMises](/api_documentation/oM/Analytical/Structure/Results/MeshVonMises)
    - Structure.Results.[NodeAcceleration](/api_documentation/oM/Analytical/Structure/Results/NodeAcceleration)
    - Structure.Results.[NodeDisplacement](/api_documentation/oM/Analytical/Structure/Results/NodeDisplacement)
    - Structure.Results.[NodeModalMass](/api_documentation/oM/Analytical/Structure/Results/NodeModalMass)
    - Structure.Results.[NodeModalResults](/api_documentation/oM/Analytical/Structure/Results/NodeModalResults)
    - Structure.Results.[NodeModeShape](/api_documentation/oM/Analytical/Structure/Results/NodeModeShape)
    - Structure.Results.[NodeReaction](/api_documentation/oM/Analytical/Structure/Results/NodeReaction)
    - Structure.Results.[NodeResult](/api_documentation/oM/Analytical/Structure/Results/NodeResult)
    - Structure.Results.[NodeVelocity](/api_documentation/oM/Analytical/Structure/Results/NodeVelocity)
    - Test.Results.[InputOutputComparisonDiffing](/api_documentation/oM/Framework/Test/Results/InputOutputComparisonDiffing)
    - Test.Results.[InputOutputComparisonSummary](/api_documentation/oM/Framework/Test/Results/InputOutputComparisonSummary)
    - Test.Results.[InputOutputDifference](/api_documentation/oM/Framework/Test/Results/InputOutputDifference)


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
