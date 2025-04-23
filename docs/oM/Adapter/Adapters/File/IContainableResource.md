---
title: IContainableResource
---

# Adapters.File.IContainableResource

Identifies a general data Resource, whether a File or a Directory or other, that can hold some content.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IContainableResource in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapters.File.[IResource](/api/oM/Adapter/Adapters/File/IResource)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Adapters.File.[IContainer](/api/oM/Adapter/Adapters/File/IContainer)
    - Adapters.File.[IFSContainer](/api/oM/Adapter/Adapters/File/IFSContainer)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.File.[Directory](/api/oM/Adapter/Adapters/File/Directory)
    - Adapters.File.[File](/api/oM/Adapter/Adapters/File/File)
    - Adapters.File.[FSDirectory](/api/oM/Adapter/Adapters/File/FSDirectory)
    - Adapters.File.[FSFile](/api/oM/Adapter/Adapters/File/FSFile)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Content | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IContainableResource.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Interfaces/IContainableResource.cs)

All history and changes of the class can be found by inspection the history.
