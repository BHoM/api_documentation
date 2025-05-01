---
title: PitchedRoofDimensions
---

# <small>BH.oM.dKoP.</small>**PitchedRoofDimensions**



## Class structure

### Implemented interfaces and base types

???+ bhom "The PitchedRoofDimensions is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKoPObject](/api/oM/Physical/dKoP/IdKoPObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Width | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| Span | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| Pitch | [Pitch](/api/oM/Physical/dKoP/Geometry/Enums/Pitch) | - | - |
| Overhang | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| HeightAtFascia | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Overall buildup. | - |
| InternalSpandrelPanel | [InternalSpandrelPanel](/api/oM/Physical/dKoP/Geometry/InternalSpandrelPanel) | - | - |
| GableEndPanel | [GableEndPanel](/api/oM/Physical/dKoP/Geometry/GableEndPanel) | - | - |
| ConfirmationGeometryRequirementsAreMet | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PitchedRoofDimensions : BH.oM.dKoP.IdKoPObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The C# class definition is available on github:

- [PitchedRoofDimensions.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Geometry\PitchedRoofDimensions.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/PitchedRoofDimensions.json"
}
```

The JSON Schema is available on github here:

- [PitchedRoofDimensions.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/PitchedRoofDimensions.json)
