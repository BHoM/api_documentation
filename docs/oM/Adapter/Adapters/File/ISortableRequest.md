---
title: ISortableRequest
---

# Adapters.File.ISortableRequest



## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISortableRequest in inheriting from the following base type(s) and implements the following interfaces:"

    -  Data.Requests.[IRequest](/api/oM/Framework/Data/Requests/IRequest)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Adapters.File.[IDirectoryRequest](/api/oM/Adapter/Adapters/File/IDirectoryRequest)
    - Adapters.File.[IFileRequest](/api/oM/Adapter/Adapters/File/IFileRequest)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.File.[DirectoryRequest](/api/oM/Adapter/Adapters/File/DirectoryRequest)
    - Adapters.File.[FileDirRequest](/api/oM/Adapter/Adapters/File/FileDirRequest)
    - Adapters.File.[FileRequest](/api/oM/Adapter/Adapters/File/FileRequest)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SortOrder | [SortOrder](/api/oM/Adapter/Adapters/File/SortOrder) | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [ISortableRequest.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Requests/Interfaces/ISortableRequest.cs)

All history and changes of the class can be found by inspection the history.
