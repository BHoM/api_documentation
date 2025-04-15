---
title: AirPermeabilityIteration
---

# Environment.SAP.XML.AirPermeabilityIteration

Describe a single air permeability change for the building within the SAP context. Applies to the ventilation of the whole building within the SAP Report.

## Class structure

### Implemented interfaces and base types

???+ bhom "The AirPermeabilityIteration in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)
    -  Environment.SAP.[IIteration](/documentation/oM/Adapter/Environment/SAP/IIteration)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| AirPermeability | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | New value to use for the air permeability. Must be a positive number. Applies to the ventilation of the whole building within the SAP Report. | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Provide the name of this iteration. The name should be unique across all iterations in your model, and should match any coordination with other models (over heating, daylighting, etc.) you may be running parametrics on. | - |
| Prefix | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | What value should be used to prefix the name of this iteration when combining with other iterations. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [AirPermeabilityIteration.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Iteration/AirPermeabilityIteration.cs)

All history and changes of the class can be found by inspection the history.
