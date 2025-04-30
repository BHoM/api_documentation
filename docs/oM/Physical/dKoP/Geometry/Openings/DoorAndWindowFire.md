---
title: DoorAndWindowFire
---

# <small>BH.oM.dKoP.</small>**DoorAndWindowFire**



## Class structure

### Implemented interfaces and base types

???+ bhom "The DoorAndWindowFire is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKoPObject](/api/oM/Physical/dKoP/IdKoPObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| FireResistance | [FireResistancePeriod](/api/oM/Physical/dKoP/Perfomance/Enums/FireResistancePeriod) | - | - |
| SurfaceSpreadOfFlame | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Reaction to fire, smoke propagation, flaming droplets and particles. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class DoorAndWindowFire : BH.oM.dKoP.IdKoPObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [DoorAndWindowFire.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Geometry\Openings\DoorAndWindowFire.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/DoorAndWindowFire.json}
```

The JSON Schema is available on github here:

- [DoorAndWindowFire.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/DoorAndWindowFire.json)
