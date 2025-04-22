---
title: HollowCore
---

# Structure.SurfaceProperties.HollowCore

Property for 2D analytical elements, made up of a fixed thickness slab of homogenous material, with a series of parallel holes through it in a particular direction.

## Class structure

### Implemented interfaces and base types

???+ bhom "The HollowCore in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Structure.SurfaceProperties.[ISurfaceProperty](/api_documentation/oM/Analytical/Structure/SurfaceProperties/ISurfaceProperty)
    -  Structure.[IProperty](/api_documentation/oM/Analytical/Structure/IProperty)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | A unique Name is required for some structural packages to create and identify the object. | - |
| Thickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Defines the distance the element should be extruded along its normal. By default the element will be extruded half the thickness 'upwards' and half the thickness 'downwards' meaning the element base geoemtry will be in the centre of the extrusion. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Material | [IMaterialFragment](/api_documentation/oM/Analytical/Structure/MaterialFragments/IMaterialFragment) | Homogenous structural material throughout the full thickness of the element. | - |
| PanelType | [PanelType](/api_documentation/oM/Analytical/Structure/SurfaceProperties/PanelType) | Defines what type of element this property will be used. Used by some analysis packages. | - |
| Openings | [IHollowCoreOpeningProfiles](/api_documentation/oM/Analytical/Structure/SurfaceProperties/IHollowCoreOpeningProfiles) | Openings of the hollow core. | - |
| Direction | [PanelDirection](/api_documentation/oM/Analytical/Structure/SurfaceProperties/PanelDirection) | Specifies if the hollow cores are running in local x or y direction. | - |


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
| Construction | [Construction](/api_documentation/oM/Physical/Physical/Constructions/Construction) | Creates a physical Construction from a structural ISurfaceProperty. Extracts the Structural MaterialFragment and creates a physical material with the same name. | - | Structure_Engine |
| DescriptionOrName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gets the name from a IProperty. If null or empty, a default description name is provided instead. | - | Structure_Engine |
| HasModifiers | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a SurfaceProperty has any modifiers by first checking if any modifiers has been assigned, and if any of them are set to a value different than 1. | - | Structure_Engine |
| IConstruction | [Construction](/api_documentation/oM/Physical/Physical/Constructions/Construction) | Creates a physical Construction from a structural ISurfaceProperty. Extracts the Structural MaterialFragment and creates a physical material with the same name. | - | Structure_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the SurfaceProperty, based on type, dimensions and material. | - | Structure_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the IProperty, based on its properties. | - | Structure_Engine |
| IMassPerArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the mass per area for the property. | [MassPerUnitArea](/api_documentation/oM/Dimensional/Quantities/Attributes/MassPerUnitArea) [kg/m²] | Structure_Engine |
| IMaterialComposition | [MaterialComposition](/api_documentation/oM/Physical/Physical/Materials/MaterialComposition) | Returns a SurfaceProperty's MaterialComposition. | - | Structure_Engine |
| InvalidSurfaceProperty | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - | Lusas_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a SurfaceProperty is null and outputs relevant error message. | - | Structure_Engine |
| ITotalThickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total thickness of the surface property. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Structure_Engine |
| IVolumePerArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the volume per area of the property for the purpose of calculating solid volume. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Structure_Engine |
| Modifiers | [Double[]](https://learn.microsoft.com/en-us/dotnet/api/System.Double[]?view=netstandard-2.0) | Gets any modifiers from a property as an array of doubles. The modifiers are used to scale one or more of the property constants for analysis. Constants are multiplied with the modifiers, hence a modifier value of 1 means no change. <br>The values returned are in the following order: FXX, FXY, FYY, MXX, MXY, MYY, VXZ, VYZ, Mass, Weight. Method returns null if no modifiers are found. | - | Structure_Engine |
| TotalThickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the total thickness of the surface property. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Structure_Engine |
| VoidZoneHeight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the height of the hollow core zone of the hollow core property. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Structure_Engine |
| VoidZoneSolidRatio | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the ratio of solid material to void in the opening sone of the HollowCore, where 1 means no voids and 0 means complete void. Please note that this only relates to the thickness zone with voids, not including solid areas at top and bottom. | [Ratio](/api_documentation/oM/Dimensional/Quantities/Attributes/Ratio) [-] | Structure_Engine |
| VolumePerArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the volume per area of the property for the purpose of calculating solid volume. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Structure_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [HollowCore.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/SurfaceProperties\HollowCore.cs)

All history and changes of the class can be found by inspection the history.
