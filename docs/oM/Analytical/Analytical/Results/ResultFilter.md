---
title: ResultFilter
---

# Analytical.Results.ResultFilter

Object to support filtering of results

## Class structure

### Implemented interfaces and base types

???+ bhom "The ResultFilter in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ResultCaseFilters | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | If ResultCaseFilters contains items, only results of type ICasedResult will be returned that has a ResultCase matching any items in the ResultCaseFilters. | - |
| ObjectIDFilters | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | If ObjectIDFilters contains items, only results of type IObjectIdResult will be returned that has a ObjectId matching any items in the ObjectIDFilters. | - |
| NodeIDFilters | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | If NodeIDFilters contains items, only results of type IMeshElementResult will be returned that has a NodeId matching any items in the NodeIDFilters. | - |
| MeshFaceIDFilters | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | If MeshFaceIDFilters contains items, only results of type IMeshElementResult will be returned that has a MeshFaceId matching any items in the MeshFaceIDFilters. | - |
| TimeStepFilters | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt; | If TimeStepFilters contains items, only results of type ITimeStepResult will be returned that has a TimeStep matching any items in the TimeStepFilters. | - |
| ResultSeriesIndex | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Index to be used for results of type IResultSeries. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [ResultFilter.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Results\ResultFilter.cs)

All history and changes of the class can be found by inspection the history.
