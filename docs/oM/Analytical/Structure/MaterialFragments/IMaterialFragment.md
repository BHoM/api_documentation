---
title: IMaterialFragment
---

# Structure.MaterialFragments.IMaterialFragment

Base interface for structural materials used by structural properties or as a fragment of the physical material.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IMaterialFragment in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IFragment](/om_documentation/oM/Framework/Base/IFragment)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)
    -  Physical.Materials.[IMaterialProperties](/om_documentation/oM/Physical/Physical/Materials/IMaterialProperties)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Structure.[IProperty](/om_documentation/oM/Analytical/Structure/IProperty)
    -  Physical.Materials.[IDensityProvider](/om_documentation/oM/Physical/Physical/Materials/IDensityProvider)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Structure.MaterialFragments.[IIsotropic](/om_documentation/oM/Analytical/Structure/MaterialFragments/IIsotropic)
    - Structure.MaterialFragments.[IOrthotropic](/om_documentation/oM/Analytical/Structure/MaterialFragments/IOrthotropic)
    - Structure.MaterialFragments.[ITimber](/om_documentation/oM/Analytical/Structure/MaterialFragments/ITimber)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

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
| DampingRatio | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Dynamic damping ratio, expressed as a ratio between actual damping and critical damping. For structures, typically taken as 0.02 (i.e. 2%). | [Ratio](/om_documentation/oM/Dimensional/Quantities/Attributes/Ratio) [-] |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| DescriptionOrName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gets the name from a IProperty. If null or empty, a default description name is provided instead. | - | Structure_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the IProperty, based on its properties. | - | Structure_Engine |
| IMaterialType | [MaterialType](/om_documentation/oM/Analytical/Structure/MaterialFragments/MaterialType) | Gets the material type from the MaterialFragment. | - | Structure_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a MaterialFragment is null and outputs relevant error message. | - | Structure_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IMaterialFragment.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/MaterialFragments\IMaterialFragment.cs)

All history and changes of the class can be found by inspection the history.
