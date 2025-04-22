---
title: GlobalReactions
---

# Structure.Results.GlobalReactions

Total global reactions for a given Loadcase or LoadCombination.

## Class structure

### Implemented interfaces and base types

???+ bhom "The GlobalReactions in inheriting from the following base type(s) and implements the following interfaces:"

    -  Structure.Results.[StructuralGlobalResult](/api_documentation/oM/Analytical/Structure/Results/StructuralGlobalResult)
    -  Structure.Results.[IStructuralResult](/api_documentation/oM/Analytical/Structure/Results/IStructuralResult)
    -  Analytical.Results.[IObjectIdResult](/api_documentation/oM/Analytical/Analytical/Results/IObjectIdResult)
    -  Analytical.Results.[IResult](/api_documentation/oM/Analytical/Analytical/Results/IResult)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;Analytical.Results.[IResult](/api_documentation/oM/Analytical/Analytical/Results/IResult)&gt;
    -  Base.[IImmutable](/api_documentation/oM/Framework/Base/IImmutable)
    -  Analytical.Results.[ICasedResult](/api_documentation/oM/Analytical/Analytical/Results/ICasedResult)
    -  Analytical.Results.[ITimeStepResult](/api_documentation/oM/Analytical/Analytical/Results/ITimeStepResult)
    -  Analytical.Results.[IResultItem](/api_documentation/oM/Analytical/Analytical/Results/IResultItem)
    -  Structure.Results.[IReaction](/api_documentation/oM/Analytical/Structure/Results/IReaction)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| FX | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total force in the global X-direction. | [Force](/api_documentation/oM/Dimensional/Quantities/Attributes/Force) [N] |
| FY | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total force in the global Y-direction. | [Force](/api_documentation/oM/Dimensional/Quantities/Attributes/Force) [N] |
| FZ | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total force in the global Z-direction. | [Force](/api_documentation/oM/Dimensional/Quantities/Attributes/Force) [N] |
| MX | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total moment about the global X-axis. | [Moment](/api_documentation/oM/Dimensional/Quantities/Attributes/Moment) [N.m] |
| MY | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total moment about the global Y-axis. | [Moment](/api_documentation/oM/Dimensional/Quantities/Attributes/Moment) [N.m] |
| MZ | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total moment about the global Z-axis. | [Moment](/api_documentation/oM/Dimensional/Quantities/Attributes/Moment) [N.m] |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ObjectId | [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=netstandard-2.0) | Id of the structure. Unused for many results. | - |
| ResultCase | [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=netstandard-2.0) | Identifier for the Loadcase or LoadCombination that the result belongs to. Is generally name or number of the loadcase, depending on the analysis package. | - |
| ModeNumber | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Positive index, starting at one. Only set for cases with modal outputs such as dynamic cases. | - |
| TimeStep | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Time step for time history results. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| AllIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of identifier types. This is all properties tagged with any IdentifierAttribute. | - | Results_Engine |
| FTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the resolved reaction force of the three components of the result. | [Force](/api_documentation/oM/Dimensional/Quantities/Attributes/Force) [N] | Structure_Engine |
| MTotal | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the resolved reaction moment of the three components of the result. | [Moment](/api_documentation/oM/Dimensional/Quantities/Attributes/Moment) [N.m] | Structure_Engine |
| ObjectIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of ObjectIdentifier types. This is all properties tagged with the ObjectIdentifierAttribute. | - | Results_Engine |
| ResultPropertyKeys | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Returns the result value carrying properties available for the result type provided. Currently only supported for IResultItem and IResultCollection&lt;IResultItem&gt; type results. | - | Results_Engine |
| ScenarioIdentifierProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Gets the name of all properties of the result that are of Scenario types. This is all properties tagged with the ScenarioIdentifierAttribute. | - | Results_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [GlobalReactions.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Results/Global Results/GlobalReactions.cs)

All history and changes of the class can be found by inspection the history.
