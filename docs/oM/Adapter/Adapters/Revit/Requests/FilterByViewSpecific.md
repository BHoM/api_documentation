---
title: FilterByViewSpecific
---

# Adapters.Revit.Requests.FilterByViewSpecific

IRequest that filters elements specific to (owned by) a given view in Revit.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FilterByViewSpecific in inheriting from the following base type(s) and implements the following interfaces:"

    -  Data.Requests.[IRequest](/api/oM/Framework/Data/Requests/IRequest)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ViewId | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | ElementId of the owner view in Revit. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [FilterByViewSpecific.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Requests/FilterByViewSpecific.cs)

All history and changes of the class can be found by inspection the history.
