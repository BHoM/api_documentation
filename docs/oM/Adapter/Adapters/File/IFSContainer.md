---
title: IFSContainer
---

# Adapters.File.IFSContainer

Identifies a FileSystem-hosted Resource (a File or Directory or other) that holds some content.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IFSContainer in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapters.File.[IFSInfo](/documentation/oM/Adapter/Adapters/File/IFSInfo)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)
    -  Adapters.File.[IContainableResource](/documentation/oM/Adapter/Adapters/File/IContainableResource)
    -  Adapters.File.[IResource](/documentation/oM/Adapter/Adapters/File/IResource)
    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.File.[FSDirectory](/documentation/oM/Adapter/Adapters/File/FSDirectory)
    - Adapters.File.[FSFile](/documentation/oM/Adapter/Adapters/File/FSFile)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsAcyclic | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Test whether the file hierarchy is acyclic, i.e. has no loops in it. | - | File_Engine |
| NestingDepth | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Get the nesting depth of the input File or Directory, which is the total number of parent folders. | - | File_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IFSContainer.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Interfaces/IFSContainer.cs)

All history and changes of the class can be found by inspection the history.
