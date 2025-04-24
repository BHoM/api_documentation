---
title: ISizeableResource
---

# <small>BH.oM.Adapters.</small>**ISizeableResource**

Identifies a resource whose Size can be obtained.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISizeableResource is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapters.File.[IResource](/api/oM/Adapter/Adapters.File/Interfaces/IResource)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.File.[FSDirectory](/api/oM/Adapter/Adapters.File/FSDirectory)
    - BH.oM.Adapters.File.[FSFile](/api/oM/Adapter/Adapters.File/FSFile)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Size | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Size of the resource in Bytes. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface ISizeableResource : BH.oM.Adapters.File.IResource, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: File_oM.dll

The interface is defined in C#. The class definition is available on github:

- [ISizeableResource.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Interfaces\ISizeableResource.cs)

All history and changes of the class can be found by inspection the history.
