---
title: LusasId
---

# <small>BH.oM.Adapters.Lusas.</small>**LusasId**



## Class structure

### Implemented interfaces and base types

???+ bhom "The LusasId is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IAdapterId](/api/oM/Framework/Base/Interface/IAdapterId)
    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Id | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | Id or multi-ids of the element as assigned in Lusas. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class LusasId : BH.oM.Base.IAdapterId, BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Lusas_oM.dll

The class is defined in C#. The class definition is available on github:

- [LusasId.cs](https://github.com/BHoM/Lusas_Toolkit/blob/develop/Lusas_oM/Fragments\LusasId.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Lusas_oM/LusasId.json"
}
```

The JSON Schema is available on github here:

- [LusasId.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Lusas_oM/LusasId.json)
