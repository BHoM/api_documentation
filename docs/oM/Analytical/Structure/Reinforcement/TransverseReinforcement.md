---
title: TransverseReinforcement
---

# Structure.Reinforcement.TransverseReinforcement

Defines any transverse reinforcement along a Bar.

## Class structure

### Implemented interfaces and base types

???+ bhom "The TransverseReinforcement in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Structure.Reinforcement.[IBarReinforcement](/api_documentation/oM/Analytical/Structure/Reinforcement/IBarReinforcement)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| CenterlineLayout | [ICurveLayout](/api_documentation/oM/Dimensional/Spatial/Layouts/ICurveLayout) | Layout controlling the reinforcement shape in relation to the bar's section. | - |
| Diameter | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Diameter of a single rebar. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Material | [IMaterialFragment](/api_documentation/oM/Analytical/Structure/MaterialFragments/IMaterialFragment) | - | - |
| Spacing | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Axial distance between consecutive rebars. If AdjustSpacingToFit is true it will become maximum spacing. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| AdjustSpacingToFit | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Toggles if provided spacing value should be fixed or adjusted to fit rebars from the host bar's start to end. | - |
| StartLocation | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Normalised length (0 means start, 1 means end) along the element where the rebars start. | - |
| EndLocation | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Normalised length (0 means start, 1 means end) along the element where the rebars ends. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a BarReinforcement is null and outputs relevant error message. | - | Structure_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [TransverseReinforcement.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Reinforcement\TransverseReinforcement.cs)

All history and changes of the class can be found by inspection the history.
