---
title: TypeOfHeatingFuel
---

# <small>BH.oM.Environment.SAP.</small>**TypeOfHeatingFuel**

Code which indicates the type of heating fuel, as defined in SAP table 12.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| MainsGas |  -  |
| BulkLPG |  -  |
| BottledLPG |  -  |
| HeatingOil |  -  |
| Biogas |  -  |
| LNG |  -  |
| LPGSpecialCondition |  -  |
| SolidFuelMineralAndWood |  -  |
| HouseCoal |  -  |
| ManufacturedSmokelessFuel |  -  |
| Anthracite |  -  |
| WoodLogs |  -  |
| WoodChips |  -  |
| WoodPelletsSecondaryHeating |  -  |
| WoodPelletsMainHeating |  -  |
| ElectricitySoldToGrid |  -  |
| ElectricityDisplacedFromGrid |  -  |
| ElectricityUnspecTariff |  -  |
| CommunityHeatPump |  -  |
| CommunityBoilersWaste |  -  |
| CommunityBoilersBiomass |  -  |
| CommunityBoilersBiogas |  -  |
| CommunityWastePowerStations |  -  |
| CommunityGeothermal |  -  |
| CommunityCHP |  -  |
| CommunityElectricityCHP |  -  |
| CommunityElectricityNetwork |  -  |
| CommunityMainsGas |  -  |
| CommunityLPG |  -  |
| CommunityOil |  -  |
| CommunityCoal |  -  |
| CommunityB30D |  -  |
| CommunityBoilersMineralOilBiodiesel |  -  |
| CommunityBoilersBiodiesel |  -  |
| CommunityBiodieselVegetableOil |  -  |
| Biodiesel |  -  |
| BiodieselUsedCookingOil |  -  |
| BiodieselVegetableOil |  -  |
| MineralOilLiquidBiofuel |  -  |
| B30K |  -  |
| Bioethanol |  -  |
| FuelDataFromPcdb |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum TypeOfHeatingFuel : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: SAP_oM.dll

The enum is defined in C#. The class definition is available on github:

- [TypeOfHeatingFuel.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Enums\TypeOfHeatingFuel.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/TypeOfHeatingFuel.json}
```

The JSON Schema is available on github here:

- [TypeOfHeatingFuel.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/TypeOfHeatingFuel.json)
