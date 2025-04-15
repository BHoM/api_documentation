---
title: IIsotropic
---

# Structure.MaterialFragments.IIsotropic

Base interface for isotropic structural materials.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IIsotropic in inheriting from the following base type(s) and implements the following interfaces:"

    -  Structure.MaterialFragments.[IMaterialFragment](/om_documentation/oM/Analytical/Structure/MaterialFragments/IMaterialFragment)
    -  Base.[IFragment](/om_documentation/oM/Framework/Base/IFragment)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)
    -  Physical.Materials.[IMaterialProperties](/om_documentation/oM/Physical/Physical/Materials/IMaterialProperties)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Structure.[IProperty](/om_documentation/oM/Analytical/Structure/IProperty)
    -  Physical.Materials.[IDensityProvider](/om_documentation/oM/Physical/Physical/Materials/IDensityProvider)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Structure.MaterialFragments.[Aluminium](/om_documentation/oM/Analytical/Structure/MaterialFragments/Aluminium)
    - Structure.MaterialFragments.[Concrete](/om_documentation/oM/Analytical/Structure/MaterialFragments/Concrete)
    - Structure.MaterialFragments.[GenericIsotropicMaterial](/om_documentation/oM/Analytical/Structure/MaterialFragments/GenericIsotropicMaterial)
    - Structure.MaterialFragments.[Steel](/om_documentation/oM/Analytical/Structure/MaterialFragments/Steel)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| YoungsModulus | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Modulus of elasticity of the material. Ratio between axial stress and axial strain. | [YoungsModulus](/om_documentation/oM/Dimensional/Quantities/Attributes/YoungsModulus) [Pa] |
| PoissonsRatio | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Ratio between axial and transverse strain. Used together with YoungsModulus to derive the ShearModulus for isotropic materials. | [Ratio](/om_documentation/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| ThermalExpansionCoeff | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The strain induced in the material per unit change of temperature. | [ThermalExpansionCoefficient](/om_documentation/oM/Dimensional/Quantities/Attributes/ThermalExpansionCoefficient) [1/K] |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| DescriptionOrName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gets the name from a IProperty. If null or empty, a default description name is provided instead. | - | Structure_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the IProperty, based on its properties. | - | Structure_Engine |
| IMaterialType | [MaterialType](/om_documentation/oM/Analytical/Structure/MaterialFragments/MaterialType) | Gets the material type from the MaterialFragment. | - | Structure_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a MaterialFragment is null and outputs relevant error message. | - | Structure_Engine |
| ShearModulus | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Shear modulus of the isotropic material fragment. Evaluated based on YoungsModulus and PoissonsRatio as G = E/2(1+ν). | [ShearModulus](/om_documentation/oM/Dimensional/Quantities/Attributes/ShearModulus) [Pa] | Structure_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IIsotropic.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/MaterialFragments\IIsotropic.cs)

All history and changes of the class can be found by inspection the history.
