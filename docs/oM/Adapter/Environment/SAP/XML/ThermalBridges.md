---
title: ThermalBridges
---

# Environment.SAP.XML.ThermalBridges



## Class structure

### Implemented interfaces and base types

???+ bhom "The ThermalBridges in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ThermalBridgeCode | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Code which indicates how the thermal bridge data has been recorded. | - |
| UserDefinedYValue | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Global y-value for all thermal bridges in watts per square metre per kelvin; only if thermal bridge code is: user defined (global y-value). | - |
| CalculationReference | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Reference to the details of the calculation of the global y-value; only if thermal bridging is user defined global y-value. | - |
| ThermalBridge | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ThermalBridge](/api_documentation/oM/Adapter/Environment/SAP/XML/ThermalBridge)&gt; | Various measurements for each thermal bridge that makes up a particular Building-Part. | - |


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

- [ThermalBridges.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/XML/ThermalBridges.cs)

All history and changes of the class can be found by inspection the history.
