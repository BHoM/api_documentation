---
title: SPTTestProperties
---

# Ground.SPTTestProperties

Properties related to the standard penetration test.

## Class structure

### Implemented interfaces and base types

???+ bhom "The SPTTestProperties in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Ground.[ITestProperties](/api_documentation/oM/Analytical/Ground/ITestProperties)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| HammerNumber | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Hammer number (ISPT_HAM). | - |
| Type | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Type of test (SPT_TYPE). | - |
| WaterDepth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Depth to water at time of test, set to NaN if dry (ISPT_WAT). | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| CasingDepth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Casing depth at time of test (ISPT_CAS). | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| SoftRock | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | True if the standard penetration test was carried out in soft rock. (ISPT_ROCK). | - |
| WeatherConditions | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Weather conditons during test (ISPT_ENV). | - |
| Method | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Test method (ISPT_METH). | - |
| AccreditingBody | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Accrediting body (ISPT_CRED). | - |
| Status | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Test Status (TEST_STAT) | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [SPTTestProperties.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/ITestProperties/SPTTestProperties.cs)

All history and changes of the class can be found by inspection the history.
