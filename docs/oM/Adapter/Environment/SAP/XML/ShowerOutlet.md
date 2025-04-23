---
title: ShowerOutlet
---

# Environment.SAP.XML.ShowerOutlet



## Class structure

### Implemented interfaces and base types

???+ bhom "The ShowerOutlet in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ShowerOutletType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Hot water type for this shower outlet. | - |
| ShowerFlowRate | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The flow rate. Only when a shower is not instantaneous electric. Leave blank if NO flow limiter fitted. | - |
| ShowerPower | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The shower power, only if shower outlet type is instantaneous electric. | - |
| ShowerWWHRS | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The WWHRS with which the shower is connected. If shower outlet type is instantaneous electric shower then only a storage WWHRS can be selected or none. | - |


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

- [ShowerOutlet.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/XML/ShowerOutlet.cs)

All history and changes of the class can be found by inspection the history.
