---
title: IShape
---

# <small>BH.oM.DeepLearning.</small>**IShape**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IShape is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.DeepLearning.[Shape2d](/api/oM/Framework/DeepLearning/Shape2d)
    - BH.oM.DeepLearning.[Shape3d](/api/oM/Framework/DeepLearning/Shape3d)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IShape : BH.oM.Base.IObject
```

Assembly: DeepLearning_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IShape.cs](https://github.com/BHoM/BHoM/blob/develop/DeepLearning_oM/IShape.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/DeepLearning_oM/IShape.json"
}
```

The JSON Schema is available on github here:

- [IShape.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/DeepLearning_oM/IShape.json)
