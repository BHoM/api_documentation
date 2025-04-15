---
title: MainHeating
---

# Environment.SAP.XML.MainHeating



## Class structure

### Implemented interfaces and base types

???+ bhom "The MainHeating in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| MainHeatingNumber | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Identifies the main heating as system 1 or system 2.  System 1 must always be present, system 2 is included only when there are two systems. | - |
| MainHeatingCategory | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Category of heating system for the main heating system. | - |
| MainHeatingFraction | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Fraction of main heating provided by this system, is 1 if only one main system. | - |
| MainHeatingDataSource | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Source of main heating system data. | - |
| MainHeatingCode | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Main heating code; when heating data source is SAP table. | - |
| MainHeatingManufacturer | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| MainHeatingModel | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| MainHeatingCommissioningCertificate | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| MainHeatingInstallationEngineer | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| MainFuelType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The type of fuel used to power the central heating e.g. Gas, Electricity; not used if main heating system is community heating scheme. | - |
| MainHeatingControl | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Type of Main Control for the Heating System. | - |
| IsCondensingBoiler | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Is the boiler a condensing boiler?  If boiler efficiency is manufacturer declaration. | - |
| CondensingBoilerHeatDistribution | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The temperature distribution of the condensing boiler. | - |
| HeatEmitterType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Identifies the means by which the central heating system (if present) emits heat; only when wet system (radiators or underfloor). | - |
| UnderfloorHeatEmitterType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Means by which an underfloor heating system (if present) emits heat; only when wet system (underfloor). | - |
| MainHeatingFlueType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The type of main heating flue; only if flued appliance. | - |
| IsFlueFanPresent | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Indicates whether the heating system contains a fan flue; only if boiler. | - |
| IsCentralHeatingPumpInHeatedSpace | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Central heating pump in heated space?  Only when wet system (radiators or underfloor). | - |
| IsOilPumpInHeatedSpace | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Oil pump in heated space?  Only if oil boiler. | - |
| IsInterLockedSystem | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Interlocked system?  Only when wet system (radiators or underfloor). | - |
| HasSeparateDelayedStart | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | True if there is a delayed start control separate from a controller in the database. | - |
| IsMainHeatingHETASApproved | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Main heating appliance is HETAS approved?  Only if solid fuel. | - |
| HeatPumpHeatDistribution | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The temperature distribution of the heat pump, for wet systems only. | - |
| GasOrOilBoilerType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Boiler type; if boiler efficiency is manufacturer declaration and fuel is gas or oil. | - |
| CombiBoilerType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Combi boiler type; if it is a combi boiler and boiler efficiency is manufacturer declaration. | - |
| CaseHeatEmission | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Case heat emission at full load in kW; if it is a range cooker boiler and boiler efficiency is manufacturer declaration. | - |
| HeatTransferToWater | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Heat transfer to water at full load in kW; if it is a range cooker boiler and boiler efficiency is manufacturer declaration. | - |
| SolidFuelBoilerType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Boiler type; if boiler efficiency is manufacturer declaration and fuel is solid. | - |
| PCDFFuelIndex | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | PCDF index number of the fuel type, only if Main-Fuel-Type is 99 (fuel from database). | - |
| BoilerFuelFeed | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The type of boiler fuel feed; only if solid fuel boiler with manufacturer declaration. | - |
| ElectricCPSUOperatingTemperature | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Electric CPSU operating temperature in Celcius; only if main heating is electric CPSU. | - |
| BurnerControl | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| EfficiencyType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| MainHeatingEfficiencyWinter | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | To be used if main heating data is manufacturer declaration and Efficiency-Type is winter and summer. | - |
| MainHeatingEfficiencySummer | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | To be used if main heating data is manufacturer declaration and Efficiency-Type is winter and summer. | - |
| MainHeatingEfficiency | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | If main heating is any system other than heat network. | - |
| MainHeatingSystemType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| HasFGHRS | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Flue Gas Heat Recovery System. | - |
| CentralHeatingPumpAge | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Included for systems with a central heating pump, i.e. wet system. | - |
| MainHeatingIndexNumber | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The ID of the heating system from the product database, if system from database. | - |
| FGHRSIndexNumber | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | FGHRS index number; only if FGHRS. | - |
| FGHRSEnergySource | [EnergySource](/documentation/oM/Adapter/Environment/SAP/XML/EnergySource) | . | - |
| MainHeatingDeclaredValues | [HeatingDeclaredValues](/documentation/oM/Adapter/Environment/SAP/XML/HeatingDeclaredValues) | . | - |
| StorageHeaters | [StorageHeaters](/documentation/oM/Adapter/Environment/SAP/XML/StorageHeaters) | . | - |
| EmitterTemperature | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gas and oil boilers and heat pump from database: 0, 1, 3 or 4. Other heat pump 0, 2 or 4. Other systems NA. | - |
| MCSInstalledHeatPump | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Whether heat pump was installed under the Microgeneration Certification Scheme. | - |
| ControlIndexNumber | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The ID of the time and temperature zone control from the product database. | - |
| HeatingControllerFunction | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| HeatingControllerEcodesignClass | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| HeatingControllerManufacturer | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| HeatingControllerModel | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |


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

- [MainHeating.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/XML/MainHeating.cs)

All history and changes of the class can be found by inspection the history.
