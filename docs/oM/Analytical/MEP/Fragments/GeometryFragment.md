---
title: GeometryFragment
---

# <small>BH.oM.MEP.Fragments.</small>**GeometryFragment**



## Class structure

### Implemented interfaces and base types

???+ bhom "The GeometryFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Geometry | [IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class GeometryFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: MEP_oM.dll

The C# class definition is available on github:

- [GeometryFragment.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/Fragments\GeometryFragment.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/MEP_oM/Fragments/GeometryFragment.json"
}
```

The JSON Schema is available on github here:

- [GeometryFragment.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/MEP_oM/Fragments/GeometryFragment.json)
