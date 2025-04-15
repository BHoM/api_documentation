---
title: PropertySummary
---

# Environment.SAP.XML.PropertySummary



## Class structure

### Implemented interfaces and base types

???+ bhom "The PropertySummary in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/om_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Walls | [PropertySummaryType](/om_documentation/oM/Adapter/Environment/SAP/XML/PropertySummaryType) | . | - |
| Roof | [PropertySummaryType](/om_documentation/oM/Adapter/Environment/SAP/XML/PropertySummaryType) | . | - |
| Floor | [PropertySummaryType](/om_documentation/oM/Adapter/Environment/SAP/XML/PropertySummaryType) | . | - |
| Windows | [PropertySummaryType](/om_documentation/oM/Adapter/Environment/SAP/XML/PropertySummaryType) | . | - |
| MainHeating | [PropertySummaryType](/om_documentation/oM/Adapter/Environment/SAP/XML/PropertySummaryType) | . | - |
| MainHeatingControls | [PropertySummaryType](/om_documentation/oM/Adapter/Environment/SAP/XML/PropertySummaryType) | . | - |
| SecondaryHeating | [PropertySummaryType](/om_documentation/oM/Adapter/Environment/SAP/XML/PropertySummaryType) | . | - |
| HotWater | [PropertySummaryType](/om_documentation/oM/Adapter/Environment/SAP/XML/PropertySummaryType) | . | - |
| Lighting | [PropertySummaryType](/om_documentation/oM/Adapter/Environment/SAP/XML/PropertySummaryType) | . | - |
| AirTightness | [PropertySummaryType](/om_documentation/oM/Adapter/Environment/SAP/XML/PropertySummaryType) | . | - |
| HasFixedAirConditioning | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | . | - |
| HasHotWaterCylinder | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | . | - |
| HasHeatedSeparateConservatory | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | . | - |
| DwellingType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| TotalFloorArea | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| MultipleGlazedPercentage | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Fraction of windows that are multiply glazed to nearest 1%. | - |
| MultipleGlazedPercentageNR | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | For backward compatibility only, do not use. | - |
| IsZeroCarbonHome | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Is dwelling a Zero Carbon Home?. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/om_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [PropertySummary.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/XML/PropertySummary.cs)

All history and changes of the class can be found by inspection the history.
