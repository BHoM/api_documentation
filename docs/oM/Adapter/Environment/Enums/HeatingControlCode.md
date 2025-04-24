---
title: HeatingControlCode
---

# <small>BH.oM.Environment.</small>**HeatingControlCode**

Code which indicates the type of boiler fuel feed.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| None |  -  |
| Boiler_OnlyDHW |  -  |
| Boiler_NoTimeOrThermostaticControl |  -  |
| Boiler_ProgrammerOnly |  -  |
| Boiler_ThermostatOnly |  -  |
| Boiler_ProgrammerAndThermostat |  -  |
| Boiler_ProgrammerAndMoreThanOneThermostat |  -  |
| Boiler_ThermostatAndTRVs |  -  |
| Boiler_ProgrammerThermostatAndTRVs |  -  |
| Boiler_TRVsAndBypass |  -  |
| Boiler_ProgrammerTRVsAndBypass |  -  |
| Boiler_ProgrammerTRVsAndFlowSwitch |  -  |
| Boiler_ProgrammerTRVsAndEnergyManager |  -  |
| Boiler_TimeAndTempControlByPlumbingAndElectrical |  -  |
| Boiler_TimeAndTempControlByPCDB |  -  |
| HeatPump_NoTimeOrThermostaticControl |  -  |
| HeatPump_ProgrammerOnly |  -  |
| HeatPump_ThermostatOnly |  -  |
| HeatPump_ProgrammerAndThermostat |  -  |
| HeatPump_ProgrammerAndMoreThanOneThermostat |  -  |
| HeatPump_ThermostatAndTRVs |  -  |
| HeatPump_ProgrammerThermostatAndTRVs |  -  |
| HeatPump_ProgrammerTRVsAndBypass |  -  |
| HeatPump_TimeAndTempControlByPlumbingAndElectrical |  -  |
| HeatPump_TimeAndTempControlByPCDB |  -  |
| HeatNetworks_FlatRateNoThermostaticControl |  -  |
| HeatNetworks_FlatRateProgrammerOnly |  -  |
| HeatNetworks_FlatRateThermostatOnly |  -  |
| HeatNetworks_FlatRateProgrammerAndThermostat |  -  |
| HeatNetworks_FlatRateThermostatAndTRVs |  -  |
| HeatNetworks_FlatRateTRVs |  -  |
| HeatNetworks_FlatRateProgrammerAndTRVs |  -  |
| HeatNetworks_FlatRateProgrammerAndMoreThanOneThermostat |  -  |
| HeatNetworks_ChargingSystemThermostatOnly |  -  |
| HeatNetworks_ChargingSystemProgrammerAndThermostat |  -  |
| HeatNetworks_ChargingSystemThermostatAndTRVs |  -  |
| HeatNetworks_ChargingSystemTRVs |  -  |
| HeatNetworks_ChargingSystemProgrammerAndTRVs |  -  |
| HeatNetworks_ChargingSystemProgrammerAndMoreThanOneThermostat |  -  |
| ElectricStorage_Manual |  -  |
| ElectricStorage_Automatic |  -  |
| ElectricStorage_CelectType |  -  |
| ElectricStorage_ControlsForHighHeatRetention |  -  |
| WarmAir_NoTimeOrThermostaticControl |  -  |
| WarmAir_ProgrammerOnly |  -  |
| WarmAir_ThermostatOnly |  -  |
| WarmAir_ProgrammerAndThermostat |  -  |
| WarmAir_ProgrammerAndMoreThanOneThermostat |  -  |
| WarmAir_TimeAndTemperatureZoneControl |  -  |
| RooomHeater_NoThermostaticControl |  -  |
| RooomHeater_ApplianceThermostats |  -  |
| RooomHeater_ProgrammerAndApplianceThermostats |  -  |
| RooomHeater_RoomThermostatsOnly |  -  |
| RooomHeater_ProgrammerAndRoomThermostats |  -  |
| Other_NoTimeOrThermostaticControl |  -  |
| Other_ProgrammerOnly |  -  |
| Other_RoomThermostatOnly |  -  |
| Other_ProgrammerAndRoomThermostat |  -  |
| Other_TemperatureZoneControl |  -  |
| Other_TimeAndTemperatureZoneControl |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum HeatingControlCode : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: SAP_oM.dll

The enum is defined in C#. The class definition is available on github:

- [HeatingControlCode.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Enums\HeatingControlCode.cs)

All history and changes of the class can be found by inspection the history.
