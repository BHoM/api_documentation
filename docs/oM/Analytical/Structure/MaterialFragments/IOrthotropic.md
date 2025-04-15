---
title: IOrthotropic
---

# Structure.MaterialFragments.IOrthotropic

Base interface for orthotropic structural materials.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IOrthotropic in inheriting from the following base type(s) and implements the following interfaces:"

    -  Structure.MaterialFragments.[IMaterialFragment](/om_documentation/oM/Analytical/Structure/MaterialFragments/IMaterialFragment)
    -  Base.[IFragment](/om_documentation/oM/Framework/Base/IFragment)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)
    -  Physical.Materials.[IMaterialProperties](/om_documentation/oM/Physical/Physical/Materials/IMaterialProperties)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Structure.[IProperty](/om_documentation/oM/Analytical/Structure/IProperty)
    -  Physical.Materials.[IDensityProvider](/om_documentation/oM/Physical/Physical/Materials/IDensityProvider)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Structure.MaterialFragments.[ITimber](/om_documentation/oM/Analytical/Structure/MaterialFragments/ITimber)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Structure.MaterialFragments.[GenericOrthotropicMaterial](/om_documentation/oM/Analytical/Structure/MaterialFragments/GenericOrthotropicMaterial)
    - Structure.MaterialFragments.[Glulam](/om_documentation/oM/Analytical/Structure/MaterialFragments/Glulam)
    - Structure.MaterialFragments.[LaminatedVeneerLumberCrossbands](/om_documentation/oM/Analytical/Structure/MaterialFragments/LaminatedVeneerLumberCrossbands)
    - Structure.MaterialFragments.[LaminatedVeneerLumberParallel](/om_documentation/oM/Analytical/Structure/MaterialFragments/LaminatedVeneerLumberParallel)
    - Structure.MaterialFragments.[SawnTimber](/om_documentation/oM/Analytical/Structure/MaterialFragments/SawnTimber)
    - Structure.MaterialFragments.[Timber](/om_documentation/oM/Analytical/Structure/MaterialFragments/Timber)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| YoungsModulus | [Vector](/om_documentation/oM/Dimensional/Geometry/Vector) | Modulus of elasticity of the material. Ratio between axial stress and axial strain. | [YoungsModulus](/om_documentation/oM/Dimensional/Quantities/Attributes/YoungsModulus) [Pa] |
| PoissonsRatio | [Vector](/om_documentation/oM/Dimensional/Geometry/Vector) | Ratio between axial and transverse strain. | [Ratio](/om_documentation/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| ThermalExpansionCoeff | [Vector](/om_documentation/oM/Dimensional/Geometry/Vector) | The strain induced in the material per unit change of temperature. | [ThermalExpansionCoefficient](/om_documentation/oM/Dimensional/Quantities/Attributes/ThermalExpansionCoefficient) [1/K] |
| ShearModulus | [Vector](/om_documentation/oM/Dimensional/Geometry/Vector) | The shear modulus or modulus of rigidity. Defined as the ratio between shear stress and shear strain. | [ShearModulus](/om_documentation/oM/Dimensional/Quantities/Attributes/ShearModulus) [Pa] |


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

- [IOrthotropic.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/MaterialFragments\IOrthotropic.cs)

All history and changes of the class can be found by inspection the history.
