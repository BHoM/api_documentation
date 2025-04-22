---
title: PlumbingFlowFragment
---

# MEP.Fragments.PlumbingFlowFragment



## Class structure

### Implemented interfaces and base types

???+ bhom "The PlumbingFlowFragment in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IFragment](/api_documentation/oM/Framework/Base/IFragment)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ColdWaterFlowRate | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The volume of cold water being conveyed by the Plumbing Fixture per second (m3/s). | [VolumetricFlowRate](/api_documentation/oM/Dimensional/Quantities/Attributes/VolumetricFlowRate) [m³/s] |
| HotWaterFlowRate | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The volume of hot water being conveyed by the Plumbing Fixture per second (m3/s). | [VolumetricFlowRate](/api_documentation/oM/Dimensional/Quantities/Attributes/VolumetricFlowRate) [m³/s] |
| DrainageFlowRate | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The volume of waste/drainage being conveyed by the Plumbing Fixture per second (m3/s). | [VolumetricFlowRate](/api_documentation/oM/Dimensional/Quantities/Attributes/VolumetricFlowRate) [m³/s] |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [PlumbingFlowFragment.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/Fragments\PlumbingFlowFragment.cs)

All history and changes of the class can be found by inspection the history.
