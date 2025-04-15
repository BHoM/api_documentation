---
title: LogicalNotRequest
---

# Data.Requests.LogicalNotRequest

IRequest that inverts the query specified by the input request, i.e. any object that fits this request will be excluded from a pull.

## Class structure

### Implemented interfaces and base types

???+ bhom "The LogicalNotRequest in inheriting from the following base type(s) and implements the following interfaces:"

    -  Data.Requests.[ILogicalRequest](/documentation/oM/Framework/Data/Requests/ILogicalRequest)
    -  Data.Requests.[IRequest](/documentation/oM/Framework/Data/Requests/IRequest)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Request | [IRequest](/documentation/oM/Framework/Data/Requests/IRequest) | Request to be inverted, i.e. defining what should be excluded. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/documentation/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |
| IRequests | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IRequest](/documentation/oM/Framework/Data/Requests/IRequest)&gt; | - | - | Data_Engine |
| Requests | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IRequest](/documentation/oM/Framework/Data/Requests/IRequest)&gt; | - | - | Data_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [LogicalNotRequest.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Requests\LogicalNotRequest.cs)

All history and changes of the class can be found by inspection the history.
