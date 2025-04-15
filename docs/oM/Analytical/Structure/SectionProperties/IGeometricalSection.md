---
title: IGeometricalSection
---

# Structure.SectionProperties.IGeometricalSection

Interface for sections based on Shape profiles.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IGeometricalSection in inheriting from the following base type(s) and implements the following interfaces:"

    -  Structure.SectionProperties.[ISectionProperty](/documentation/oM/Analytical/Structure/SectionProperties/ISectionProperty)
    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)
    -  Structure.[IProperty](/documentation/oM/Analytical/Structure/IProperty)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Structure.SectionProperties.[ISteelSection](/documentation/oM/Analytical/Structure/SectionProperties/ISteelSection)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Structure.SectionProperties.[AluminiumSection](/documentation/oM/Analytical/Structure/SectionProperties/AluminiumSection)
    - Structure.SectionProperties.[CellularSection](/documentation/oM/Analytical/Structure/SectionProperties/CellularSection)
    - Structure.SectionProperties.[ConcreteSection](/documentation/oM/Analytical/Structure/SectionProperties/ConcreteSection)
    - Structure.SectionProperties.[GenericSection](/documentation/oM/Analytical/Structure/SectionProperties/GenericSection)
    - Structure.SectionProperties.[SteelSection](/documentation/oM/Analytical/Structure/SectionProperties/SteelSection)
    - Structure.SectionProperties.[TimberSection](/documentation/oM/Analytical/Structure/SectionProperties/TimberSection)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SectionProfile | [IProfile](/documentation/oM/Dimensional/Spatial/ShapeProfiles/IProfile) | Profile of the section, containing dimensions and section geometry. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| DescriptionOrName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gets the name from a IProperty. If null or empty, a default description name is provided instead. | - | Structure_Engine |
| Geometry | [IGeometry](/documentation/oM/Dimensional/Geometry/IGeometry) | Gets the geometry of a GeometricalSection as its profile outlines the global XY plane. Method required for automatic display in UI packages. | - | Structure_Engine |
| HasModifiers | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a SectionProperty has any modifiers by first checking if any modifiers has been assigned, and if any of them are set to a value different than 1. | - | Structure_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the SectionProperty, based on type, profile and material. | - | Structure_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the IProperty, based on its properties. | - | Structure_Engine |
| IGeometry | [IGeometry](/documentation/oM/Dimensional/Geometry/IGeometry) | Gets the geometry of a SectionProperty, generally as its profile outlines the global XY plane. Method required for automatic display in UI packages. | - | Structure_Engine |
| IMassPerMetre | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the mass per length for the section, generally as its area mulitplied by the density. General dispatch method that calls the correct method based on type. | [MassPerUnitLength](/documentation/oM/Dimensional/Quantities/Attributes/MassPerUnitLength) [kg/m] | Structure_Engine |
| IMaterialComposition | [MaterialComposition](/documentation/oM/Physical/Physical/Materials/MaterialComposition) | Returns a SectionProperty's MaterialComposition. | - | Structure_Engine |
| InvalidSectionProfile | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - | Lusas_Engine |
| InvalidSectionProperty | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - | Lusas_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a SectionProperty is null and outputs relevant error message. | - | Structure_Engine |
| IVolumePerLength | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the volume per length for the section, generally as its area mulitplied by the density. General dispatch method that calls the correct method based on type. | [MassPerUnitLength](/documentation/oM/Dimensional/Quantities/Attributes/MassPerUnitLength) [kg/m] | Structure_Engine |
| Modifiers | [Double[]](https://learn.microsoft.com/en-us/dotnet/api/System.Double[]?view=netstandard-2.0) | Gets any modifiers from a section as an array of doubles. The modifiers are used to scale one or more of the section constants for analysis.  Constants are multiplied with the modifiers, hence a modifier value of 1 means no change. <br>The values returned are in the following order: Area, Iy, Iz, J, Asy, Asz. Method returns null if no modifiers are found. | - | Structure_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IGeometricalSection.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/SectionProperties\IGeometricalSection.cs)

All history and changes of the class can be found by inspection the history.
