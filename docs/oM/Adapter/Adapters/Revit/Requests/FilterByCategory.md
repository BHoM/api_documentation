---
title: FilterByCategory
---

# Adapters.Revit.Requests.FilterByCategory

IRequest that filters all elements of a Revit category.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FilterByCategory in inheriting from the following base type(s) and implements the following interfaces:"

    -  Data.Requests.[IRequest](/api_documentation/oM/Framework/Data/Requests/IRequest)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| CategoryName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Revit category name, as shown in Revit user interface (currently only English supported). | - |
| CaseSensitive | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true: only perfect, case sensitive text match will be accepted. If false: capitals and small letters will be treated as equal. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api_documentation/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| FilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given FilterByCategory request. | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [FilterByCategory.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Requests/FilterByCategory.cs)

All history and changes of the class can be found by inspection the history.
