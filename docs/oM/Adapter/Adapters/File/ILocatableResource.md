---
title: ILocatableResource
---

# Adapters.File.ILocatableResource

Identifies a general data Resource, whether a File or a Directory or other, that can be found at a certain location.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ILocatableResource in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapters.File.[IResource](/api/oM/Adapter/Adapters/File/IResource)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Adapters.File.[IContainer](/api/oM/Adapter/Adapters/File/IContainer)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.File.[Directory](/api/oM/Adapter/Adapters/File/Directory)
    - Adapters.File.[File](/api/oM/Adapter/Adapters/File/File)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Location | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [ILocatableResource.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Interfaces/ILocatableResource.cs)

All history and changes of the class can be found by inspection the history.
