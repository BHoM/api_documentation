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
