---
title: MeshResultRequest
---

# Structure.Requests.MeshResultRequest

Request for extracting mesh results from an adapter.

## Class structure

### Implemented interfaces and base types

???+ bhom "The MeshResultRequest in inheriting from the following base type(s) and implements the following interfaces:"

    -  Structure.Requests.[IStructuralResultRequest](/api_documentation/oM/Analytical/Structure/Requests/IStructuralResultRequest)
    -  Data.Requests.[IResultRequest](/api_documentation/oM/Framework/Data/Requests/IResultRequest)
    -  Data.Requests.[IRequest](/api_documentation/oM/Framework/Data/Requests/IRequest)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ResultType | [MeshResultType](/api_documentation/oM/Analytical/Structure/Results/MeshResultType) | Request for extracting bar results from an adapter. | - |
| Smoothing | [MeshResultSmoothingType](/api_documentation/oM/Analytical/Structure/Results/MeshResultSmoothingType) | - | - |
| Layer | [MeshResultLayer](/api_documentation/oM/Analytical/Structure/Results/MeshResultLayer) | - | - |
| LayerPosition | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Position within the element thickness that result is extracted from, normalised to 1. I.e. 0 = lower surface, 0.5 = middle, 1 = top surface. | - |
| Orientation | [Basis](/api_documentation/oM/Dimensional/Geometry/Basis) | - | - |
| Cases | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | Defines which cases and/or combinations that results should be extracted for. Can generally be set to either Loadcase or Loadcombination objects, or identifiers matching the software. If nothing is provided, results for all cases will be assumed. | - |
| Modes | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Defines for which modes results should be extracted. Only applicable for some casetypes. If nothing is provided, results for all modes will be assumed. | - |
| ObjectIds | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | Defines which meshes that results should be extracted for. Can generally be set to either pulled Panel/FEMesh objects, or identifiers matching the software. If nothing is provided, results for all meshes will be assumed. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api_documentation/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [MeshResultRequest.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Requests\MeshResultRequest.cs)

All history and changes of the class can be found by inspection the history.
