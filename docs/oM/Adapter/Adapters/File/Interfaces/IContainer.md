---
title: IContainer
---

# <small>BH.oM.Adapters.File.</small>**IContainer**

Identifies a Resource (a File or Directory or other) that is locatable and holds some content.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IContainer is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapters.File.[ILocatableResource](/api/oM/Adapter/Adapters/File/Interfaces/ILocatableResource)
    -  BH.oM.Adapters.File.[IResource](/api/oM/Adapter/Adapters/File/Interfaces/IResource)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Adapters.File.[IContainableResource](/api/oM/Adapter/Adapters/File/Interfaces/IContainableResource)


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

The C# interface definition is available on github:

- [IContainer.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Interfaces\IContainer.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/File_oM/IContainer.json"
}
```

The JSON Schema is available on github here:

- [IContainer.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/File_oM/IContainer.json)
