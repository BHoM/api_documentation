---
title: IFSInfo
---

# Adapters.File.IFSInfo

Identifies a FileSystem Resource with basic information attached.
Rehash of the .NET's base class 'FileSystemInfo' in BHoM flavour.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IFSInfo in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Adapters.File.[IFSContainer](/om_documentation/oM/Adapter/Adapters/File/IFSContainer)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.File.[FSDirectory](/om_documentation/oM/Adapter/Adapters/File/FSDirectory)
    - Adapters.File.[FSFile](/om_documentation/oM/Adapter/Adapters/File/FSFile)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ParentDirectory | [FSDirectory](/om_documentation/oM/Adapter/Adapters/File/FSDirectory) | Parent Directory of the File or Directory. | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the file (WITH Extension) or of the Directory. | - |
| Exists | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | - | - |
| Attributes | [FileAttributes](https://learn.microsoft.com/en-us/dotnet/api/System.IO.FileAttributes?view=netstandard-2.0) | - | - |
| CreationTimeUtc | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | - | - |
| ModifiedTimeUtc | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | - | - |
| Size | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |
| Owner | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsAcyclic | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Test whether the file hierarchy is acyclic, i.e. has no loops in it. | - | File_Engine |
| NestingDepth | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Get the nesting depth of the input File or Directory, which is the total number of parent folders. | - | File_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IFSInfo.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Interfaces/IFSInfo.cs)

All history and changes of the class can be found by inspection the history.
