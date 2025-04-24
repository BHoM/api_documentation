---
title: IDirectory
---

# <small>BH.oM.Adapters.</small>**IDirectory**

Identifies a Directory.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IDirectory is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapters.File.[IResource](/api/oM/Adapter/Adapters.File/Interfaces/IResource)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.File.[Directory](/api/oM/Adapter/Adapters.File/Directory)
    - BH.oM.Adapters.File.[FSDirectory](/api/oM/Adapter/Adapters.File/FSDirectory)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IDirectory : BH.oM.Adapters.File.IResource, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: File_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IDirectory.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Interfaces\IDirectory.cs)

All history and changes of the class can be found by inspection the history.
