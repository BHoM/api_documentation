---
title: IFloorAndRoofOpening
---

# <small>BH.oM.dKoP.</small>**IFloorAndRoofOpening**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IFloorAndRoofOpening is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKoPObject](/api/oM/Physical/dKoP/IdKoPObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.dKoP.[LoftHatchOpening](/api/oM/Physical/dKoP/Geometry/Openings/LoftHatchOpening)
    - BH.oM.dKoP.[Staircase](/api/oM/Physical/dKoP/Geometry/Openings/Staircase)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ClearWidth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| ClearLength | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| SettingOut | [ParameterPoint](/api/oM/Physical/dKoP/Geometry/ParameterPoint) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IFloorAndRoofOpening : BH.oM.dKoP.IdKoPObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The C# interface definition is available on github:

- [IFloorAndRoofOpening.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Geometry\Openings\IFloorAndRoofOpening.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/IFloorAndRoofOpening.json"
}
```

The JSON Schema is available on github here:

- [IFloorAndRoofOpening.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/IFloorAndRoofOpening.json)
