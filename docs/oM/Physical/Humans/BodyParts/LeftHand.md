---
title: LeftHand
---

# <small>BH.oM.Humans.BodyParts.</small>**LeftHand**



## Class structure

### Implemented interfaces and base types

???+ bhom "The LeftHand is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Humans.Interfaces.[ILineBodyPart](/api/oM/Physical/Humans/Interfaces/ILineBodyPart)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Humans.Interfaces.[IPointBodyPart](/api/oM/Physical/Humans/Interfaces/IPointBodyPart)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TrackingPoint | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | - | - |
| TrackingLine | [Line](/api/oM/Dimensional/Geometry/Curve/Line) | - | - |
| State | [HandStateName](/api/oM/Physical/Humans/Enums/HandStateName) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class LeftHand : BH.oM.Humans.Interfaces.ILineBodyPart, BH.oM.Base.IObject, BH.oM.Humans.Interfaces.IPointBodyPart
```

Assembly: Humans_oM.dll

The class is defined in C#. The class definition is available on github:

- [LeftHand.cs](https://github.com/BHoM/BHoM/blob/develop/Humans_oM/BodyParts\LeftHand.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Humans_oM/BodyParts/LeftHand.json}
```

The JSON Schema is available on github here:

- [LeftHand.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Humans_oM/BodyParts/LeftHand.json)
