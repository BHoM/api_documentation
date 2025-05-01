---
title: ConstructionOffset
---

# <small>BH.oM.Facade.Fragments.</small>**ConstructionOffset**

Fragment containing the offset distance of a construction type from the facade center line

## Class structure

### Implemented interfaces and base types

???+ bhom "The ConstructionOffset is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| OffsetDistance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Offset distance from centerline of wall or glazing section from centerline of facade section | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ConstructionOffset : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Facade_oM.dll

The class is defined in C#. The class definition is available on github:

- [ConstructionOffset.cs](https://github.com/BHoM/BHoM/blob/develop/Facade_oM/Fragments\ConstructionOffset.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Facade_oM/Fragments/ConstructionOffset.json"
}
```

The JSON Schema is available on github here:

- [ConstructionOffset.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Facade_oM/Fragments/ConstructionOffset.json)
