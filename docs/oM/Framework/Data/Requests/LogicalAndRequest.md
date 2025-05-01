---
title: LogicalAndRequest
---

# <small>BH.oM.Data.Requests.</small>**LogicalAndRequest**

IRequest that combines a group of requests into a logical AND statement.

## Class structure

### Implemented interfaces and base types

???+ bhom "The LogicalAndRequest is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Data.Requests.[ILogicalRequest](/api/oM/Framework/Data/Requests/ILogicalRequest)
    -  BH.oM.Data.Requests.[IRequest](/api/oM/Framework/Data/Requests/IRequest)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Requests | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IRequest](/api/oM/Framework/Data/Requests/IRequest)&gt; | IRequests to be combined into a logical AND statement. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |
| IRequests | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IRequest](/api/oM/Framework/Data/Requests/IRequest)&gt; | - | - | Data_Engine |
| Requests | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IRequest](/api/oM/Framework/Data/Requests/IRequest)&gt; | - | - | Data_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class LogicalAndRequest : BH.oM.Data.Requests.ILogicalRequest, BH.oM.Data.Requests.IRequest, BH.oM.Base.IObject
```

Assembly: Data_oM.dll

The class is defined in C#. The class definition is available on github:

- [LogicalAndRequest.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Requests\LogicalAndRequest.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Data_oM/Requests/LogicalAndRequest.json"
}
```

The JSON Schema is available on github here:

- [LogicalAndRequest.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Data_oM/Requests/LogicalAndRequest.json)
