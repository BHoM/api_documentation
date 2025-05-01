---
title: IWallOpening
---

# <small>BH.oM.dKoP.</small>**IWallOpening**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IWallOpening is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKoPObject](/api/oM/Physical/dKoP/IdKoPObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.dKoP.[Door](/api/oM/Physical/dKoP/Geometry/Openings/Door)
    - BH.oM.dKoP.[Window](/api/oM/Physical/dKoP/Geometry/Openings/Window)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| StructuralWidth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| StructuralHeight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| PositionAlongWall | [ParameterPoint](/api/oM/Physical/dKoP/Geometry/ParameterPoint) | - | - |
| ConfirmationGeometryRequirementsAreMet | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| Fire | [DoorAndWindowFire](/api/oM/Physical/dKoP/Geometry/Openings/DoorAndWindowFire) | - | - |
| AcousticPerformance | [DoorAndWindowAcoustics](/api/oM/Physical/dKoP/Geometry/Openings/DoorAndWindowAcoustics) | - | - |
| ThermalPerformance | [DoorAndWindowThermalPerformance](/api/oM/Physical/dKoP/Geometry/Openings/DoorAndWindowThermalPerformance) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IWallOpening : BH.oM.dKoP.IdKoPObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The C# interface definition is available on github:

- [IWallOpening.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Geometry\Openings\IWallOpening.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/IWallOpening.json"
}
```

The JSON Schema is available on github here:

- [IWallOpening.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/IWallOpening.json)
