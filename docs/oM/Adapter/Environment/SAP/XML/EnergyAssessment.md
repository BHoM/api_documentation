---
title: EnergyAssessment
---

# Environment.SAP.XML.EnergyAssessment



## Class structure

### Implemented interfaces and base types

???+ bhom "The EnergyAssessment in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| AssessmentDate | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | In the form yyyy-mm-dd | - |
| PropertySummary | [PropertySummary](/documentation/oM/Adapter/Environment/SAP/XML/PropertySummary) | - | - |
| EnergyUse | [EnergyUse](/documentation/oM/Adapter/Environment/SAP/XML/EnergyUse) | - | - |
| LowZeroCarbonEnergySources | [LowZeroCarbonEnergySources](/documentation/oM/Adapter/Environment/SAP/XML/LowZeroCarbonEnergySources) | - | - |
| RenewableHeatIncentive | [RenewableHeatIncentive](/documentation/oM/Adapter/Environment/SAP/XML/RenewableHeatIncentive) | - | - |
| SuggestedImprovements | [SuggestedImprovements](/documentation/oM/Adapter/Environment/SAP/XML/SuggestedImprovements) | - | - |
| GreenPackageDeal | [GreenPackageDeal](/documentation/oM/Adapter/Environment/SAP/XML/GreenPackageDeal) | - | - |
| AlternativeImprovements | [SuggestedImprovements](/documentation/oM/Adapter/Environment/SAP/XML/SuggestedImprovements) | - | - |
| Addendum | [Addendum](/documentation/oM/Adapter/Environment/SAP/XML/Addendum) | - | - |


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

- [EnergyAssessment.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/XML/EnergyAssessment.cs)

All history and changes of the class can be found by inspection the history.
