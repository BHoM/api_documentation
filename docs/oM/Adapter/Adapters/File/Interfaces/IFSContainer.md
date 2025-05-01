---
title: IFSContainer
---

# <small>BH.oM.Adapters.File.</small>**IFSContainer**

Identifies a FileSystem-hosted Resource (a File or Directory or other) that holds some content.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IFSContainer is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapters.File.[IFSInfo](/api/oM/Adapter/Adapters/File/Interfaces/IFSInfo)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Adapters.File.[IContainableResource](/api/oM/Adapter/Adapters/File/Interfaces/IContainableResource)
    -  BH.oM.Adapters.File.[IResource](/api/oM/Adapter/Adapters/File/Interfaces/IResource)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.File.[FSDirectory](/api/oM/Adapter/Adapters/File/FSDirectory)
    - BH.oM.Adapters.File.[FSFile](/api/oM/Adapter/Adapters/File/FSFile)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsAcyclic | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Test whether the file hierarchy is acyclic, i.e. has no loops in it. | - | File_Engine |
| NestingDepth | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Get the nesting depth of the input File or Directory, which is the total number of parent folders. | - | File_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IFSContainer : BH.oM.Adapters.File.IFSInfo,
BH.oM.Base.IObject,
BH.oM.Adapters.File.IContainableResource,
BH.oM.Adapters.File.IResource,
BH.oM.Base.IBHoMObject
```

Assembly: File_oM.dll

The C# interface definition is available on github:

- [IFSContainer.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Interfaces\IFSContainer.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/File_oM/IFSContainer.json"
}
```

The JSON Schema is available on github here:

- [IFSContainer.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/File_oM/IFSContainer.json)
