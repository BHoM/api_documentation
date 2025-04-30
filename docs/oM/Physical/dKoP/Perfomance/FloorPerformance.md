---
title: FloorPerformance
---

# <small>BH.oM.dKoP.</small>**FloorPerformance**



## Class structure

### Implemented interfaces and base types

???+ bhom "The FloorPerformance is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKoPObject](/api/oM/Physical/dKoP/IdKoPObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Sustainability | [Sustainability](/api/oM/Physical/dKoP/Perfomance/Sustainability) | - | - |
| Durability | [Durability](/api/oM/Physical/dKoP/Perfomance/Durability) | - | - |
| Acoustics | [AcousticsFloor](/api/oM/Physical/dKoP/Perfomance/AcousticsFloor) | - | - |
| Fire | [Fire](/api/oM/Physical/dKoP/Perfomance/Fire) | - | - |
| Compartmentation | [Compartmentation](/api/oM/Physical/dKoP/Perfomance/Compartmentation) | - | - |
| Loading | [Loading](/api/oM/Physical/dKoP/Perfomance/Loading/Loading) | - | - |
| Vibration | [Vibration](/api/oM/Physical/dKoP/Perfomance/Vibration) | - | - |
| Services | [Services](/api/oM/Physical/dKoP/Perfomance/Services/Services) | - | - |
| Finishes | [FinishesRoof](/api/oM/Physical/dKoP/Perfomance/Finishes/FinishesRoof) | - | - |
| AdditionalFeatures | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class FloorPerformance : BH.oM.dKoP.IdKoPObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [FloorPerformance.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Perfomance\FloorPerformance.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/FloorPerformance.json}
```

The JSON Schema is available on github here:

- [FloorPerformance.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/FloorPerformance.json)
