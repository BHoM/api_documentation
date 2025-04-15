---
title: ElectricalConnector
---

# MEP.Equipment.Parts.ElectricalConnector

Electrical Connectors are the devices (motors, disconnects/isolators) that serve as a source of power for mechanical equipment

## Class structure

### Implemented interfaces and base types

???+ bhom "The ElectricalConnector in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)
    -  MEP.Equipment.Parts.[IPart](/documentation/oM/Analytical/MEP/Equipment/Parts/IPart)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| MotorHorsePower | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Motor Horsepower indicates the power required for the electrical connector without any power losses | - |
| BrakeHorsePower | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Brake Horsepower indicates the power required for the electrical connector including any power losses | - |
| FullLoadAmps | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Full Load Amps indicates the amount of current drawn by the motor when running, and is used for sizing the conductors | - |
| MaximumOvercurrentProtection | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Maximum Overcurrent Protection indicates the maximum size of the fuse or breaker | - |
| Phase | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Phase denotes the distribution of alternating current (example: single or three phase) | - |
| Frequency | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Frequency is the rate of oscillation | - |
| Voltage | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Voltage denotes the electrical potential difference (120/208, 277/480 (US), 240, 415 (UK) | - |
| EmergencyPower | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Emergency Power is a boolean value (true/false) that denotes whether a device requires backup from an emergency power source | - |
| StandBy | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Optional Standby is a boolean value (true/false) that denotes whether a device requires backup from a secondary power source, for non-critical systems | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [ElectricalConnector.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/Equipment\Parts\ElectricalConnector.cs)

All history and changes of the class can be found by inspection the history.
