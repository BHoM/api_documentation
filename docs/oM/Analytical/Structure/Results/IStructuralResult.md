---
title: IStructuralResult
---

# Structure.Results.IStructuralResult

Base interface for all structural results. Adds ModeNumber as a property in addition to the one from the base IResult

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IStructuralResult in inheriting from the following base type(s) and implements the following interfaces:"

    -  Analytical.Results.[IObjectIdResult](/api/oM/Analytical/Analytical/Results/IObjectIdResult)
    -  Analytical.Results.[IResult](/api/oM/Analytical/Analytical/Results/IResult)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;Analytical.Results.[IResult](/api/oM/Analytical/Analytical/Results/IResult)&gt;
    -  Base.[IImmutable](/api/oM/Framework/Base/IImmutable)
    -  Analytical.Results.[ICasedResult](/api/oM/Analytical/Analytical/Results/ICasedResult)
    -  Analytical.Results.[ITimeStepResult](/api/oM/Analytical/Analytical/Results/ITimeStepResult)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Structure.Results.[IBarDisplacement](/api/oM/Analytical/Structure/Results/IBarDisplacement)
    - Structure.Results.[IDisplacement](/api/oM/Analytical/Structure/Results/IDisplacement)
    - Structure.Results.[IReaction](/api/oM/Analytical/Structure/Results/IReaction)
    - Structure.Results.[IMeshDisplacement](/api/oM/Analytical/Structure/Results/IMeshDisplacement)
    - Structure.Results.[INodeDisplacement](/api/oM/Analytical/Structure/Results/INodeDisplacement)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.ETABS.Results.[SpandrelForce](/api/oM/Adapter/Adapters/ETABS/Results/SpandrelForce)
    - Adapters.ETABS.Results.[PierForce](/api/oM/Adapter/Adapters/ETABS/Results/PierForce)
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


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ModeNumber | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Positive index, starting at one. Only set for cases with modal outputs such as dynamic cases. | - |


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

- [IStructuralResult.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Results\IStructuralResult.cs)

All history and changes of the class can be found by inspection the history.
