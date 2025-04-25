---
title: IDirectoryRequest
---

# <small>BH.oM.Adapters.File.</small>**IDirectoryRequest**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IDirectoryRequest is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapters.File.[ISortableRequest](/api/oM/Adapter/Adapters/File/Requests/Interfaces/ISortableRequest)
    -  BH.oM.Data.Requests.[IRequest](/api/oM/Framework/Data/Requests/IRequest)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Adapters.File.[IResourceRequest](/api/oM/Adapter/Adapters/File/Requests/Interfaces/IResourceRequest)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.File.[DirectoryRequest](/api/oM/Adapter/Adapters/File/Requests/DirectoryRequest)
    - BH.oM.Adapters.File.[FileDirRequest](/api/oM/Adapter/Adapters/File/Requests/FileDirRequest)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| MaxDirectories | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IDirectoryRequest : BH.oM.Adapters.File.ISortableRequest, BH.oM.Data.Requests.IRequest, BH.oM.Base.IObject, BH.oM.Adapters.File.IResourceRequest
```

Assembly: File_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IDirectoryRequest.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Requests\Interfaces\IDirectoryRequest.cs)

All history and changes of the class can be found by inspection the history.
