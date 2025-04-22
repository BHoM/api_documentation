---
title: IMeshResult&lt;T&gt;
---

# Analytical.Results.IMeshResult&lt;T&gt;

Base interface for any Mesh result class which is a collection of discrete MeshElementResults.

## Interface structure

### Generic parameters

The IMeshResult contains the following generic paramters:

#### T

Constrained by the following arguments:

- Analytical.Results.[IMeshElementResult](/api_documentation/oM/Analytical/Analytical/Results/IMeshElementResult)

### Implemented interfaces and base types

???+ bhom "The IMeshResult`1 in inheriting from the following base type(s) and implements the following interfaces:"

    -  Analytical.Results.[IObjectIdResult](/api_documentation/oM/Analytical/Analytical/Results/IObjectIdResult)
    -  Analytical.Results.[IResult](/api_documentation/oM/Analytical/Analytical/Results/IResult)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;Analytical.Results.[IResult](/api_documentation/oM/Analytical/Analytical/Results/IResult)&gt;
    -  Base.[IImmutable](/api_documentation/oM/Framework/Base/IImmutable)
    -  Analytical.Results.[IResultCollection](/api_documentation/oM/Analytical/Analytical/Results/IResultCollection%601)&lt;[T](/api_documentation/oM/Analytical/Analytical/Results/IResultCollection%601#t)&gt;


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Lighting.Results.Mesh.[MeshResult](/api_documentation/oM/Analytical/Lighting/Results/Mesh/MeshResult)
    - Structure.Results.[MeshResult](/api_documentation/oM/Analytical/Structure/Results/MeshResult)


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

- [IMeshResult.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Results\IMeshResult.cs)

All history and changes of the class can be found by inspection the history.
