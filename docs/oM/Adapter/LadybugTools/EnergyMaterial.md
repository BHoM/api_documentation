---
title: EnergyMaterial
---

# LadybugTools.EnergyMaterial



## Class structure

### Implemented interfaces and base types

???+ bhom "The EnergyMaterial in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  LadybugTools.[IEnergyMaterialOpaque](/api/oM/Adapter/LadybugTools/IEnergyMaterialOpaque)
    -  LadybugTools.[ILadybugTools](/api/oM/Adapter/LadybugTools/ILadybugTools)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The name of this EnergyMaterial. | - |
| Thickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Thickness of material (m). | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Conductivity | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Conductivity of material (W/mK). | - |
| Density | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Density of material (kg/m3). | [Density](/api/oM/Dimensional/Quantities/Attributes/Density) [kg/m³] |
| SpecificHeat | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Specific heat capacity of material (J/kgK). | - |
| Roughness | [Roughness](/api/oM/Adapter/LadybugTools/Roughness) | The roughness of the material. | - |
| ThermalAbsorptance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Thermal absorptivity (emissivity) of material (0-1). | - |
| SolarAbsorptance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Solar absorptivity of material (0-1). | - |
| VisibleAbsorptance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Light absorptivity (1 - albedo) of material (0-1). | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [EnergyMaterial.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/Constructions/EnergyMaterial.cs)

All history and changes of the class can be found by inspection the history.
