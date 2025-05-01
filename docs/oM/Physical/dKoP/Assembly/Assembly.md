---
title: Assembly
---

# <small>BH.oM.dKoP.</small>**Assembly**



## Class structure

### Implemented interfaces and base types

???+ bhom "The Assembly is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKoPObject](/api/oM/Physical/dKoP/IdKoPObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Procurement | [Procurement](/api/oM/Physical/dKoP/Assembly/Procurement) | - | - |
| Delivery | [Delivery](/api/oM/Physical/dKoP/Assembly/Delivery) | - | - |
| Packaging | [Packaging](/api/oM/Physical/dKoP/Assembly/Packaging) | - | - |
| Construction | [Construction](/api/oM/Physical/dKoP/Assembly/Construction) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Assembly : BH.oM.dKoP.IdKoPObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [Assembly.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Assembly\Assembly.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/Assembly.json"
}
```

The JSON Schema is available on github here:

- [Assembly.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/Assembly.json)
