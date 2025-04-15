---
title: FilterFamilyTypeByName
---

# Adapters.Revit.Requests.FilterFamilyTypeByName

IRequest that filters Revit family types by names of theirs and their parent family, with option to loose the search by leaving one or both of the input names blank.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FilterFamilyTypeByName in inheriting from the following base type(s) and implements the following interfaces:"

    -  Data.Requests.[IRequest](/documentation/oM/Framework/Data/Requests/IRequest)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| FamilyName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of Revit family as shown in Revit UI. Optional: if left blank, all families will be filtered in search for specified family type name. | - |
| FamilyTypeName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Revit family type name matching one displayed in Revit UI. Optional: if left blank, all types within family will be returned. If family name is left blank too, all family types in model will be returned. | - |
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

- [FilterFamilyTypeByName.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Requests/FilterFamilyTypeByName.cs)

All history and changes of the class can be found by inspection the history.
