---
title: IOptimiser
---

# <small>BH.oM.DeepLearning.Optimisers.</small>**IOptimiser**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IOptimiser is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.DeepLearning.Optimisers.[Adam](/api/oM/Framework/DeepLearning/Optimisers/Adam)
    - BH.oM.DeepLearning.Optimisers.[SGD](/api/oM/Framework/DeepLearning/Optimisers/SGD)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IOptimiser : BH.oM.Base.IObject
```

Assembly: DeepLearning_oM.dll

The C# interface definition is available on github:

- [IOptimiser.cs](https://github.com/BHoM/BHoM/blob/develop/DeepLearning_oM/Optimisers\IOptimiser.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/DeepLearning_oM/Optimisers/IOptimiser.json"
}
```

The JSON Schema is available on github here:

- [IOptimiser.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/DeepLearning_oM/Optimisers/IOptimiser.json)
