---
title: ISizeableResource
---

# <small>BH.oM.Adapters.File.</small>**ISizeableResource**

Identifies a resource whose Size can be obtained.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISizeableResource is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapters.File.[IResource](/api/oM/Adapter/Adapters/File/Interfaces/IResource)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.File.[FSDirectory](/api/oM/Adapter/Adapters/File/FSDirectory)
    - BH.oM.Adapters.File.[FSFile](/api/oM/Adapter/Adapters/File/FSFile)


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

The C# interface definition is available on github:

- [ISizeableResource.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Interfaces\ISizeableResource.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/File_oM/ISizeableResource.json"
}
```

The JSON Schema is available on github here:

- [ISizeableResource.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/File_oM/ISizeableResource.json)
