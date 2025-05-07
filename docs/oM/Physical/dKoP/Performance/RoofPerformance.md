---
title: RoofPerformance
---

# <small>BH.oM.dKoP.</small>**RoofPerformance**



## Class structure

### Implemented interfaces and base types

???+ bhom "The RoofPerformance is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKoPObject](/api/oM/Physical/dKoP/IdKoPObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Sustainability | [Sustainability](/api/oM/Physical/dKoP/Performance/Sustainability/Sustainability) | - | - |
| Durability | [Durability](/api/oM/Physical/dKoP/Performance/Durability/Durability) | - | - |
| Acoustics | [AcousticsWallAndRoof](/api/oM/Physical/dKoP/Performance/Acoustics/AcousticsWallAndRoof) | - | - |
| Fire | [Fire](/api/oM/Physical/dKoP/Performance/Fire/Fire) | - | - |
| ThermalPerformance | [ThermalPerformance](/api/oM/Physical/dKoP/Performance/ThermalPerformance/ThermalPerformance) | - | - |
| AirPermability | [AirPermeability](/api/oM/Physical/dKoP/Performance/AirPermeability/AirPermeability) | - | - |
| Loading | [Loading](/api/oM/Physical/dKoP/Performance/Loading/Loading) | - | - |
| Services | [Services](/api/oM/Physical/dKoP/Performance/Services/Services) | - | - |
| Finishes | [FinishesRoof](/api/oM/Physical/dKoP/Performance/Finishes/FinishesRoof) | - | - |
| AdditionalFeatures | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RoofPerformance : BH.oM.dKoP.IdKoPObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The C# class definition is available on github:

- [RoofPerformance.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Performance\RoofPerformance.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/RoofPerformance.json"
}
```

The JSON Schema is available on github here:

- [RoofPerformance.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/RoofPerformance.json)
