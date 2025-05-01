---
title: PropertyDetails
---

# <small>BH.oM.Environment.SAP.XML.</small>**PropertyDetails**



## Class structure

### Implemented interfaces and base types

???+ bhom "The PropertyDetails is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| EnergySource | [EnergySource](/api/oM/Adapter/Environment/XML/EnergySource) | . | - |
| Heating | [Heating](/api/oM/Adapter/Environment/XML/Heating) | . | - |
| BuildingParts | [BuildingParts](/api/oM/Adapter/Environment/XML/BuildingParts) | Details of the significant building parts that comprise the main habitable building in the property. | - |
| Ventilation | [Ventilation](/api/oM/Adapter/Environment/XML/Ventilation) | Details of the means by which the building is ventilated | - |
| OpeningTypes | [OpeningTypes](/api/oM/Adapter/Environment/XML/OpeningTypes) | Types of exposed openings that make up a particular property. | - |
| PropertyType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The type of Property, such as House, Flat, Mansion, Maisonette etc. | - |
| BuiltForm | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The building type of the Property e.g. Detached, Semi-Detached, Terrace etc. Together with the Property Type, the Built Form provides a structured description of the property. | - |
| LivingArea | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The size of the living area in square metres.  The living area is the room marked on a plan as the lounge or living room, or the largest public room (irrespective of usage by particular occupants), together with any rooms not separated from the lounge or living room by doors, and including any cupboards directly accessed from the lounge or living room. Living area does not, however, extend over more than one storey, even when stairs enter the living area directly. | - |
| LowestStoreyArea | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The Area of the lowest storey in square meters including unheated or communal areas such as garages or corridors. | - |
| Orientation | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The orientation of the front of the property. | - |
| ColdWaterSource | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | What is the cold water source?  Either mains or header tank. | - |
| WindowsOvershading | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Average amount of overshading of windows. | - |
| ThermalMassParameter | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Average thermal mass parameter for the dwelling in kJ/m�K. If omitted it is calculated using the kappa values of each element. | - |
| IsInSmokeControlArea | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Is property in a smoke control area?  Only if a solid fuel appliance is used. | - |
| Lighting | [Lighting](/api/oM/Adapter/Environment/XML/Lighting) | Details of the main lighting for the property | - |
| ConservatoryType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Type of conservatory. | - |
| TerrainType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Terrain type. Needed for wind-turbines and for applying measures. | - |
| HasSpecialFeature | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | For backwards compatibility only, do not use. | - |
| SpecialFeatureDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | For backwards compatibility only, do not use. | - |
| EnergySavedOrGenerated | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | For backwards compatibility only, do not use. | - |
| SavedOrGeneratedFuel | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | For backwards compatibility only, do not use. | - |
| EnergyUsed | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | For backwards compatibility only, do not use. | - |
| EnergyUsedFuel | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | For backwards compatibility only, do not use. | - |
| AdditionalAllowableElectricityGeneration | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Additional allowable electricity generation applicable to this dwelling in kWh per square metre; only if Zero Carbon Home assessment. | - |
| IsDwellingExportCapable | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | . | - |
| GasSmartMeterPresent | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | . | - |
| ElectricitySmartMeterPresent | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | . | - |
| PVConnection | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| PVDiverter | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Diverter present. | - |
| BatteryCapacity | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Battery capacity capacity if diverter present | - |
| IsWindTurbineConnectedToDwellingMeter | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Whether the wind turbine is connected to the Dwelling's meter. | - |
| DeselectedImprovements | [DeselectedImprovements](/api/oM/Adapter/Environment/XML/DeselectedImprovements) | . | - |
| FlatDetails | [FlatDetails](/api/oM/Adapter/Environment/XML/FlatDetails) | Detials of location of flat in building | - |
| SpecialFeatures | [SpecialFeatures](/api/oM/Adapter/Environment/XML/SpecialFeatures) | . | - |
| DesignWaterUse | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Design limit for total water use. | - |
| Cooling | [Cooling](/api/oM/Adapter/Environment/XML/Cooling) | . | - |


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
public class PropertyDetails : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: SAP_oM.dll

The class is defined in C#. The class definition is available on github:

- [PropertyDetails.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/XML\PropertyDetails.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/XML/PropertyDetails.json"
}
```

The JSON Schema is available on github here:

- [PropertyDetails.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/XML/PropertyDetails.json)
