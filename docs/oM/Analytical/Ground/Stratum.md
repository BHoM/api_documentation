---
title: Stratum
---

# Ground.Stratum

A stratum containing the geological information based on the AGS schema.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Stratum in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Id | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Location identifier relating the borehole to the strata (LOCA_ID). | - |
| Top | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Depth to the top of the strata based on the datum provided on the Borehole (GEOL_TOP). | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Bottom | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Depth to the bottom of the strata based on the datum provided on the Borehole (GEOL_BOT). | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| LogDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | General description of the strata (GEOL_DESC). | - |
| Legend | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The legend code summarising the LogDescription (GEOL_LEG). | - |
| ObservedGeology | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The observed geology expressed as a GeologicalUnit (GEOL_GEOL). | - |
| InterpretedGeology | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The interpreted geology expressed as an engineering material (GEOL_GEO2). | - |
| OptionalInterpretedGeology | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The optional interpreted geology expressed as an engineering material (GEOL_GEO3). | - |
| Properties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IStratumProperty](/api_documentation/oM/Analytical/Ground/IStratumProperty)&gt; | The optional stratum properties. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Strata or its defining properties are valid and outputs relevant error message. | - | Ground_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Stratum.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/Stratum.cs)

All history and changes of the class can be found by inspection the history.
