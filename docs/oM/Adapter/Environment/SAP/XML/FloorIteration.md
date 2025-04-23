---
title: FloorIteration
---

# Environment.SAP.XML.FloorIteration

Describe a single UValue change for floors within the SAP context.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FloorIteration in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  Environment.SAP.[IIteration](/api/oM/Adapter/Environment/SAP/IIteration)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| UValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | New UValue to use for the Floor(s). Must be a positive number. Measured in Watts per Meter Squared Kelvin (W/m2K). | - |
| Include | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | A list of Floor names to make changes to. If this is left blank, then all floors in the SAP Report will be updated to have this UValue. | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Provide the name of this iteration. The name should be unique across all iterations in your model, and should match any coordination with other models (over heating, daylighting, etc.) you may be running parametrics on. | - |
| Prefix | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | What value should be used to prefix the name of this iteration when combining with other iterations. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [FloorIteration.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Iteration/FloorIteration.cs)

All history and changes of the class can be found by inspection the history.
