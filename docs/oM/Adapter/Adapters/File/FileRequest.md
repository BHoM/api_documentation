---
title: FileRequest
---

# Adapters.File.FileRequest

Used to query Files from a Parent directory.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FileRequest in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapters.File.[IFileRequest](/api/oM/Adapter/Adapters/File/IFileRequest)
    -  Adapters.File.[ISortableRequest](/api/oM/Adapter/Adapters/File/ISortableRequest)
    -  Data.Requests.[IRequest](/api/oM/Framework/Data/Requests/IRequest)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  Adapters.File.[IResourceRequest](/api/oM/Adapter/Adapters/File/IResourceRequest)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Location | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Files from this location will be queried. | - |
| SearchSubdirectories | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If enabled, look also in subdirectories. | - |
| MaxNesting | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | If SearchSubdirectories is true, this sets the maximum subdirectiory nesting level to look in.<br>Defaults to -1 which corresponds to no limit. | - |
| SortOrder | [SortOrder](/api/oM/Adapter/Adapters/File/SortOrder) | Sorting order of the extracted Files. | - |
| MaxFiles | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Sets the maximum number of Files to retrieve, useful when using SearchSubdirectories.<br>Defaults to -1 which corresponds to no limit. | - |
| IncludeFileContents | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Whether to include the contents of the Files. | - |
| Exclusions | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | These files will be excluded from the results.<br>You can also specify string Full Paths. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [FileRequest.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Requests/FileRequest.cs)

All history and changes of the class can be found by inspection the history.
