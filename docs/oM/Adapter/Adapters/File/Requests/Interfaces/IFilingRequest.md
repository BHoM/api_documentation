---
title: IFilingRequest
---

# <small>BH.oM.Adapters.File.</small>**IFilingRequest**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IFilingRequest is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Data.Requests.[IRequest](/api/oM/Framework/Data/Requests/IRequest)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.File.[FileContentRequest](/api/oM/Adapter/Adapters/File/Requests/FileContentRequest)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IFilingRequest : BH.oM.Data.Requests.IRequest, BH.oM.Base.IObject
```

Assembly: File_oM.dll

The C# interface definition is available on github:

- [IFilingRequest.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Requests\Interfaces\IFilingRequest.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/File_oM/IFilingRequest.json"
}
```

The JSON Schema is available on github here:

- [IFilingRequest.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/File_oM/IFilingRequest.json)
