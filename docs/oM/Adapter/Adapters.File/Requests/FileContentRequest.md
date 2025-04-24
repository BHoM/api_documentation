---
title: FileContentRequest
---

# <small>BH.oM.Adapters.</small>**FileContentRequest**

Used to read contents of one or more files.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FileContentRequest is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapters.File.[IFilingRequest](/api/oM/Adapter/Adapters.File/Requests/Interfaces/IFilingRequest)
    -  BH.oM.Data.Requests.[IRequest](/api/oM/Framework/Data/Requests/IRequest)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| File | [FSFile](/api/oM/Adapter/Adapters.File/FSFile) | The content from this File will be queried.<br>You can also specify the file with a string Path.  | - |
| Types | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=netstandard-2.0)&gt; | Only objects of a Type specified in this list will be returned. | - |
| CustomDataKeys | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Only BHoMObjects whose CustomData contains these key/value pairs will be returned. | - |
| FragmentTypes | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=netstandard-2.0)&gt; | Only BHoMObjects that own a Fragment of one of these Types will be returned. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api/oM/Adapter/Adapters.Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class FileContentRequest : BH.oM.Adapters.File.IFilingRequest, BH.oM.Data.Requests.IRequest, BH.oM.Base.IObject
```

Assembly: File_oM.dll

The class is defined in C#. The class definition is available on github:

- [FileContentRequest.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Requests\FileContentRequest.cs)

All history and changes of the class can be found by inspection the history.
