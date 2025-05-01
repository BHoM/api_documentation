---
title: IFile
---

# <small>BH.oM.Adapters.File.</small>**IFile**

Identifies a File.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IFile is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapters.File.[IResource](/api/oM/Adapter/Adapters/File/Interfaces/IResource)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.File.[File](/api/oM/Adapter/Adapters/File/File)
    - BH.oM.Adapters.File.[FSFile](/api/oM/Adapter/Adapters/File/FSFile)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IFile : BH.oM.Adapters.File.IResource, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: File_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IFile.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Interfaces\IFile.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/File_oM/IFile.json"
}
```

The JSON Schema is available on github here:

- [IFile.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/File_oM/IFile.json)
