---
title: FSFile
---

# <small>BH.oM.Adapters.</small>**FSFile**

A FileSystem-hosted File. It can include the content of the File.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FSFile is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Adapters.File.[IFSContainer](/api/oM/Adapter/Adapters.File/Interfaces/IFSContainer)
    -  BH.oM.Adapters.File.[IFSInfo](/api/oM/Adapter/Adapters.File/Interfaces/IFSInfo)
    -  BH.oM.Adapters.File.[IContainableResource](/api/oM/Adapter/Adapters.File/Interfaces/IContainableResource)
    -  BH.oM.Adapters.File.[IResource](/api/oM/Adapter/Adapters.File/Interfaces/IResource)
    -  BH.oM.Adapters.File.[IFile](/api/oM/Adapter/Adapters.File/Interfaces/IFile)
    -  BH.oM.Adapters.File.[ISizeableResource](/api/oM/Adapter/Adapters.File/Interfaces/ISizeableResource)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ParentDirectory | [FSDirectory](/api/oM/Adapter/Adapters.File/FSDirectory) | Full path of parent Directory of the File. You can also specify a string path. | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the file, INCLUDING Extension. | - |
| Exists | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Gets a value indicating whether a file exists. | - |
| IsReadOnly | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Gets or sets a value that determines if the current file is read only. | - |
| Size | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | The size of the File in bytes. | - |
| Attributes | [FileAttributes](https://learn.microsoft.com/en-us/dotnet/api/System.IO.FileAttributes?view=netstandard-2.0) | Attributes indicating if ReadOnly, Hidden, System File, etc. | - |
| CreationTimeUtc | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | - | - |
| ModifiedTimeUtc | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | - | - |
| Owner | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | User owning the file, if any, or the user who created the File. | - |
| Content | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | The content of the file. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| ContentsAsByteArray | [byte](https://learn.microsoft.com/en-us/dotnet/api/System.Byte?view=netstandard-2.0)[] | Get the contents of the file as a byteArray, reading from its location. | - | File_Engine |
| ContentsAsString | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Get the contents of the file as a string, reading from its location. | - | File_Engine |
| Encoding | [Encoding](https://learn.microsoft.com/en-us/dotnet/api/System.Text.Encoding?view=netstandard-2.0) | Try to get the encoding of the file. | - | File_Engine |
| IsAcyclic | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Test whether the file hierarchy is acyclic, i.e. has no loops in it. | - | File_Engine |
| NestingDepth | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Get the nesting depth of the input File or Directory, which is the total number of parent folders. | - | File_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class FSFile : BH.oM.Base.BHoMObject,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.Adapters.File.IFSContainer,
BH.oM.Adapters.File.IFSInfo,
BH.oM.Adapters.File.IContainableResource,
BH.oM.Adapters.File.IResource,
BH.oM.Adapters.File.IFile,
BH.oM.Adapters.File.ISizeableResource
```

Assembly: File_oM.dll

The class is defined in C#. The class definition is available on github:

- [FSFile.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/FSFile.cs)

All history and changes of the class can be found by inspection the history.
