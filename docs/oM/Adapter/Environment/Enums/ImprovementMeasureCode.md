---
title: ImprovementMeasureCode
---

# <small>BH.oM.Environment.SAP.</small>**ImprovementMeasureCode**

Code which indicates an improvement measure for a property.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| LoftInsulation |  -  |
| FlatRoofInsulation |  -  |
| RoomInRoofInsulation |  -  |
| CavityWallInsulation |  -  |
| HotWaterCylinderInsulation |  -  |
| Draughtproofing |  -  |
| LowEnergyLights |  -  |
| CylinderThermostat |  -  |
| HeatingControlsForWetCentralHeatingSystem |  -  |
| HeatingControlsForWarmAirSystem |  -  |
| UpgradeBoiler |  -  |
| SameFuel |  -  |
| Biomasboiler |  -  |
| BiomasboilerAsAlternativeImprovement |  -  |
| BiomassRoomHeaterWithBoiler |  -  |
| NewOrReplacementFanAssistedStorageHeaters |  -  |
| NewOrReplacementHighHeatRetentionStorageHeaters |  -  |
| ReplacementWarmAirUnit |  -  |
| SolarWaterHeating |  -  |
| ReplacementDoubleGlazedWindows |  -  |
| ReplacementDoubleGlazingUnits |  -  |
| SecondaryGlazing |  -  |
| SolidWallInsulation |  -  |
| ExternalInsulationWithCavityWallInsulation |  -  |
| CondensingOilBoiler |  -  |
| ChangeHeatingToBandAGasCondensingBoilerNoFuelSwitch |  -  |
| ChangeHeatingToBandAGasCondensingBoilerFuelSwitch |  -  |
| FlueGasHeatRecovery |  -  |
| Photovoltaics |  -  |
| WindTurbineRoofMounted |  -  |
| WindTurbineOnMast |  -  |
| FloorInsulation |  -  |
| InsulatedDoors |  -  |
| InstantaneousWasteWaterHeatRecovery |  -  |
| StorageWasteWaterHeatRecovery |  -  |
| AirOrGroundSourceHeatPump |  -  |
| AirOrGroundSourceHeatPumpWithUnderfloorHeating |  -  |
| MicroCHP |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum ImprovementMeasureCode : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: SAP_oM.dll

The enum is defined in C#. The class definition is available on github:

- [ImprovementMeasureCode.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Enums\ImprovementMeasureCode.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/ImprovementMeasureCode.json"
}
```

The JSON Schema is available on github here:

- [ImprovementMeasureCode.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/ImprovementMeasureCode.json)
