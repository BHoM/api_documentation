---
title: DummyTag
---

# <small>BH.oM.Adapters.GSA.</small>**DummyTag**

Fragment controling whether the element should be a dummy element or not.

## Class structure

### Implemented interfaces and base types

???+ bhom "The DummyTag is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| IsDummy | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | True means the element will be treated as a dummy in GSA. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class DummyTag : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: GSA_oM.dll

The class is defined in C#. The class definition is available on github:

- [DummyTag.cs](https://github.com/BHoM/GSA_Toolkit/blob/develop/GSA_oM/Fragments\DummyTag.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/GSA_oM/DummyTag.json"
}
```

The JSON Schema is available on github here:

- [DummyTag.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/GSA_oM/DummyTag.json)
