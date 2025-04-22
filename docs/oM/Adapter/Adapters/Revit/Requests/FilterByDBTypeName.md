---
title: FilterByDBTypeName
---

# Adapters.Revit.Requests.FilterByDBTypeName

IRequest that filters all elements of given Autodesk.Revit.DB type. Information about types can be found in the Revit API documentation.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FilterByDBTypeName in inheriting from the following base type(s) and implements the following interfaces:"

    -  Data.Requests.[IRequest](/api_documentation/oM/Framework/Data/Requests/IRequest)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TypeName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Full Revit DB type name, including namespace before the name of the actual type. For example: 'Autodesk.Revit.DB.Wall. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api_documentation/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [FilterByDBTypeName.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Requests/FilterByDBTypeName.cs)

All history and changes of the class can be found by inspection the history.
