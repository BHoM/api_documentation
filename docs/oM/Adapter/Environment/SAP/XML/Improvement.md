---
title: Improvement
---

# Environment.SAP.XML.Improvement



## Class structure

### Implemented interfaces and base types

???+ bhom "The Improvement in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ImprovementCategory | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| GreenDealCategory | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| ImprovementType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| ImprovementDetails | [ImprovementDetails](/api/oM/Adapter/Environment/SAP/XML/ImprovementDetails) | . | - |
| IndicativeCost | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| TypicalSaving | [Money](/api/oM/Adapter/Environment/SAP/XML/Money) | . | - |
| EnergyPerformanceRating | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| EnvironmentalImpactRating | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| Sequence | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | . | - |


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

The class is defined in C#. The class definition is available on github:

- [Improvement.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/XML/Improvement.cs)

All history and changes of the class can be found by inspection the history.
