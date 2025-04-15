---
title: FilterLinkInstance
---

# Adapters.Revit.Requests.FilterLinkInstance

IRequest that filters all link instances with given file name/path, Name parameter value or ElementId from active Revit document. If link name field is left blank, all link instances in the document will be filtered.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FilterLinkInstance in inheriting from the following base type(s) and implements the following interfaces:"

    -  Data.Requests.[IRequest](/documentation/oM/Framework/Data/Requests/IRequest)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| LinkName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the link file (alternatively whole file path, Name parameter value or ElementId) used to filter the Revit link instances. Optional: if left blank, all link instances in the document will be filtered. | - |
| CaseSensitive | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true: only perfect, case sensitive text match will be accepted. If false: capitals and small letters will be treated as equal. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/documentation/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [FilterLinkInstance.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Requests/FilterLinkInstance.cs)

All history and changes of the class can be found by inspection the history.
