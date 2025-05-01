---
title: IFSResource
---

# <small>BH.oM.Adapters.File.</small>**IFSResource**

Identifies a general data Resource, whether a File or a Directory or other, that resides on a File System.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IFSResource is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapters.File.[IResource](/api/oM/Adapter/Adapters/File/Interfaces/IResource)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IFSResource : BH.oM.Adapters.File.IResource, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: File_oM.dll

The C# interface definition is available on github:

- [IFSResource.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Interfaces\IFSResource.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/File_oM/IFSResource.json"
}
```

The JSON Schema is available on github here:

- [IFSResource.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/File_oM/IFSResource.json)
