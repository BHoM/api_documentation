---
title: IMaterialFragment
---

# Structure.MaterialFragments.IMaterialFragment

Base interface for structural materials used by structural properties or as a fragment of the physical material.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IMaterialFragment in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IFragment](/api/oM/Framework/Base/IFragment)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  Physical.Materials.[IMaterialProperties](/api/oM/Physical/Physical/Materials/IMaterialProperties)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Structure.[IProperty](/api/oM/Analytical/Structure/IProperty)
    -  Physical.Materials.[IDensityProvider](/api/oM/Physical/Physical/Materials/IDensityProvider)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Structure.MaterialFragments.[IIsotropic](/api/oM/Analytical/Structure/MaterialFragments/IIsotropic)
    - Structure.MaterialFragments.[IOrthotropic](/api/oM/Analytical/Structure/MaterialFragments/IOrthotropic)
    - Structure.MaterialFragments.[ITimber](/api/oM/Analytical/Structure/MaterialFragments/ITimber)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.GSA.MaterialFragments.[Fabric](/api/oM/Adapter/Adapters/GSA/MaterialFragments/Fabric)
    - Structure.MaterialFragments.[Aluminium](/api/oM/Analytical/Structure/MaterialFragments/Aluminium)
    - Structure.MaterialFragments.[Concrete](/api/oM/Analytical/Structure/MaterialFragments/Concrete)
    - Structure.MaterialFragments.[GenericIsotropicMaterial](/api/oM/Analytical/Structure/MaterialFragments/GenericIsotropicMaterial)
    - Structure.MaterialFragments.[GenericOrthotropicMaterial](/api/oM/Analytical/Structure/MaterialFragments/GenericOrthotropicMaterial)
    - Structure.MaterialFragments.[Glulam](/api/oM/Analytical/Structure/MaterialFragments/Glulam)
    - Structure.MaterialFragments.[LaminatedVeneerLumberCrossbands](/api/oM/Analytical/Structure/MaterialFragments/LaminatedVeneerLumberCrossbands)
    - Structure.MaterialFragments.[LaminatedVeneerLumberParallel](/api/oM/Analytical/Structure/MaterialFragments/LaminatedVeneerLumberParallel)
    - Structure.MaterialFragments.[SawnTimber](/api/oM/Analytical/Structure/MaterialFragments/SawnTimber)
    - Structure.MaterialFragments.[Steel](/api/oM/Analytical/Structure/MaterialFragments/Steel)
    - Structure.MaterialFragments.[Timber](/api/oM/Analytical/Structure/MaterialFragments/Timber)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| DampingRatio | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Dynamic damping ratio, expressed as a ratio between actual damping and critical damping. For structures, typically taken as 0.02 (i.e. 2%). | [Ratio](/api/oM/Dimensional/Quantities/Attributes/Ratio) [-] |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| DescriptionOrName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gets the name from a IProperty. If null or empty, a default description name is provided instead. | - | Structure_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the IProperty, based on its properties. | - | Structure_Engine |
| IMaterialType | [MaterialType](/api/oM/Analytical/Structure/MaterialFragments/MaterialType) | Gets the material type from the MaterialFragment. | - | Structure_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a MaterialFragment is null and outputs relevant error message. | - | Structure_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IMaterialFragment.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/MaterialFragments\IMaterialFragment.cs)

All history and changes of the class can be found by inspection the history.
