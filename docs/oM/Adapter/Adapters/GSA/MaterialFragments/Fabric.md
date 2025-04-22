---
title: Fabric
---

# Adapters.GSA.MaterialFragments.Fabric



## Class structure

### Implemented interfaces and base types

???+ bhom "The Fabric in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Structure.MaterialFragments.[IMaterialFragment](/api_documentation/oM/Analytical/Structure/MaterialFragments/IMaterialFragment)
    -  Base.[IFragment](/api_documentation/oM/Framework/Base/IFragment)
    -  Physical.Materials.[IMaterialProperties](/api_documentation/oM/Physical/Physical/Materials/IMaterialProperties)
    -  Structure.[IProperty](/api_documentation/oM/Analytical/Structure/IProperty)
    -  Physical.Materials.[IDensityProvider](/api_documentation/oM/Physical/Physical/Materials/IDensityProvider)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | A unique Name is required for some structural packages to create and identify the object. | - |
| Density | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | [Density](/api_documentation/oM/Dimensional/Quantities/Attributes/Density) [kg/m³] |
| DampingRatio | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Dynamic damping ratio, expressed as a ratio between actual damping and critical damping. For structures, typically taken as 0.02 (i.e. 2%). | [Ratio](/api_documentation/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| PoissonsRatio | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Ratio between axial and transverse strain. Used together with YoungsModulus to derive the ShearModulus for isotropic materials. | [Ratio](/api_documentation/oM/Dimensional/Quantities/Attributes/Ratio) [-] |
| WarpModulus | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Modulus of elasticity of the material. Ratio between axial stress and axial strain. | [YoungsModulus](/api_documentation/oM/Dimensional/Quantities/Attributes/YoungsModulus) [Pa] |
| WeftModulus | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Modulus of elasticity of the material. Ratio between axial stress and axial strain. | [YoungsModulus](/api_documentation/oM/Dimensional/Quantities/Attributes/YoungsModulus) [Pa] |
| ShearModulus | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Modulus of elasticity of the material. Ratio between axial stress and axial strain. | [YoungsModulus](/api_documentation/oM/Dimensional/Quantities/Attributes/YoungsModulus) [Pa] |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| DescriptionOrName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gets the name from a IProperty. If null or empty, a default description name is provided instead. | - | Structure_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the IProperty, based on its properties. | - | Structure_Engine |
| IMaterialType | [MaterialType](/api_documentation/oM/Analytical/Structure/MaterialFragments/MaterialType) | Gets the material type from the MaterialFragment. | - | Structure_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a MaterialFragment is null and outputs relevant error message. | - | Structure_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Fabric.cs](https://github.com/BHoM/GSA_Toolkit/blob/develop/GSA_oM/MaterialFragments/Fabric.cs)

All history and changes of the class can be found by inspection the history.
