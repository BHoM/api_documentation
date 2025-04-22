---
title: BarStress
---

# Structure.Results.BarStress

Resulting stresses in local coordinates along the bar.

## Class structure

### Implemented interfaces and base types

???+ bhom "The BarStress in inheriting from the following base type(s) and implements the following interfaces:"

    -  Structure.Results.[BarResult](/api_documentation/oM/Analytical/Structure/Results/BarResult)
    -  Structure.Results.[IStructuralResult](/api_documentation/oM/Analytical/Structure/Results/IStructuralResult)
    -  Analytical.Results.[IObjectIdResult](/api_documentation/oM/Analytical/Analytical/Results/IObjectIdResult)
    -  Analytical.Results.[IResult](/api_documentation/oM/Analytical/Analytical/Results/IResult)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;Analytical.Results.[IResult](/api_documentation/oM/Analytical/Analytical/Results/IResult)&gt;
    -  Base.[IImmutable](/api_documentation/oM/Framework/Base/IImmutable)
    -  Analytical.Results.[ICasedResult](/api_documentation/oM/Analytical/Analytical/Results/ICasedResult)
    -  Analytical.Results.[ITimeStepResult](/api_documentation/oM/Analytical/Analytical/Results/ITimeStepResult)
    -  Analytical.Results.[IElement1DResult](/api_documentation/oM/Analytical/Analytical/Results/IElement1DResult)
    -  Analytical.Results.[IResultItem](/api_documentation/oM/Analytical/Analytical/Results/IResultItem)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Axial | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Axial stress induced by an axial force along the Bar axis. Positive for tension, negative for compression. | [Stress](/api_documentation/oM/Dimensional/Quantities/Attributes/Stress) [Pa] |
| ShearY | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Shear stress along the local y-axis. Generally minor axis shear stress. | [Stress](/api_documentation/oM/Dimensional/Quantities/Attributes/Stress) [Pa] |
| ShearZ | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Shear stress along the local z-axis. Generally major axis shear stress. | [Stress](/api_documentation/oM/Dimensional/Quantities/Attributes/Stress) [Pa] |
| BendingY_Top | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Stress induced by bending about the local y-axis at the 'uppermost' extreme fiber. Generally the major axis bending stresses in one of the extreme fibers. | [Stress](/api_documentation/oM/Dimensional/Quantities/Attributes/Stress) [Pa] |
| BendingY_Bot | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Stress induced by bending about the local y-axis at the 'lowermost' extreme fiber. Generally the major axis bending stresses in one of the extreme fibers. | [Stress](/api_documentation/oM/Dimensional/Quantities/Attributes/Stress) [Pa] |
| BendingZ_Top | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Stress induced by bending about the local z-axis at the 'uppermost' extreme fiber. Generally the minor axis bending stresses in one of the extreme fibers. | [Stress](/api_documentation/oM/Dimensional/Quantities/Attributes/Stress) [Pa] |
| BendingZ_Bot | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Stress induced by bending about the local z-axis at the 'lowermost' extreme fiber. Generally the minor axis bending stresses in one of the extreme fibers. | [Stress](/api_documentation/oM/Dimensional/Quantities/Attributes/Stress) [Pa] |
| CombAxialBendingPos | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Worst case tensile normal stress from combined axial and bending in two directions. | [Stress](/api_documentation/oM/Dimensional/Quantities/Attributes/Stress) [Pa] |
| CombAxialBendingNeg | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Worst case compressive normal stress from combined axial and bending in two directions. | [Stress](/api_documentation/oM/Dimensional/Quantities/Attributes/Stress) [Pa] |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ObjectId | [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=netstandard-2.0) | Id of the bar that this result belongs to. When extracted from an analysis package, the object id will match the format and value used in that particular package. | - |
| ResultCase | [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable?view=netstandard-2.0) | Identifier for the Loadcase or LoadCombination that the result belongs to. Is generally name or number of the loadcase, depending on the analysis package. | - |
| ModeNumber | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Positive index, starting at one. Only set for cases with modal outputs such as dynamic cases. | - |
| TimeStep | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Time step for time history results. | - |
| Position | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Position on the bar as normalised length, i.e. 0 for start, 1 for end and 0.5 for middle. | - |
| Divisions | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | How many division points along the bar was used when extracting this result. This generally means that this many results with the same ObjectId, ResultCase and TimeStep was extracted. | - |


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

- [BarStress.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Results/Bar Results/BarStress.cs)

All history and changes of the class can be found by inspection the history.
