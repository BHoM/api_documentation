---
title: IOpenStreetMapRegion
---

# <small>BH.oM.Adapters.OpenStreetMap.</small>**IOpenStreetMapRegion**

Interface for all search regions.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IOpenStreetMapRegion is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.OpenStreetMap.[BoundingBox](/api/oM/Adapter/Adapters/OpenStreetMap/Elements/BoundingBox)
    - BH.oM.Adapters.OpenStreetMap.[CentreRadius](/api/oM/Adapter/Adapters/OpenStreetMap/Elements/CentreRadius)
    - BH.oM.Adapters.OpenStreetMap.[LineStringRadius](/api/oM/Adapter/Adapters/OpenStreetMap/Elements/LineStringRadius)
    - BH.oM.Adapters.OpenStreetMap.[Polygon](/api/oM/Adapter/Adapters/OpenStreetMap/Elements/Polygon)
    - BH.oM.Adapters.OpenStreetMap.[TaggedArea](/api/oM/Adapter/Adapters/OpenStreetMap/Elements/TaggedArea)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IOpenStreetMapRegion : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: OpenStreetMap_oM.dll

The C# interface definition is available on github:

- [IOpenStreetMapRegion.cs](https://github.com/BHoM/OpenStreetMap_Toolkit/blob/develop/OpenStreetMap_oM/Elements\IOpenStreetMapRegion.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/OpenStreetMap_oM/IOpenStreetMapRegion.json"
}
```

The JSON Schema is available on github here:

- [IOpenStreetMapRegion.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/OpenStreetMap_oM/IOpenStreetMapRegion.json)
