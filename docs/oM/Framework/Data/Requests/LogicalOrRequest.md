---
title: LogicalOrRequest
---

# Data.Requests.LogicalOrRequest

IRequest that combines a group of requests into a logical OR statement.

## Class structure

### Implemented interfaces and base types

???+ bhom "The LogicalOrRequest in inheriting from the following base type(s) and implements the following interfaces:"

    -  Data.Requests.[ILogicalRequest](/api/oM/Framework/Data/Requests/ILogicalRequest)
    -  Data.Requests.[IRequest](/api/oM/Framework/Data/Requests/IRequest)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Requests | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IRequest](/api/oM/Framework/Data/Requests/IRequest)&gt; | IRequests to be combined into a logical OR statement. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |
| IRequests | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IRequest](/api/oM/Framework/Data/Requests/IRequest)&gt; | - | - | Data_Engine |
| Requests | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IRequest](/api/oM/Framework/Data/Requests/IRequest)&gt; | - | - | Data_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [LogicalOrRequest.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Requests\LogicalOrRequest.cs)

All history and changes of the class can be found by inspection the history.
