---
title: CommunityHeatingSystem
---

# Environment.SAP.XML.CommunityHeatingSystem



## Class structure

### Implemented interfaces and base types

???+ bhom "The CommunityHeatingSystem in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


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
| CommunityHeatSources | [CommunityHeatSources](/documentation/oM/Adapter/Environment/SAP/XML/CommunityHeatSources) | . | - |
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
| Fragments | [FragmentSet](/documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [CommunityHeatingSystem.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/XML/CommunityHeatingSystem.cs)

All history and changes of the class can be found by inspection the history.
