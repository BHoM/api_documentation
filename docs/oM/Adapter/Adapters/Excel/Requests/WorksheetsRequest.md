---
title: WorksheetsRequest
---

# <small>BH.oM.Adapters.Excel.</small>**WorksheetsRequest**

IRequest that pulls worksheet names from an Excel file.

## Class structure

### Implemented interfaces and base types

???+ bhom "The WorksheetsRequest is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Data.Requests.[IRequest](/api/oM/Framework/Data/Requests/IRequest)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| NameContains | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Optional filter for worksheets where the name contains the string provided. If left blank, then all worksheets will be returned. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class WorksheetsRequest : BH.oM.Data.Requests.IRequest, BH.oM.Base.IObject
```

Assembly: Excel_oM.dll

The class is defined in C#. The class definition is available on github:

- [WorksheetsRequest.cs](https://github.com/BHoM/Excel_Toolkit/blob/develop/Excel_oM/Requests\WorksheetsRequest.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Excel_oM/WorksheetsRequest.json"
}
```

The JSON Schema is available on github here:

- [WorksheetsRequest.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Excel_oM/WorksheetsRequest.json)
