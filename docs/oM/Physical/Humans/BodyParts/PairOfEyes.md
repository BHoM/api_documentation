---
title: PairOfEyes
---

# <small>BH.oM.Humans.BodyParts.</small>**PairOfEyes**



## Class structure

### Implemented interfaces and base types

???+ bhom "The PairOfEyes is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Humans.Interfaces.[IPointBodyPart](/api/oM/Physical/Humans/Interfaces/IPointBodyPart)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TrackingPoint | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | - | - |
| LeftEye | [Eye](/api/oM/Physical/Humans/BodyParts/Eye) | - | - |
| RightEye | [Eye](/api/oM/Physical/Humans/BodyParts/Eye) | - | - |
| ReferenceLocation | [Point](/api/oM/Dimensional/Geometry/Vector/Point) | - | - |
| ViewDirection | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PairOfEyes : BH.oM.Humans.Interfaces.IPointBodyPart, BH.oM.Base.IObject
```

Assembly: Humans_oM.dll

The class is defined in C#. The class definition is available on github:

- [PairOfEyes.cs](https://github.com/BHoM/BHoM/blob/develop/Humans_oM/BodyParts\PairOfEyes.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Humans_oM/BodyParts/PairOfEyes.json}
```

The JSON Schema is available on github here:

- [PairOfEyes.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Humans_oM/BodyParts/PairOfEyes.json)
