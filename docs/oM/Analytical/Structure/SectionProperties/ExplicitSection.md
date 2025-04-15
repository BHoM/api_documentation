---
title: ExplicitSection
---

# Structure.SectionProperties.ExplicitSection

Material agnostic section. Does not own any geometry. Allows explicit setting of all section constants.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ExplicitSection in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/om_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)
    -  Structure.SectionProperties.[ISectionProperty](/om_documentation/oM/Analytical/Structure/SectionProperties/ISectionProperty)
    -  Structure.[IProperty](/om_documentation/oM/Analytical/Structure/IProperty)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | A unique Name is required for some structural packages to create and identify the object. | - |
| Material | [IMaterialFragment](/om_documentation/oM/Analytical/Structure/MaterialFragments/IMaterialFragment) | Material of the section. | - |
| Area | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gross Area of the cross section. | [Area](/om_documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] |
| Rgy | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Radius of Gyration about the local Y-Axis. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Rgz | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Radius of Gyration about the local Z-Axis. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| J | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Torsion Constant. | [TorsionConstant](/om_documentation/oM/Dimensional/Quantities/Attributes/TorsionConstant) [m⁴] |
| Iy | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Moment of Inertia about the local Y-Axis. | [SecondMomentOfArea](/om_documentation/oM/Dimensional/Quantities/Attributes/SecondMomentOfArea) [m⁴] |
| Iz | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Moment of Inertia about the local Z-Axis. | [SecondMomentOfArea](/om_documentation/oM/Dimensional/Quantities/Attributes/SecondMomentOfArea) [m⁴] |
| Iw | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Warping Constant. | [WarpingConstant](/om_documentation/oM/Dimensional/Quantities/Attributes/WarpingConstant) [m⁶] |
| Wely | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Elastic Modulus of the section about the local Y-Axis. | [SectionModulus](/om_documentation/oM/Dimensional/Quantities/Attributes/SectionModulus) [m³] |
| Welz | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Elastic Modulus of the section about the local Z-Axis. | [SectionModulus](/om_documentation/oM/Dimensional/Quantities/Attributes/SectionModulus) [m³] |
| Wply | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Plastic Modulus of the section about the local Y-Axis. | [SectionModulus](/om_documentation/oM/Dimensional/Quantities/Attributes/SectionModulus) [m³] |
| Wplz | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Plastic Modulus of the section about the local Z-Axis. | [SectionModulus](/om_documentation/oM/Dimensional/Quantities/Attributes/SectionModulus) [m³] |
| CentreZ | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Geometric centre of the section in the local Z direction. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| CentreY | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Geometric centre of the section in the local Y direction. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Vz | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Z distance from the centroid of the section to top edge of the section. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Vpz | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Z distance from the centroid of the section to bottom edge of the section. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Vy | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Y distance from the centroid of the section to right edge of the section. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Vpy | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Y distance from the centroid of the section to Left edge of the section. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Asy | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Shear Area in the local Y direction. | [Area](/om_documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] |
| Asz | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Shear Area in the local Z direction. | [Area](/om_documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] |


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
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the Section as 'Explicit Area Iy Iz J  - MaterialName'. | - | Structure_Engine |
| DescriptionOrName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gets the name from a IProperty. If null or empty, a default description name is provided instead. | - | Structure_Engine |
| HasModifiers | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a SectionProperty has any modifiers by first checking if any modifiers has been assigned, and if any of them are set to a value different than 1. | - | Structure_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the SectionProperty, based on type, profile and material. | - | Structure_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the IProperty, based on its properties. | - | Structure_Engine |
| IGeometry | [IGeometry](/om_documentation/oM/Dimensional/Geometry/IGeometry) | Gets the geometry of a SectionProperty, generally as its profile outlines the global XY plane. Method required for automatic display in UI packages. | - | Structure_Engine |
| IMassPerMetre | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the mass per length for the section, generally as its area mulitplied by the density. General dispatch method that calls the correct method based on type. | [MassPerUnitLength](/om_documentation/oM/Dimensional/Quantities/Attributes/MassPerUnitLength) [kg/m] | Structure_Engine |
| IMaterialComposition | [MaterialComposition](/om_documentation/oM/Physical/Physical/Materials/MaterialComposition) | Returns a SectionProperty's MaterialComposition. | - | Structure_Engine |
| InvalidSectionProfile | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - | Lusas_Engine |
| InvalidSectionProperty | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - | Lusas_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a SectionProperty is null and outputs relevant error message. | - | Structure_Engine |
| IVolumePerLength | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the volume per length for the section, generally as its area mulitplied by the density. General dispatch method that calls the correct method based on type. | [MassPerUnitLength](/om_documentation/oM/Dimensional/Quantities/Attributes/MassPerUnitLength) [kg/m] | Structure_Engine |
| Modifiers | [Double[]](https://learn.microsoft.com/en-us/dotnet/api/System.Double[]?view=netstandard-2.0) | Gets any modifiers from a section as an array of doubles. The modifiers are used to scale one or more of the section constants for analysis.  Constants are multiplied with the modifiers, hence a modifier value of 1 means no change. <br>The values returned are in the following order: Area, Iy, Iz, J, Asy, Asz. Method returns null if no modifiers are found. | - | Structure_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [ExplicitSection.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/SectionProperties\ExplicitSection.cs)

All history and changes of the class can be found by inspection the history.
