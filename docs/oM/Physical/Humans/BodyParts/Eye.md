---
title: Eye
---

# <small>BH.oM.Humans.BodyParts.</small>**Eye**



## Class structure

### Implemented interfaces and base types

???+ bhom "The Eye is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Humans.Interfaces.[IPointBodyPart](/api/oM/Physical/Humans/Interfaces/IPointBodyPart)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TrackingPoint | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Eye : BH.oM.Humans.Interfaces.IPointBodyPart, BH.oM.Base.IObject
```

Assembly: Humans_oM.dll

The C# class definition is available on github:

- [Eye.cs](https://github.com/BHoM/BHoM/blob/develop/Humans_oM/BodyParts\Eye.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Humans_oM/BodyParts/Eye.json"
}
```

The JSON Schema is available on github here:

- [Eye.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Humans_oM/BodyParts/Eye.json)
