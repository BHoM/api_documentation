---
title: CustomRequest
---

# Adapters.SQL.CustomRequest



## Class structure

### Implemented interfaces and base types

???+ bhom "The CustomRequest in inheriting from the following base type(s) and implements the following interfaces:"

    -  Data.Requests.[IRequest](/api_documentation/oM/Framework/Data/Requests/IRequest)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Adapters.SQL.[ITypeStrongRequest](/api_documentation/oM/Adapter/Adapters/SQL/ITypeStrongRequest)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Query | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| DataType | [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=netstandard-2.0) | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api_documentation/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [CustomRequest.cs](https://github.com/BHoM/SQL_Toolkit/blob/develop/SQL_oM/Requests/CustomRequest.cs)

All history and changes of the class can be found by inspection the history.
