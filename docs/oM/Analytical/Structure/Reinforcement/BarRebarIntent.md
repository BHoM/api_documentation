---
title: BarRebarIntent
---

# Structure.Reinforcement.BarRebarIntent

A collection of reinforcement for a Bar and minimum cover.

## Class structure

### Implemented interfaces and base types

???+ bhom "The BarRebarIntent in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  Structure.Reinforcement.[IRebarIntent](/api/oM/Analytical/Structure/Reinforcement/IRebarIntent)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BarReinforcement | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IBarReinforcement](/api/oM/Analytical/Structure/Reinforcement/IBarReinforcement)&gt; | A collection of IBarReinforcement objects. | - |
| MinimumCover | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Minimum reinforcement cover of the section. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |


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
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a BarRebarIntent is null and outputs relevant error message. | - | Structure_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [BarRebarIntent.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Reinforcement\BarRebarIntent.cs)

All history and changes of the class can be found by inspection the history.
