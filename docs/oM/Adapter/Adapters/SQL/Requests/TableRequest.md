---
title: TableRequest
---

# <small>BH.oM.Adapters.SQL.</small>**TableRequest**



## Class structure

### Implemented interfaces and base types

???+ bhom "The TableRequest is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Data.Requests.[IRequest](/api/oM/Framework/Data/Requests/IRequest)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Adapters.SQL.[ITypeStrongRequest](/api/oM/Adapter/Adapters/SQL/Requests/ITypeStrongRequest)
    -  BH.oM.Adapters.SQL.[ISingleTableRequest](/api/oM/Adapter/Adapters/SQL/Requests/ISingleTableRequest)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Table | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Columns | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| Filter | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| DataType | [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=netstandard-2.0) | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class TableRequest : BH.oM.Data.Requests.IRequest,
BH.oM.Base.IObject,
BH.oM.Adapters.SQL.ITypeStrongRequest,
BH.oM.Adapters.SQL.ISingleTableRequest
```

Assembly: SQL_oM.dll

The C# class definition is available on github:

- [TableRequest.cs](https://github.com/BHoM/SQL_Toolkit/blob/develop/SQL_oM/Requests\TableRequest.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SQL_oM/TableRequest.json"
}
```

The JSON Schema is available on github here:

- [TableRequest.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SQL_oM/TableRequest.json)
