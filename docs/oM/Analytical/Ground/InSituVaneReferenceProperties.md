---
title: InSituVaneReferenceProperties
---

# Ground.InSituVaneReferenceProperties

Properties related to the references of the in Situ Hand Vane Test.

## Class structure

### Implemented interfaces and base types

???+ bhom "The InSituVaneReferenceProperties in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  Ground.[ITestProperties](/api/oM/Analytical/Ground/ITestProperties)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Details | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Details of vane test and vane size (IVAN_REM). | - |
| Weather | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Details of weather and environmental conditions during test (IVAN_ENV). | - |
| Date | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | Test date (IVAN_DATE). | - |
| StratumReference | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Stratum refrence shown on trial pit or traverse sketch (GEOL_STAT). | - |
| FileReference | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Associated file references (FILE_FSET). | - |


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

- [InSituVaneReferenceProperties.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/ITestProperties/InSituVaneReferenceProperties.cs)

All history and changes of the class can be found by inspection the history.
