---
title: FloorGeometry
---

# <small>BH.oM.dKoP.</small>**FloorGeometry**



## Class structure

### Implemented interfaces and base types

???+ bhom "The FloorGeometry is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKoPObject](/api/oM/Physical/dKoP/IdKoPObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SettingOut | [SettingOut](/api/oM/Physical/dKoP/Geometry/SettingOut) | - | - |
| ExternalDimensions | [FloorDimensions](/api/oM/Physical/dKoP/Geometry/FloorDimensions) | - | - |
| Staircases | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Staircase](/api/oM/Physical/dKoP/Geometry/Openings/Staircase)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class FloorGeometry : BH.oM.dKoP.IdKoPObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The C# class definition is available on github:

- [FloorGeometry.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Geometry\FloorGeometry.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/FloorGeometry.json"
}
```

The JSON Schema is available on github here:

- [FloorGeometry.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/FloorGeometry.json)
