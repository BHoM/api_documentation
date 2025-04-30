---
title: WaterHeatingCode
---

# <small>BH.oM.Environment.SAP.</small>**WaterHeatingCode**

Code which indicates the type of heating system, as defined in SAP table 4a.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| NoHotWaterSystem |  -  |
| MainSystem |  -  |
| SecondMainSystem |  -  |
| SecondarySystem |  -  |
| ElectricImmersion |  -  |
| SinglePointGas |  -  |
| MultiPointGas |  -  |
| ElectricInstantaneous |  -  |
| GasBoilerOnlyForWater |  -  |
| LiquidFuelOnlyForWater |  -  |
| SolidFuelOnlyForWater |  -  |
| RangeCookerGasSinglePermanent |  -  |
| RangeCookerGasSingleAutomatic |  -  |
| RangeCookerGasTwinPermanentPre1998 |  -  |
| RangeCookerGasTwinAutoPre1998 |  -  |
| RangeCookerGasTwinPermanentPost1998 |  -  |
| RangeCookerGasTwinAutoPost1998 |  -  |
| RangeCookerLiquidSingle |  -  |
| RangeCookerLiquidTwinPre1998 |  -  |
| RangeCookerLiquidTwinPost1998 |  -  |
| RangeCookerSolidIntegralOvenBoiler |  -  |
| RangeCookerSolidIndependentOvenBoiler |  -  |
| ElectricPumpOnlyWater |  -  |
| Boilers_RdSAP |  -  |
| CHP_RdSAP |  -  |
| HeatPumpRdSAP |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum WaterHeatingCode : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: SAP_oM.dll

The enum is defined in C#. The class definition is available on github:

- [WaterHeatingCode.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Enums\WaterHeatingCode.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/WaterHeatingCode.json}
```

The JSON Schema is available on github here:

- [WaterHeatingCode.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/WaterHeatingCode.json)
