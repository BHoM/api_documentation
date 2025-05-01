---
title: IMarker
---

# <small>BH.oM.Graphics.Components.</small>**IMarker**

Interface for arrow head markers.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IMarker is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Graphics.Components.[BasicArrowMarker](/api/oM/Graphics/Graphics/Components/BasicArrowMarker)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IMarker : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Graphics_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IMarker.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Components\IMarker.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Graphics_oM/Components/IMarker.json"
}
```

The JSON Schema is available on github here:

- [IMarker.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Graphics_oM/Components/IMarker.json)
