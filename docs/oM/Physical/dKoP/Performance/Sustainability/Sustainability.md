---
title: Sustainability
---

# <small>BH.oM.dKoP.</small>**Sustainability**



## Class structure

### Implemented interfaces and base types

???+ bhom "The Sustainability is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKoPObject](/api/oM/Physical/dKoP/IdKoPObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| NRM2 | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| EPDCertification | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| EmbodiedCarbon | [EmbodiedCarbon](/api/oM/Physical/dKoP/Performance/Sustainability/EmbodiedCarbon) | - | - |
| SustainableSourcingCertification | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Sustainability : BH.oM.dKoP.IdKoPObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The C# class definition is available on github:

- [Sustainability.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Performance\Sustainability\Sustainability.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/Sustainability.json"
}
```

The JSON Schema is available on github here:

- [Sustainability.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/Sustainability.json)
