---
title: IResource
---

# <small>BH.oM.Adapters.File.</small>**IResource**

Identifies a general data Resource, whether a File or a Directory or other.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IResource is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Adapters.File.[IContainableResource](/api/oM/Adapter/Adapters/File/Interfaces/IContainableResource)
    - BH.oM.Adapters.File.[IContainer](/api/oM/Adapter/Adapters/File/Interfaces/IContainer)
    - BH.oM.Adapters.File.[IDirectory](/api/oM/Adapter/Adapters/File/Interfaces/IDirectory)
    - BH.oM.Adapters.File.[IFile](/api/oM/Adapter/Adapters/File/Interfaces/IFile)
    - BH.oM.Adapters.File.[IFSContainer](/api/oM/Adapter/Adapters/File/Interfaces/IFSContainer)
    - BH.oM.Adapters.File.[IFSResource](/api/oM/Adapter/Adapters/File/Interfaces/IFSResource)
    - BH.oM.Adapters.File.[ILocatableResource](/api/oM/Adapter/Adapters/File/Interfaces/ILocatableResource)
    - BH.oM.Adapters.File.[ISizeableResource](/api/oM/Adapter/Adapters/File/Interfaces/ISizeableResource)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.File.[Directory](/api/oM/Adapter/Adapters/File/Directory)
    - BH.oM.Adapters.File.[File](/api/oM/Adapter/Adapters/File/File)
    - BH.oM.Adapters.File.[FSDirectory](/api/oM/Adapter/Adapters/File/FSDirectory)
    - BH.oM.Adapters.File.[FSFile](/api/oM/Adapter/Adapters/File/FSFile)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IResource : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: File_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IResource.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Interfaces\IResource.cs)

All history and changes of the class can be found by inspection the history.
