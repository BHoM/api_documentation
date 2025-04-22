---
title: IResultCollection&lt;T&gt;
---

# Analytical.Results.IResultCollection&lt;T&gt;

Base interface for results classes that are a collection of individual results, for example IMeshResults.

## Interface structure

### Generic parameters

The IResultCollection contains the following generic paramters:

#### T

Constrained by the following arguments:

- Analytical.Results.[IResult](/api_documentation/oM/Analytical/Analytical/Results/IResult)

### Implemented interfaces and base types

???+ bhom "The IResultCollection`1 in inheriting from the following base type(s) and implements the following interfaces:"

    -  Analytical.Results.[IResult](/api_documentation/oM/Analytical/Analytical/Results/IResult)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;Analytical.Results.[IResult](/api_documentation/oM/Analytical/Analytical/Results/IResult)&gt;
    -  Base.[IImmutable](/api_documentation/oM/Framework/Base/IImmutable)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Analytical.Results.[IMeshResult](/api_documentation/oM/Analytical/Analytical/Results/IMeshResult%601)&lt;[T](/api_documentation/oM/Analytical/Analytical/Results/IMeshResult%601#t)&gt;


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Environment.Results.Mesh.[MeshResult](/api_documentation/oM/Analytical/Environment/Results/Mesh/MeshResult)
    - Lighting.Results.Mesh.[MeshResult](/api_documentation/oM/Analytical/Lighting/Results/Mesh/MeshResult)
    - Structure.Results.[MeshResult](/api_documentation/oM/Analytical/Structure/Results/MeshResult)
    - Test.Results.[InputOutputComparison](/api_documentation/oM/Framework/Test/Results/InputOutputComparison)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Results | [IReadOnlyList](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1?view=netstandard-2.0)&lt;[T](#t)&gt; | - | - |


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

- [IResultCollection.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Results\IResultCollection.cs)

All history and changes of the class can be found by inspection the history.
