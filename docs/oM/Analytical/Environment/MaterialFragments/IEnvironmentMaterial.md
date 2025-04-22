---
title: IEnvironmentMaterial
---

# Environment.MaterialFragments.IEnvironmentMaterial



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IEnvironmentMaterial in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Physical.Materials.[IMaterialProperties](/api_documentation/oM/Physical/Physical/Materials/IMaterialProperties)
    -  Base.[IFragment](/api_documentation/oM/Framework/Base/IFragment)
    -  Physical.Materials.[IDensityProvider](/api_documentation/oM/Physical/Physical/Materials/IDensityProvider)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Environment.MaterialFragments.[GasMaterial](/api_documentation/oM/Analytical/Environment/MaterialFragments/GasMaterial)
    - Environment.MaterialFragments.[SolidMaterial](/api_documentation/oM/Analytical/Environment/MaterialFragments/SolidMaterial)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Conductivity | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| SpecificHeat | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| VapourResistivity | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Roughness | [Roughness](/api_documentation/oM/Analytical/Environment/MaterialFragments/Roughness) | Required for some calculations, such as determining the convective heat transfer coefficient. Use Roughness enum | - |
| Refraction | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IEnvironmentMaterial.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/MaterialFragments\IEnvironmentMaterial.cs)

All history and changes of the class can be found by inspection the history.
