---
title: IProjection
---

# <small>BH.oM.Analytical.Graph.Projection.</small>**IProjection**

Interface common to all graph projections.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IProjection is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Analytical.Graph.Projection.[GeometricProjection](/api/oM/Analytical/Analytical/Graph/Projection/GeometricProjection)
    - BH.oM.Analytical.Graph.Projection.[GraphicalProjection](/api/oM/Analytical/Analytical/Graph/Projection/GraphicalProjection)
    - BH.oM.Analytical.Graph.Projection.[SpatialProjection](/api/oM/Analytical/Analytical/Graph/Projection/SpatialProjection)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IProjection : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Analytical_oM.dll

The C# interface definition is available on github:

- [IProjection.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Graph\Projection\IProjection.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Analytical_oM/Graph/Projection/IProjection.json"
}
```

The JSON Schema is available on github here:

- [IProjection.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Analytical_oM/Graph/Projection/IProjection.json)
