---
title: ISurfaceProperty
---

# Structure.SurfaceProperties.ISurfaceProperty

Base interface for properties for 2D finite element structural objects such as Panels and FEMeshes.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISurfaceProperty in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)
    -  Structure.[IProperty](/om_documentation/oM/Analytical/Structure/IProperty)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.GSA.SurfaceProperties.[FabricPanelProperty](/om_documentation/oM/Adapter/Adapters/GSA/SurfaceProperties/FabricPanelProperty)
    - Structure.SurfaceProperties.[BiDirectionalVoided](/om_documentation/oM/Analytical/Structure/SurfaceProperties/BiDirectionalVoided)
    - Structure.SurfaceProperties.[BuiltUpDoubleRibbed](/om_documentation/oM/Analytical/Structure/SurfaceProperties/BuiltUpDoubleRibbed)
    - Structure.SurfaceProperties.[BuiltUpRibbed](/om_documentation/oM/Analytical/Structure/SurfaceProperties/BuiltUpRibbed)
    - Structure.SurfaceProperties.[Cassette](/om_documentation/oM/Analytical/Structure/SurfaceProperties/Cassette)
    - Structure.SurfaceProperties.[ConstantThickness](/om_documentation/oM/Analytical/Structure/SurfaceProperties/ConstantThickness)
    - Structure.SurfaceProperties.[CorrugatedDeck](/om_documentation/oM/Analytical/Structure/SurfaceProperties/CorrugatedDeck)
    - Structure.SurfaceProperties.[HollowCore](/om_documentation/oM/Analytical/Structure/SurfaceProperties/HollowCore)
    - Structure.SurfaceProperties.[Layered](/om_documentation/oM/Analytical/Structure/SurfaceProperties/Layered)
    - Structure.SurfaceProperties.[LoadingPanelProperty](/om_documentation/oM/Analytical/Structure/SurfaceProperties/LoadingPanelProperty)
    - Structure.SurfaceProperties.[OneDirectionalVoided](/om_documentation/oM/Analytical/Structure/SurfaceProperties/OneDirectionalVoided)
    - Structure.SurfaceProperties.[Ribbed](/om_documentation/oM/Analytical/Structure/SurfaceProperties/Ribbed)
    - Structure.SurfaceProperties.[SlabOnDeck](/om_documentation/oM/Analytical/Structure/SurfaceProperties/SlabOnDeck)
    - Structure.SurfaceProperties.[ToppedSlab](/om_documentation/oM/Analytical/Structure/SurfaceProperties/ToppedSlab)
    - Structure.SurfaceProperties.[Waffle](/om_documentation/oM/Analytical/Structure/SurfaceProperties/Waffle)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Material | [IMaterialFragment](/om_documentation/oM/Analytical/Structure/MaterialFragments/IMaterialFragment) | Structural material of the property. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Construction | [Construction](/om_documentation/oM/Physical/Physical/Constructions/Construction) | Creates a physical Construction from a structural ISurfaceProperty. Extracts the Structural MaterialFragment and creates a physical material with the same name. | - | Structure_Engine |
| DescriptionOrName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gets the name from a IProperty. If null or empty, a default description name is provided instead. | - | Structure_Engine |
| HasModifiers | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a SurfaceProperty has any modifiers by first checking if any modifiers has been assigned, and if any of them are set to a value different than 1. | - | Structure_Engine |
| IConstruction | [Construction](/om_documentation/oM/Physical/Physical/Constructions/Construction) | Creates a physical Construction from a structural ISurfaceProperty. Extracts the Structural MaterialFragment and creates a physical material with the same name. | - | Structure_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the SurfaceProperty, based on type, dimensions and material. | - | Structure_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the IProperty, based on its properties. | - | Structure_Engine |
| IMassPerArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the mass per area for the property. | [MassPerUnitArea](/om_documentation/oM/Dimensional/Quantities/Attributes/MassPerUnitArea) [kg/m²] | Structure_Engine |
| IMaterialComposition | [MaterialComposition](/om_documentation/oM/Physical/Physical/Materials/MaterialComposition) | Returns a SurfaceProperty's MaterialComposition. | - | Structure_Engine |
| InvalidSurfaceProperty | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - | Lusas_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a SurfaceProperty is null and outputs relevant error message. | - | Structure_Engine |
| ITotalThickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total thickness of the surface property. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Structure_Engine |
| IVolumePerArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the volume per area of the property for the purpose of calculating solid volume. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Structure_Engine |
| Modifiers | [Double[]](https://learn.microsoft.com/en-us/dotnet/api/System.Double[]?view=netstandard-2.0) | Gets any modifiers from a property as an array of doubles. The modifiers are used to scale one or more of the property constants for analysis. Constants are multiplied with the modifiers, hence a modifier value of 1 means no change. <br>The values returned are in the following order: FXX, FXY, FYY, MXX, MXY, MYY, VXZ, VYZ, Mass, Weight. Method returns null if no modifiers are found. | - | Structure_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [ISurfaceProperty.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/SurfaceProperties\ISurfaceProperty.cs)

All history and changes of the class can be found by inspection the history.
