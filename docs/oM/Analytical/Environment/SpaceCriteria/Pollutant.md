---
title: Pollutant
---

# Environment.SpaceCriteria.Pollutant

Pollutant gains are defined as the amount of both latent and sensible heat contributed by pollutution sources.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Pollutant in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/om_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)
    -  Environment.SpaceCriteria.[IGain](/om_documentation/oM/Analytical/Environment/SpaceCriteria/IGain)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Sensible | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The sensible heat contributed by pollutants, which contribute to a rise in temperature with no change in phase. | - |
| Latent | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The latent heat contributed by pollutants, which contribute to a change in phase from solid to liquid. | - |
| Profile | [Profile](/om_documentation/oM/Analytical/Environment/SpaceCriteria/Profile) | Profiles depict the time period (hours per day, days per week) during which pollutants are contributing heat to the space. | - |


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

- [Pollutant.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/SpaceCriteria\Pollutant.cs)

All history and changes of the class can be found by inspection the history.
