---
title: BarResultRequest
---

# Structure.Requests.BarResultRequest

Request for extracting Bar results from an adapter.

## Class structure

### Implemented interfaces and base types

???+ bhom "The BarResultRequest in inheriting from the following base type(s) and implements the following interfaces:"

    -  Structure.Requests.[IStructuralResultRequest](/om_documentation/oM/Analytical/Structure/Requests/IStructuralResultRequest)
    -  Data.Requests.[IResultRequest](/om_documentation/oM/Framework/Data/Requests/IResultRequest)
    -  Data.Requests.[IRequest](/om_documentation/oM/Framework/Data/Requests/IRequest)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ResultType | [BarResultType](/om_documentation/oM/Analytical/Structure/Requests/BarResultType) | - | - |
| DivisionType | [DivisionType](/om_documentation/oM/Analytical/Structure/Requests/DivisionType) | Defines which internal points results should be extracted for. For evenly distributed the bar is split into equal length segments, controlled by the divisions. For ExtremeValues the positions with extreme forces for any DOF will be included, which means you might get more/less values than stated in the Divisions. | - |
| Divisions | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Defines how many points along the bar that results should be extracted for. | - |
| Cases | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | Defines which cases and/or combinations that results should be extracted for. Can generally be set to either Loadcase or Loadcombination objects, or identifiers matching the software. If nothing is provided, results for all cases will be assumed. | - |
| Modes | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Defines for which modes results should be extracted. Only applicable for some casetypes. If nothing is provided, results for all modes will be assumed. | - |
| ObjectIds | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | Defines which Bars that results should be extracted for. Can generally be set to either pulled Bar objects, or identifiers matching the software. If nothing is provided, results for all Bars will be assumed. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/om_documentation/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [BarResultRequest.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Requests\BarResultRequest.cs)

All history and changes of the class can be found by inspection the history.
