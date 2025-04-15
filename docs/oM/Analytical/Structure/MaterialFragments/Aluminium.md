---
title: Aluminium
---

# Structure.MaterialFragments.Aluminium

Structural aluminium material to be used on structural elements and properties or as a fragment of the physical material.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Aluminium in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/om_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)
    -  Structure.MaterialFragments.[IIsotropic](/om_documentation/oM/Analytical/Structure/MaterialFragments/IIsotropic)
    -  Structure.MaterialFragments.[IMaterialFragment](/om_documentation/oM/Analytical/Structure/MaterialFragments/IMaterialFragment)
    -  Base.[IFragment](/om_documentation/oM/Framework/Base/IFragment)
    -  Physical.Materials.[IMaterialProperties](/om_documentation/oM/Physical/Physical/Materials/IMaterialProperties)
    -  Structure.[IProperty](/om_documentation/oM/Analytical/Structure/IProperty)
    -  Physical.Materials.[IDensityProvider](/om_documentation/oM/Physical/Physical/Materials/IDensityProvider)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Unique Names are required for some structural packages to create and identify the object. | - |
| Density | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | [Density](/om_documentation/oM/Dimensional/Quantities/Attributes/Density) [kg/m³] |
| DampingRatio | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Dynamic damping ratio, expressed as a ratio between actual damping and critical damping. For structures, typically taken as 0.02 (i.e. 2%). | [Ratio](/om_documentation/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| PoissonsRatio | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Ratio between axial and transverse strain. Used together with YoungsModulus to derive the ShearModulus for isotropic materials. | [Ratio](/om_documentation/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| ThermalExpansionCoeff | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The strain induced in the material per unit change of temperature. | [ThermalExpansionCoefficient](/om_documentation/oM/Dimensional/Quantities/Attributes/ThermalExpansionCoefficient) [1/K] |
| YoungsModulus | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Modulus of elasticity of the material. Ratio between axial stress and axial strain. | [YoungsModulus](/om_documentation/oM/Dimensional/Quantities/Attributes/YoungsModulus) [Pa] |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/om_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the material based on its properties. | - | Structure_Engine |
| DescriptionOrName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gets the name from a IProperty. If null or empty, a default description name is provided instead. | - | Structure_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the IProperty, based on its properties. | - | Structure_Engine |
| IMaterialType | [MaterialType](/om_documentation/oM/Analytical/Structure/MaterialFragments/MaterialType) | Gets the material type from the MaterialFragment. | - | Structure_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a MaterialFragment is null and outputs relevant error message. | - | Structure_Engine |
| MaterialType | [MaterialType](/om_documentation/oM/Analytical/Structure/MaterialFragments/MaterialType) | Gets the material type from the MaterialFragment. For a Aluminium material this will always return type Aluminium. | - | Structure_Engine |
| ShearModulus | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Shear modulus of the isotropic material fragment. Evaluated based on YoungsModulus and PoissonsRatio as G = E/2(1+ν). | [ShearModulus](/om_documentation/oM/Dimensional/Quantities/Attributes/ShearModulus) [Pa] | Structure_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Aluminium.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/MaterialFragments\Aluminium.cs)

All history and changes of the class can be found by inspection the history.
