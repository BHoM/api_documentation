---
title: IContainer
---

# <small>BH.oM.Adapters.</small>**IContainer**

Identifies a Resource (a File or Directory or other) that is locatable and holds some content.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IContainer is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapters.File.[ILocatableResource](/api/oM/Adapter/Adapters.File/Interfaces/ILocatableResource)
    -  BH.oM.Adapters.File.[IResource](/api/oM/Adapter/Adapters.File/Interfaces/IResource)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Adapters.File.[IContainableResource](/api/oM/Adapter/Adapters.File/Interfaces/IContainableResource)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IContainer : BH.oM.Adapters.File.ILocatableResource,
BH.oM.Adapters.File.IResource,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.Adapters.File.IContainableResource
```

Assembly: File_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IContainer.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Interfaces\IContainer.cs)

All history and changes of the class can be found by inspection the history.
