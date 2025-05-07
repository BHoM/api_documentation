---
title: ObjectRequest
---

# <small>BH.oM.Adapters.Excel.</small>**ObjectRequest**

IRequest that pulls cells and their metadata from the excel file.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ObjectRequest is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Data.Requests.[IRequest](/api/oM/Framework/Data/Requests/IRequest)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Worksheet | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the worksheet to read from. | - |
| Range | [CellRange](/api/oM/Adapter/Adapters/Excel/Address/CellRange) | Cell range to read. If left empty, entire extent of the spreadsheet starting from A1 is used. | - |
| ObjectType | [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=netstandard-2.0) | Type of object to read. If left empty, CustomObjects will be returned. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ObjectRequest : BH.oM.Data.Requests.IRequest, BH.oM.Base.IObject
```

Assembly: Excel_oM.dll

The C# class definition is available on github:

- [ObjectRequest.cs](https://github.com/BHoM/Excel_Toolkit/blob/develop/Excel_oM/Requests\ObjectRequest.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Excel_oM/ObjectRequest.json"
}
```

The JSON Schema is available on github here:

- [ObjectRequest.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Excel_oM/ObjectRequest.json)
