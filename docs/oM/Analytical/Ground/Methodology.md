---
title: Methodology
---

# Ground.Methodology

Methodology for the borehole, remarks and comments (e.g. for termination).

## Class structure

### Implemented interfaces and base types

???+ bhom "The Methodology in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/om_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)
    -  Ground.[IBoreholeProperty](/om_documentation/oM/Analytical/Ground/IBoreholeProperty)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Type | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Type of activity (LOCA_TYPE). | - |
| Status | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Status of information relating to this positio (LOCA_STAT). | - |
| Remarks | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | General remarks for the investigation (LOCA_REM). | - |
| Purpose | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Purpose of the activity (LOCA_PURP). | - |
| Termination | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Reason for activity termination (LOCA_TERM). | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/om_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a IBoreholeProperty is valid and outputs relevant error message. | - | Ground_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Methodology.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/BoreholeProperties/Methodology.cs)

All history and changes of the class can be found by inspection the history.
