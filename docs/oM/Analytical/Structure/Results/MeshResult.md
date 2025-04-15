---
title: MeshResult
---

# Structure.Results.MeshResult

Full collection of discrete results for a Panel/FEMesh for a specific Loadcase or LoadCombination.

## Class structure

### Implemented interfaces and base types

???+ bhom "The MeshResult in inheriting from the following base type(s) and implements the following interfaces:"

    -  Analytical.Results.[IMeshResult](/om_documentation/oM/Analytical/Analytical/Results/IMeshResult%601)&lt;Structure.Results.[MeshElementResult](/om_documentation/oM/Analytical/Structure/Results/MeshElementResult)&gt;
    -  Analytical.Results.[IObjectIdResult](/om_documentation/oM/Analytical/Analytical/Results/IObjectIdResult)
    -  Analytical.Results.[IResult](/om_documentation/oM/Analytical/Analytical/Results/IResult)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;Analytical.Results.[IResult](/om_documentation/oM/Analytical/Analytical/Results/IResult)&gt;
    -  Base.[IImmutable](/om_documentation/oM/Framework/Base/IImmutable)
    -  Analytical.Results.[IResultCollection](/om_documentation/oM/Analytical/Analytical/Results/IResultCollection%601)&lt;Structure.Results.[MeshElementResult](/om_documentation/oM/Analytical/Structure/Results/MeshElementResult)&gt;
    -  Structure.Results.[IStructuralResult](/om_documentation/oM/Analytical/Structure/Results/IStructuralResult)
    -  Analytical.Results.[ICasedResult](/om_documentation/oM/Analytical/Analytical/Results/ICasedResult)
    -  Analytical.Results.[ITimeStepResult](/om_documentation/oM/Analytical/Analytical/Results/ITimeStepResult)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ObjectId | [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=netstandard-2.0) | Id of the mesh that this result collection belongs to. When extracted from an analysis package, the object id will match the format and value used in that particular package. | - |
| ResultCase | [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=netstandard-2.0) | Identifier for the Loadcase or LoadCombination that the result belongs to. Is generally name or number of the loadcase, depending on the analysis package. | - |
| ModeNumber | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Positive index, starting at one. Only set for cases with modal outputs such as dynamic cases. | - |
| TimeStep | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Time step for time history results. | - |
| Layer | [MeshResultLayer](/om_documentation/oM/Analytical/Structure/Results/MeshResultLayer) | - | - |
| LayerPosition | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Position within the element thickness that result is extracted from, normalised to 1. I.e. 0 = lower surface, 0.5 = middle, 1 = top surface. | - |
| Smoothing | [MeshResultSmoothingType](/om_documentation/oM/Analytical/Structure/Results/MeshResultSmoothingType) | - | - |
| Results | [IReadOnlyList](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1?view=netstandard-2.0)&lt;[MeshElementResult](/om_documentation/oM/Analytical/Structure/Results/MeshElementResult)&gt; | A collection of the discrete mesh element results per node and/or face. | - |


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

The class is defined in C#. The class definition is available on github:

- [MeshResult.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Results/Mesh/MeshResult.cs)

All history and changes of the class can be found by inspection the history.
