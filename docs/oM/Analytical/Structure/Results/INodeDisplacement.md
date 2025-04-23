---
title: INodeDisplacement
---

# Structure.Results.INodeDisplacement

Base interface for node displacements

## Interface structure

### Implemented interfaces and base types

???+ bhom "The INodeDisplacement in inheriting from the following base type(s) and implements the following interfaces:"

    -  Structure.Results.[IDisplacement](/api/oM/Analytical/Structure/Results/IDisplacement)
    -  Structure.Results.[IStructuralResult](/api/oM/Analytical/Structure/Results/IStructuralResult)
    -  Analytical.Results.[IObjectIdResult](/api/oM/Analytical/Analytical/Results/IObjectIdResult)
    -  Analytical.Results.[IResult](/api/oM/Analytical/Analytical/Results/IResult)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;Analytical.Results.[IResult](/api/oM/Analytical/Analytical/Results/IResult)&gt;
    -  Base.[IImmutable](/api/oM/Framework/Base/IImmutable)
    -  Analytical.Results.[ICasedResult](/api/oM/Analytical/Analytical/Results/ICasedResult)
    -  Analytical.Results.[ITimeStepResult](/api/oM/Analytical/Analytical/Results/ITimeStepResult)
    -  Analytical.Results.[IResultItem](/api/oM/Analytical/Analytical/Results/IResultItem)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Structure.Results.[NodeDisplacement](/api/oM/Analytical/Structure/Results/NodeDisplacement)
    - Structure.Results.[NodeModalResults](/api/oM/Analytical/Structure/Results/NodeModalResults)
    - Structure.Results.[NodeModeShape](/api/oM/Analytical/Structure/Results/NodeModeShape)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| AllIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of identifier types. This is all properties tagged with any IdentifierAttribute. | - | Results_Engine |
| ObjectIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of ObjectIdentifier types. This is all properties tagged with the ObjectIdentifierAttribute. | - | Results_Engine |
| ResultPropertyKeys | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Returns the result value carrying properties available for the result type provided. Currently only supported for IResultItem and IResultCollection&lt;IResultItem&gt; type results. | - | Results_Engine |
| RTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total resolved rotational displacement of the three components of the result. | [Angle](/api/oM/Dimensional/Quantities/Attributes/Angle) [rad] | Structure_Engine |
| ScenarioIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of Scenario types. This is all properties tagged with the ScenarioIdentifierAttribute. | - | Results_Engine |
| UTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total resolved translational displacement of the three components of the result. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Structure_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [INodeDisplacement.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Results/Nodal Results/INodeDisplacement.cs)

All history and changes of the class can be found by inspection the history.
