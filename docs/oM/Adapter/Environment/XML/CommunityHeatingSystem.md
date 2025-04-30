---
title: CommunityHeatingSystem
---

# <small>BH.oM.Environment.SAP.XML.</small>**CommunityHeatingSystem**



## Class structure

### Implemented interfaces and base types

???+ bhom "The CommunityHeatingSystem is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| CommunityHeatingName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The name of the community heating system. | - |
| CommunityHeatingCO2EmissionFactor | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | the community heating CO2 emission factor. | - |
| CommunityHeatingPrimaryEnergyFactor | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The community heating Primary Energy Factor. | - |
| CommunityHeatingUse | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Specifies what kind of heating the community system is used for. | - |
| IsCommunityHeatingCylinderInDwelling | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Community heating, hot water cylinder in dwelling?. | - |
| IsHeatInterfaceUnitInDwelling | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Heat interface unit in Dwelling?. | - |
| HeatInterfaceUnitIndexNumber | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Heat Interface Unit index number, if present. | - |
| CommunityHeatingDistributionType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Community heating distribution. | - |
| CommunityHeatSources | [CommunityHeatSources](/api/oM/Adapter/Environment/XML/CommunityHeatSources) | . | - |
| CommunityHeatingDistributionLossFactor | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Used when Community-Heating-Distribution-Type is calculated. | - |
| ChargingLinkedToHeatUse | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Used for hot-water-only systems. | - |
| HeatNetworkIndexNumber | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Index number of heat network, if applicable. | - |
| SubNetworkName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The name by which the sub community heat network is known. | - |
| HeatNetworkExisting | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Whether the heat network is existing or new. | - |
| HeatNetworkAssessedNew | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Whether the heat network is existing or new. | - |


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
public class CommunityHeatingSystem : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: SAP_oM.dll

The class is defined in C#. The class definition is available on github:

- [CommunityHeatingSystem.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/XML\CommunityHeatingSystem.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/XML/CommunityHeatingSystem.json}
```

The JSON Schema is available on github here:

- [CommunityHeatingSystem.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/XML/CommunityHeatingSystem.json)
