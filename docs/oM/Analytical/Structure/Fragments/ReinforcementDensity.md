---
title: ReinforcementDensity
---

# Structure.Fragments.ReinforcementDensity

The reinforcement density of an element and its material.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ReinforcementDensity in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IFragment](/api_documentation/oM/Framework/Base/IFragment)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Density | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The mass of reinforcement per unit volume of the element that owns this fragment. | [Density](/api_documentation/oM/Dimensional/Quantities/Attributes/Density) [kg/m³] |
| Material | [IMaterialFragment](/api_documentation/oM/Analytical/Structure/MaterialFragments/IMaterialFragment) | Homogeneous material of the reinforcement. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a ReinforcementDensity is null and outputs relevant error message. | - | Structure_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [ReinforcementDensity.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Fragments\ReinforcementDensity.cs)

All history and changes of the class can be found by inspection the history.
