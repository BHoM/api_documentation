---
title: IContainableResource
---

# <small>BH.oM.Adapters.</small>**IContainableResource**

Identifies a general data Resource, whether a File or a Directory or other, that can hold some content.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IContainableResource is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapters.File.[IResource](/api/oM/Adapter/Adapters.File/Interfaces/IResource)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Adapters.File.[IContainer](/api/oM/Adapter/Adapters.File/Interfaces/IContainer)
    - BH.oM.Adapters.File.[IFSContainer](/api/oM/Adapter/Adapters.File/Interfaces/IFSContainer)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.File.[Directory](/api/oM/Adapter/Adapters.File/Directory)
    - BH.oM.Adapters.File.[File](/api/oM/Adapter/Adapters.File/File)
    - BH.oM.Adapters.File.[FSDirectory](/api/oM/Adapter/Adapters.File/FSDirectory)
    - BH.oM.Adapters.File.[FSFile](/api/oM/Adapter/Adapters.File/FSFile)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Content | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IContainableResource : BH.oM.Adapters.File.IResource, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: File_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IContainableResource.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Interfaces\IContainableResource.cs)

All history and changes of the class can be found by inspection the history.
