---
title: HashFragment
---

# <small>BH.oM.Base.</small>**HashFragment**

Stores the hash of the parent BHoMObject.

## Class structure

### Implemented interfaces and base types

???+ bhom "The HashFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IHashFragment](/api/oM/Framework/Base/Interface/IHashFragment)
    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Hash | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Hash of the parent BHoMObject. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class HashFragment : BH.oM.Base.IHashFragment, BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: BHoM.dll

The class is defined in C#. The class definition is available on github:

- [HashFragment.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/HashFragment.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/BHoM/HashFragment.json"
}
```

The JSON Schema is available on github here:

- [HashFragment.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/BHoM/HashFragment.json)
