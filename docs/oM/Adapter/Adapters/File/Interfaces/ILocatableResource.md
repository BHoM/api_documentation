---
title: ILocatableResource
---

# <small>BH.oM.Adapters.File.</small>**ILocatableResource**

Identifies a general data Resource, whether a File or a Directory or other, that can be found at a certain location.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ILocatableResource is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapters.File.[IResource](/api/oM/Adapter/Adapters/File/Interfaces/IResource)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Adapters.File.[IContainer](/api/oM/Adapter/Adapters/File/Interfaces/IContainer)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.File.[Directory](/api/oM/Adapter/Adapters/File/Directory)
    - BH.oM.Adapters.File.[File](/api/oM/Adapter/Adapters/File/File)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Location | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface ILocatableResource : BH.oM.Adapters.File.IResource, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: File_oM.dll

The C# interface definition is available on github:

- [ILocatableResource.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Interfaces\ILocatableResource.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/File_oM/ILocatableResource.json"
}
```

The JSON Schema is available on github here:

- [ILocatableResource.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/File_oM/ILocatableResource.json)
