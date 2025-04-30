---
title: TypeOfThermalBridge
---

# <small>BH.oM.Environment.SAP.</small>**TypeOfThermalBridge**

Code which indicates a particular type of thermal bridge.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| NotDefined |  -  |
| SteelLintelWithPerforatedSteelBasePlate |  -  |
| OtherLintels |  -  |
| Sill |  -  |
| Jamb |  -  |
| GroundFloor_Normal |  -  |
| IntermediateFloorWithinDwelling |  -  |
| PartyFloorBetweenDwellings |  -  |
| BalconyWithinADwelling |  -  |
| BalconyBetweenDwellings |  -  |
| WallInsulationContinuous |  -  |
| Eaves_InsulationAtCeilingLevel |  -  |
| Eaves_InsulationAtRafterLevel |  -  |
| Gable_InsulationAtCeilingLevel |  -  |
| Gable_InsulationAtRafterLevel |  -  |
| FlatRoof |  -  |
| FlatRoofWithParapet |  -  |
| Corner_Normal |  -  |
| Corner_Inverted |  -  |
| PartyWallBetweenDwellings |  -  |
| GroundFloor_Inverted |  -  |
| ExposedFloor_Normal |  -  |
| ExposedFloor_Inverted |  -  |
| BasementFloor |  -  |
| BalconyWithinOrBetweenDwellings |  -  |
| Eaves_InsulationAtCeilingLevel_Inverted |  -  |
| StaggeredPartyWall |  -  |
| GroundFloor |  -  |
| IntermediateFloorWithinADwelling |  -  |
| IntermediateFloorBetweenDwellings |  -  |
| Roof_InsulationAtCeilingLevel |  -  |
| Roof_InsulationAtRafterLevel |  -  |
| HeadOfRoofWindow |  -  |
| SillOfRoofWindow |  -  |
| JambOfRoofWindow |  -  |
| Ridge_VaultedCeiling |  -  |
| Ridge_Inverted |  -  |
| FlatCeiling |  -  |
| FlatCeiling_Inverted |  -  |
| RoofToWall_Rafter |  -  |
| RoofToWall_FlatCeiling |  -  |
| AllOtherRoofOrRoomInRoofJunctions |  -  |
| UpstandsOfRooflights |  -  |
| OtherType1 |  -  |
| OtherType2 |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum TypeOfThermalBridge : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: SAP_oM.dll

The enum is defined in C#. The class definition is available on github:

- [TypeOfThermalBridge.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Enums\TypeOfThermalBridge.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/TypeOfThermalBridge.json}
```

The JSON Schema is available on github here:

- [TypeOfThermalBridge.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/TypeOfThermalBridge.json)
