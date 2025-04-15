---
title: ISizeableResource
---

# Adapters.File.ISizeableResource

Identifies a resource whose Size can be obtained.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISizeableResource in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapters.File.[IResource](/documentation/oM/Adapter/Adapters/File/IResource)
    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.File.[FSDirectory](/documentation/oM/Adapter/Adapters/File/FSDirectory)
    - Adapters.File.[FSFile](/documentation/oM/Adapter/Adapters/File/FSFile)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Size | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Size of the resource in Bytes. | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [ISizeableResource.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Interfaces/ISizeableResource.cs)

All history and changes of the class can be found by inspection the history.
