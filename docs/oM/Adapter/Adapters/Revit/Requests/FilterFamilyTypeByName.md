---
title: FilterFamilyTypeByName
---

# <small>BH.oM.Adapters.Revit.Requests.</small>**FilterFamilyTypeByName**

IRequest that filters Revit family types by names of theirs and their parent family, with option to loose the search by leaving one or both of the input names blank.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FilterFamilyTypeByName is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Data.Requests.[IRequest](/api/oM/Framework/Data/Requests/IRequest)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


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
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class FilterFamilyTypeByName : BH.oM.Data.Requests.IRequest, BH.oM.Base.IObject
```

Assembly: Revit_oM.dll

The C# class definition is available on github:

- [FilterFamilyTypeByName.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Requests\FilterFamilyTypeByName.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Revit_oM/Requests/FilterFamilyTypeByName.json"
}
```

The JSON Schema is available on github here:

- [FilterFamilyTypeByName.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Revit_oM/Requests/FilterFamilyTypeByName.json)
