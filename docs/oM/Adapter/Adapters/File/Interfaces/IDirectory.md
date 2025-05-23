---
title: IDirectory
---

# <small>BH.oM.Adapters.File.</small>**IDirectory**

Identifies a Directory.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IDirectory is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapters.File.[IResource](/api/oM/Adapter/Adapters/File/Interfaces/IResource)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.File.[Directory](/api/oM/Adapter/Adapters/File/Directory)
    - BH.oM.Adapters.File.[FSDirectory](/api/oM/Adapter/Adapters/File/FSDirectory)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IDirectory : BH.oM.Adapters.File.IResource, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: File_oM.dll

The C# interface definition is available on github:

- [IDirectory.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Interfaces\IDirectory.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/File_oM/IDirectory.json"
}
```

The JSON Schema is available on github here:

- [IDirectory.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/File_oM/IDirectory.json)
