---
title: SpaceAnalyticalFragment
---

# Environment.Fragments.SpaceAnalyticalFragment

Fragment containing space analytical properties (e.g. domestic hot water supply, daylight factor, heating and cooling sizing method)

## Class structure

### Implemented interfaces and base types

???+ bhom "The SpaceAnalyticalFragment in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IFragment](/documentation/oM/Framework/Base/IFragment)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| InternalDomesticHotWater | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The amount of internal domestic hot water supply for the space | - |
| DaylightFactor | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| FacadeLength | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The length of the space enclsoure that is adjacent to the outdoors | - |
| FixedConvectionCoefficient | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| SizeCoolingMethod | [SizingMethod](/documentation/oM/Analytical/Environment/Fragments/SizingMethod) | The cooling size method of the space. Use SizingMethod enum | - |
| SizeHeatingMethod | [SizingMethod](/documentation/oM/Analytical/Environment/Fragments/SizingMethod) | The heating size method of the space. Use SizingMethod enum | - |
| RadiantProportion | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [SpaceAnalyticalFragment.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/Fragments\SpaceAnalyticalFragment.cs)

All history and changes of the class can be found by inspection the history.
