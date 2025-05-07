---
title: SurfaceSpreadOfFlame
---

# <small>BH.oM.dKoP.</small>**SurfaceSpreadOfFlame**



## Class structure

### Implemented interfaces and base types

???+ bhom "The SurfaceSpreadOfFlame is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKoPObject](/api/oM/Physical/dKoP/IdKoPObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ReactionToFireSmokePropagationFlamingDropletsAndParticles | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Documentation | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class SurfaceSpreadOfFlame : BH.oM.dKoP.IdKoPObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The C# class definition is available on github:

- [SurfaceSpreadOfFlame.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Performance\Fire\SurfaceSpreadOfFlame.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/SurfaceSpreadOfFlame.json"
}
```

The JSON Schema is available on github here:

- [SurfaceSpreadOfFlame.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/SurfaceSpreadOfFlame.json)
