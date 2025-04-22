---
title: IElement1DResult
---

# Analytical.Results.IElement1DResult

Base interface for results, corresponding to a discrete result at a particular position along a one-dimensional element.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IElement1DResult in inheriting from the following base type(s) and implements the following interfaces:"

    -  Analytical.Results.[IResult](/api_documentation/oM/Analytical/Analytical/Results/IResult)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;Analytical.Results.[IResult](/api_documentation/oM/Analytical/Analytical/Results/IResult)&gt;
    -  Base.[IImmutable](/api_documentation/oM/Framework/Base/IImmutable)
    -  Analytical.Results.[IObjectIdResult](/api_documentation/oM/Analytical/Analytical/Results/IObjectIdResult)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.ETABS.Results.[SpandrelForce](/api_documentation/oM/Adapter/Adapters/ETABS/Results/SpandrelForce)
    - Adapters.ETABS.Results.[PierForce](/api_documentation/oM/Adapter/Adapters/ETABS/Results/PierForce)
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


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Position | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Position on the element as normalised length, i.e. 0 for start, 1 for end and 0.5 for middle. | - |
| Divisions | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | How many division points along the element was used when extracting this result. This generally means that this many results with the same identifiers and varying Position was extracted. | - |


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

- [IElement1DResult.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Results\IElement1DResult.cs)

All history and changes of the class can be found by inspection the history.
