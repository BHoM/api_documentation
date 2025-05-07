---
title: IResourceRequest
---

# <small>BH.oM.Adapters.File.</small>**IResourceRequest**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IResourceRequest is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Data.Requests.[IRequest](/api/oM/Framework/Data/Requests/IRequest)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Adapters.File.[IDirectoryRequest](/api/oM/Adapter/Adapters/File/Requests/Interfaces/IDirectoryRequest)
    - BH.oM.Adapters.File.[IFileRequest](/api/oM/Adapter/Adapters/File/Requests/Interfaces/IFileRequest)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.File.[DirectoryRequest](/api/oM/Adapter/Adapters/File/Requests/DirectoryRequest)
    - BH.oM.Adapters.File.[FileDirRequest](/api/oM/Adapter/Adapters/File/Requests/FileDirRequest)
    - BH.oM.Adapters.File.[FileRequest](/api/oM/Adapter/Adapters/File/Requests/FileRequest)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Location | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| SearchSubdirectories | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| Exclusions | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IResourceRequest : BH.oM.Data.Requests.IRequest, BH.oM.Base.IObject
```

Assembly: File_oM.dll

The C# interface definition is available on github:

- [IResourceRequest.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Requests\Interfaces\IResourceRequest.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/File_oM/IResourceRequest.json"
}
```

The JSON Schema is available on github here:

- [IResourceRequest.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/File_oM/IResourceRequest.json)
