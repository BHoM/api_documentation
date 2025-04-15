---
title: IFileRequest
---

# Adapters.File.IFileRequest



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IFileRequest in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapters.File.[ISortableRequest](/om_documentation/oM/Adapter/Adapters/File/ISortableRequest)
    -  Data.Requests.[IRequest](/om_documentation/oM/Framework/Data/Requests/IRequest)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)
    -  Adapters.File.[IResourceRequest](/om_documentation/oM/Adapter/Adapters/File/IResourceRequest)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.File.[FileDirRequest](/om_documentation/oM/Adapter/Adapters/File/FileDirRequest)
    - Adapters.File.[FileRequest](/om_documentation/oM/Adapter/Adapters/File/FileRequest)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| MaxFiles | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |
| IncludeFileContents | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/om_documentation/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IFileRequest.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Requests/Interfaces/IFileRequest.cs)

All history and changes of the class can be found by inspection the history.
