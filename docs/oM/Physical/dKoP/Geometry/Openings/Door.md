---
title: Door
---

# <small>BH.oM.dKoP.</small>**Door**



## Class structure

### Implemented interfaces and base types

???+ bhom "The Door is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IWallOpening](/api/oM/Physical/dKoP/Geometry/Openings/IWallOpening)
    -  BH.oM.dKoP.[IdKoPObject](/api/oM/Physical/dKoP/IdKoPObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| StructuralWidth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| StructuralHeight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| PositionAlongWall | [ParameterPoint](/api/oM/Physical/dKoP/Geometry/ParameterPoint) | - | - |
| ConfirmationGeometryRequirementsAreMet | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| Fire | [DoorAndWindowFire](/api/oM/Physical/dKoP/Geometry/Openings/DoorAndWindowFire) | - | - |
| AcousticPerformance | [DoorAndWindowAcoustics](/api/oM/Physical/dKoP/Geometry/Openings/DoorAndWindowAcoustics) | - | - |
| ThermalPerformance | [DoorAndWindowThermalPerformance](/api/oM/Physical/dKoP/Geometry/Openings/DoorAndWindowThermalPerformance) | - | - |
| DoorFinish | [DoorFinish](/api/oM/Physical/dKoP/Geometry/Openings/DoorFinish) | - | - |
| FrameFinish | [OpeningPartFinish](/api/oM/Physical/dKoP/Geometry/Openings/OpeningPartFinish) | - | - |
| DoorFurniture | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| ArchitraveSpecification | [Architrave](/api/oM/Physical/dKoP/Geometry/Enums/Architrave) | - | - |
| DirectionOfOpening | [Direction](/api/oM/Physical/dKoP/Geometry/Enums/Direction) | - | - |
| FinishesStyleAndOpeningDirection | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Product | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Door : BH.oM.dKoP.IWallOpening, BH.oM.dKoP.IdKoPObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [Door.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Geometry\Openings\Door.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/Door.json}
```

The JSON Schema is available on github here:

- [Door.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/Door.json)
