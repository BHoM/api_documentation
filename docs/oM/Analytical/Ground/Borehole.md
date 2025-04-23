---
title: Borehole
---

# Ground.Borehole

A representation of a borehole defined by a coordinate system, start point and end point based on the AGS schema.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Borehole in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Id | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Location identifier for the borehole unique to the project (LOCA_ID). | - |
| Top | [Point](/api/oM/Dimensional/Geometry/Point) | The top of the borehole within the coordinate system provided (LOCA_NATE, LOCA_NATEN, LOCA_GL). | - |
| Bottom | [Point](/api/oM/Dimensional/Geometry/Point) | The bottom of the borehole within the coordinate system provided (LOCA_ETRV, LOCA_NTRV, LOCA_FDEP). | - |
| CoordinateSystem | [Cartesian](/api/oM/Dimensional/Geometry/CoordinateSystem/Cartesian) | The coordinate system referenced by the top and bottom point. (LOCA_GREF, LOCA_NATD). | - |
| Strata | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Stratum](/api/oM/Analytical/Ground/Stratum)&gt; | A list of objects containing the strata found within the borehole, based on the GEOL table. | - |
| ContaminantSamples | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ContaminantSample](/api/oM/Analytical/Ground/ContaminantSample)&gt; | A list of objects containing the contaminant samples found within the borehole, based on the ERES table. | - |
| GeotechnicalTestResults | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ITest](/api/oM/Analytical/Ground/ITest)&gt; | A list of objects containing the geotechnical results found within the borehole. | - |
| BoreholeProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IBoreholeProperty](/api/oM/Analytical/Ground/IBoreholeProperty)&gt; | A list of properties related to the borehole. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| DistinctSuites | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Returns a distinct list of suites from a Borehole using the sample reference, test name or top depth (in order of priority). | - | Ground_Engine |
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Borehole or its defining properties are valid and outputs relevant error message. | - | Ground_Engine |
| StrataLines | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Line](/api/oM/Dimensional/Geometry/Line)&gt; | Generates a list of lines relating to the strata within the Borehole which can be used for visualisation purposes. | - | Ground_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Borehole.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/Borehole.cs)

All history and changes of the class can be found by inspection the history.
