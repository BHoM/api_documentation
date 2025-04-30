---
title: RightShoulder
---

# <small>BH.oM.Humans.BodyParts.</small>**RightShoulder**



## Class structure

### Implemented interfaces and base types

???+ bhom "The RightShoulder is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Humans.Interfaces.[ILineBodyPart](/api/oM/Physical/Humans/Interfaces/ILineBodyPart)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TrackingLine | [Line](/api/oM/Dimensional/Geometry/Curve/Line) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RightShoulder : BH.oM.Humans.Interfaces.ILineBodyPart, BH.oM.Base.IObject
```

Assembly: Humans_oM.dll

The class is defined in C#. The class definition is available on github:

- [RightShoulder.cs](https://github.com/BHoM/BHoM/blob/develop/Humans_oM/BodyParts\RightShoulder.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Humans_oM/BodyParts/RightShoulder.json}
```

The JSON Schema is available on github here:

- [RightShoulder.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Humans_oM/BodyParts/RightShoulder.json)
