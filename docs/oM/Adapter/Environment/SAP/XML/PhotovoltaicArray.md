---
title: PhotovoltaicArray
---

# Environment.SAP.XML.PhotovoltaicArray



## Class structure

### Implemented interfaces and base types

???+ bhom "The PhotovoltaicArray in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/om_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PeakPower | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Peak kW of photovoltaics (PVs) (kWp); 0.0 if none. | - |
| Orientation | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | PV orientation; only if peak kWp &amp;gt; 0. | - |
| Pitch | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | PV pitch; only if peak kWp &amp;gt; 0. | - |
| Overshading | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | PV overshading; only if peak kWp &amp;gt; 0. | - |
| MCSCertificate | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | . | - |
| MCSCertificateReference | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| ManufacturerName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |
| OvershadingMCS | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | . | - |


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

- [PhotovoltaicArray.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/XML/PhotovoltaicArray.cs)

All history and changes of the class can be found by inspection the history.
