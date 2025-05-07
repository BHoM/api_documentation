---
title: Heating
---

# <small>BH.oM.Environment.SAP.XML.</small>**Heating**



## Class structure

### Implemented interfaces and base types

???+ bhom "The Heating is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| MainHeatingDetails | [MainHeatingDetails](/api/oM/Adapter/Environment/XML/MainHeatingDetails) | . | - |
| SecondaryHeatingCategory | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Category of heating system for the secondary heating system. | - |
| SecondaryHeatingDataSource | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Source of secondary heating system data; only if secondary heating system. | - |
| SecondaryHeatingEfficiency | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| SecondaryHeatingCommisioningCertificate | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Secondary heating system commisioning certificate number. | - |
| SecondaryHeatingInstallationEngineer | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Secondary heating installation engineer registration reference. | - |
| SecondaryHeatingCode | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Type of secondary heating present in the property. | - |
| SecondaryFuelType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The type of fuel used to power the secondary heating e.g. Gas, Electricity; only if required. | - |
| SecondaryHeatingPCDFFuelIndex | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | PCDF index number of the fuel type, only if Secondary-Fuel-Type is 99 (fuel from database). | - |
| SecondaryHeatingFlueType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Secondary flue type; only if secondary efficiency is manufacturer declaration and if there is a flue. | - |
| WaterHeatingCode | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The type of Water Heating present in the Property. | - |
| WaterFuelType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The type of fuel used to power the central heating e.g. Gas, Electricity.  Not used if water system is main or secondary system. | - |
| ThermalStore | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The type of thermal store; not used if main heating system is community heating scheme. | - |
| ImmersionHeatingType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The type of immersion heating; only if immersion. | - |
| IsHeatPumpAssistedByImmersion | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Heat pump assisted by immersion?  Only if main heating is heat pump and water heating from heat pump. | - |
| IsImmersionForSummerUse | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Immersion for summer use?  Only if main heating is solid fuel fire or room heater with boiler. | - |
| HotWaterStoreManufacturer | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | StoreManufacturerName. | - |
| HotWaterStoreModel | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | StoreManufacturerName. | - |
| HotWaterStoreCommissioningCertificate | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Store comissioning certificate number. | - |
| HotWaterStoreInstallerEngineerRegistration | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Store installer engineer registration number. | - |
| HotWaterStoreSize | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Hot water store size in litres; if there is a hot water store.  Store refers to hot water store type which can be cylinder (if thermal store is 'none'), hot-water only thermal store or integrated thermal store.  Not applicable if (a) combi boiler whose data source database or (b) instantaneous combi boiler or (c) combi boiler from SAP table or (d) instantaneous water heater. | - |
| HasHotWaterCylinder | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Hot water cylinder?. | - |
| HotWaterStoreHeatTransferArea | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Used when a heat pump is associated with a separate and specified hot water vessel. | - |
| HotWaterStoreHeatLossSource | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The source of the hot water store heat loss information; if there is a hot water store.  Not applicable if (a) combi boiler whose data source database or (b) instantaneous combi boiler or (c) combi boiler from SAP table or (d) instantaneous water heater. | - |
| HotWaterStoreHeatLoss | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Hot water store declared loss in kWh/day; only if there is a hot water store and if manufacturer declared loss.  Not applicable if (a) combi boiler whose data source database or (b) instantaneous combi boiler or (c) combi boiler from SAP table or (d) instantaneous water heater. | - |
| HotWaterStoreInsulationType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Hot water store insulation; only if there is a hot water store and if loss from SAP table.  Not applicable if (a) combi boiler whose data source database or (b) instantaneous combi boiler or (c) combi boiler from SAP table or (d) instantaneous water heater. | - |
| HotWaterInsulationThickness | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Hot water store insulation thickness in mm; only if there is a hot water store and if loss from SAP table.  Not applicable if (a) combi boiler whose data source database or (b) instantaneous combi boiler or (c) combi boiler from SAP table or (d) instantaneous water heater. | - |
| PrimaryPipeworkInsulation | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Not applicable to combi boiler or instantaneous water heater. | - |
| HasCylinderThermostat | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Hot water cylinder thermostat?  Not applicable if combi boiler or instantaneous water heater. | - |
| IsCylinderInHeatedSpace | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Hot water cylinder in heated space?  Not applicable if combi boiler or instantaneous water heater. | - |
| IsHotWaterSeperatlyTimed | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | &gt;Hot water separately timed?  Not applicable if combi boiler or instantaneous water heater. | - |
| IsHeatPumpInstalledToMIS | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Is heat pump installed to MIS standard?  Only if water heating from hot water only heat pump. | - |
| IsSecondaryHeatingHETASApproved | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Secondary heating appliance is HETAS approved?  Only if solid fuel. | - |
| IsThermalStoreNearBoiler | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Thermal store connected to boiler by no more than 1.5 m of insulated pipework?  Only if thermal store.  Not applicable if combi boiler or instantaneous water heater. | - |
| IsThermalStoreOrCPSUInAiringCupboard | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Thermal store or CPSU in airing cupboard?  Only if (a) boiler with integrated or hot-water-only thermal store, or (b) main heating is CPSU. | - |
| HotWaterControlsManufacturer | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| HotWaterControlsModel | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| CommunityHeatingSystems | [CommunityHeatingSystems](/api/oM/Adapter/Environment/XML/CommunityHeatingSystems) | Community heating systems used by the property. | - |
| HeatingDesignWaterUse | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| MainHeatingSystemsInteraction | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| SecondaryHeatingDeclaredValues | [HeatingDeclaredValues](/api/oM/Adapter/Environment/XML/HeatingDeclaredValues) | Use when manufacturer’s declared values. | - |
| SolarHeatingDetails | [SolarHeatingDetails](/api/oM/Adapter/Environment/XML/SolarHeatingDetails) | . | - |
| StorageWHRS | [StorageWWHRS](/api/oM/Adapter/Environment/XML/StorageWWHRS) | . | - |
| HasFixedAirConditioning | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Fixed air conditioning?. | - |
| ShowerOutlets | [ShowerOutlets](/api/oM/Adapter/Environment/XML/ShowerOutlets) | . | - |
| NumberBaths | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| NumberBathsWWHRS | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| InstantaneousWHRS | [InstantaneousWWHRS](/api/oM/Adapter/Environment/XML/InstantaneousWWHRS) | Waste Water Heat Recovery System. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Heating : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: SAP_oM.dll

The C# class definition is available on github:

- [Heating.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/XML\Heating.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/XML/Heating.json"
}
```

The JSON Schema is available on github here:

- [Heating.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/XML/Heating.json)
