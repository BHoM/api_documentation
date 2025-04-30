---
title: ProductInformation
---

# <small>BH.oM.dKoP.</small>**ProductInformation**



## Class structure

### Implemented interfaces and base types

???+ bhom "The ProductInformation is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKoPObject](/api/oM/Physical/dKoP/IdKoPObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Buildup | [Buildup](/api/oM/Physical/dKoP/ProductInformation/Buildup) | - | - |
| Documentation | [Documentation](/api/oM/Physical/dKoP/ProductInformation/Documentation) | - | - |
| OtherUSP | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ProductInformation : BH.oM.dKoP.IdKoPObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [ProductInformation.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/ProductInformation\ProductInformation.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/ProductInformation.json}
```

The JSON Schema is available on github here:

- [ProductInformation.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/ProductInformation.json)
