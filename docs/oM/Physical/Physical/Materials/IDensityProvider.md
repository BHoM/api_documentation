---
title: IDensityProvider
---

# Physical.Materials.IDensityProvider

Interface to be added to IMaterialProperties the specifies the density of the Material the proeprty is attached to.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IDensityProvider in inheriting from the following base type(s) and implements the following interfaces:"

    -  Physical.Materials.[IMaterialProperties](/om_documentation/oM/Physical/Physical/Materials/IMaterialProperties)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Environment.MaterialFragments.[IEnvironmentMaterial](/om_documentation/oM/Analytical/Environment/MaterialFragments/IEnvironmentMaterial)
    - Structure.MaterialFragments.[IIsotropic](/om_documentation/oM/Analytical/Structure/MaterialFragments/IIsotropic)
    - Structure.MaterialFragments.[IMaterialFragment](/om_documentation/oM/Analytical/Structure/MaterialFragments/IMaterialFragment)
    - Structure.MaterialFragments.[IOrthotropic](/om_documentation/oM/Analytical/Structure/MaterialFragments/IOrthotropic)
    - Structure.MaterialFragments.[ITimber](/om_documentation/oM/Analytical/Structure/MaterialFragments/ITimber)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Environment.MaterialFragments.[GasMaterial](/om_documentation/oM/Analytical/Environment/MaterialFragments/GasMaterial)
    - Environment.MaterialFragments.[SolidMaterial](/om_documentation/oM/Analytical/Environment/MaterialFragments/SolidMaterial)
    - Adapters.GSA.MaterialFragments.[Fabric](/om_documentation/oM/Adapter/Adapters/GSA/MaterialFragments/Fabric)
    - Structure.MaterialFragments.[Aluminium](/om_documentation/oM/Analytical/Structure/MaterialFragments/Aluminium)
    - Structure.MaterialFragments.[Concrete](/om_documentation/oM/Analytical/Structure/MaterialFragments/Concrete)
    - Structure.MaterialFragments.[GenericIsotropicMaterial](/om_documentation/oM/Analytical/Structure/MaterialFragments/GenericIsotropicMaterial)
    - Structure.MaterialFragments.[GenericOrthotropicMaterial](/om_documentation/oM/Analytical/Structure/MaterialFragments/GenericOrthotropicMaterial)
    - Structure.MaterialFragments.[Glulam](/om_documentation/oM/Analytical/Structure/MaterialFragments/Glulam)
    - Structure.MaterialFragments.[LaminatedVeneerLumberCrossbands](/om_documentation/oM/Analytical/Structure/MaterialFragments/LaminatedVeneerLumberCrossbands)
    - Structure.MaterialFragments.[LaminatedVeneerLumberParallel](/om_documentation/oM/Analytical/Structure/MaterialFragments/LaminatedVeneerLumberParallel)
    - Structure.MaterialFragments.[SawnTimber](/om_documentation/oM/Analytical/Structure/MaterialFragments/SawnTimber)
    - Structure.MaterialFragments.[Steel](/om_documentation/oM/Analytical/Structure/MaterialFragments/Steel)
    - Structure.MaterialFragments.[Timber](/om_documentation/oM/Analytical/Structure/MaterialFragments/Timber)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Density | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | [Density](/om_documentation/oM/Dimensional/Quantities/Attributes/Density) [kg/m³] |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IDensityProvider.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/Materials\IDensityProvider.cs)

All history and changes of the class can be found by inspection the history.
