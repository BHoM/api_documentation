---
title: Window
---

# <small>BH.oM.dKoP.</small>**Window**



## Class structure

### Implemented interfaces and base types

???+ bhom "The Window is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IWallOpening](/api/oM/Physical/dKoP/Geometry/Openings/IWallOpening)
    -  BH.oM.dKoP.[IdKoPObject](/api/oM/Physical/dKoP/IdKoPObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| StructuralWidth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| StructuralHeight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| PositionAlongWall | [ParameterPoint](/api/oM/Physical/dKoP/Geometry/ParameterPoint) | - | - |
| ConfirmationGeometryRequirementsAreMet | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| Fire | [DoorAndWindowFire](/api/oM/Physical/dKoP/Geometry/Openings/DoorAndWindowFire) | - | - |
| AcousticPerformance | [DoorAndWindowAcoustics](/api/oM/Physical/dKoP/Geometry/Openings/DoorAndWindowAcoustics) | - | - |
| ThermalPerformance | [DoorAndWindowThermalPerformance](/api/oM/Physical/dKoP/Geometry/Openings/DoorAndWindowThermalPerformance) | - | - |
| WindowStyle | [WindowStyle](/api/oM/Physical/dKoP/Geometry/Enums/WindowStyle) | - | - |
| OpeningType | [WindowOpeningType](/api/oM/Physical/dKoP/Geometry/Enums/WindowOpeningType) | - | - |
| InsideFinish | [OpeningPartFinish](/api/oM/Physical/dKoP/Geometry/Openings/OpeningPartFinish) | - | - |
| OutsideFinish | [OpeningPartFinish](/api/oM/Physical/dKoP/Geometry/Openings/OpeningPartFinish) | - | - |
| WindowFurniture | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| FinishesStyleAndOpeningDirection | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Product | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Window : BH.oM.dKoP.IWallOpening, BH.oM.dKoP.IdKoPObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The C# class definition is available on github:

- [Window.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Geometry\Openings\Window.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/Window.json"
}
```

The JSON Schema is available on github here:

- [Window.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/Window.json)
