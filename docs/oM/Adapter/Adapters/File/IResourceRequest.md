---
title: IResourceRequest
---

# Adapters.File.IResourceRequest



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IResourceRequest in inheriting from the following base type(s) and implements the following interfaces:"

    -  Data.Requests.[IRequest](/api_documentation/oM/Framework/Data/Requests/IRequest)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Adapters.File.[IDirectoryRequest](/api_documentation/oM/Adapter/Adapters/File/IDirectoryRequest)
    - Adapters.File.[IFileRequest](/api_documentation/oM/Adapter/Adapters/File/IFileRequest)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.File.[DirectoryRequest](/api_documentation/oM/Adapter/Adapters/File/DirectoryRequest)
    - Adapters.File.[FileDirRequest](/api_documentation/oM/Adapter/Adapters/File/FileDirRequest)
    - Adapters.File.[FileRequest](/api_documentation/oM/Adapter/Adapters/File/FileRequest)


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
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api_documentation/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IResourceRequest.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Requests/Interfaces/IResourceRequest.cs)

All history and changes of the class can be found by inspection the history.
