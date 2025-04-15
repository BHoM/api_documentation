---
title: IProfile
---

# Spatial.ShapeProfiles.IProfile

Base interface for all shape profiles.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IProfile in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Spatial.ShapeProfiles.[AngleProfile](/om_documentation/oM/Dimensional/Spatial/ShapeProfiles/AngleProfile)
    - Spatial.ShapeProfiles.[BoxProfile](/om_documentation/oM/Dimensional/Spatial/ShapeProfiles/BoxProfile)
    - Spatial.ShapeProfiles.[ChannelProfile](/om_documentation/oM/Dimensional/Spatial/ShapeProfiles/ChannelProfile)
    - Spatial.ShapeProfiles.[CircleProfile](/om_documentation/oM/Dimensional/Spatial/ShapeProfiles/CircleProfile)
    - Spatial.ShapeProfiles.[FabricatedBoxProfile](/om_documentation/oM/Dimensional/Spatial/ShapeProfiles/FabricatedBoxProfile)
    - Spatial.ShapeProfiles.[FabricatedISectionProfile](/om_documentation/oM/Dimensional/Spatial/ShapeProfiles/FabricatedISectionProfile)
    - Spatial.ShapeProfiles.[FreeFormProfile](/om_documentation/oM/Dimensional/Spatial/ShapeProfiles/FreeFormProfile)
    - Spatial.ShapeProfiles.[GeneralisedFabricatedBoxProfile](/om_documentation/oM/Dimensional/Spatial/ShapeProfiles/GeneralisedFabricatedBoxProfile)
    - Spatial.ShapeProfiles.[GeneralisedTSectionProfile](/om_documentation/oM/Dimensional/Spatial/ShapeProfiles/GeneralisedTSectionProfile)
    - Spatial.ShapeProfiles.[ISectionProfile](/om_documentation/oM/Dimensional/Spatial/ShapeProfiles/ISectionProfile)
    - Spatial.ShapeProfiles.[KiteProfile](/om_documentation/oM/Dimensional/Spatial/ShapeProfiles/KiteProfile)
    - Spatial.ShapeProfiles.[RectangleProfile](/om_documentation/oM/Dimensional/Spatial/ShapeProfiles/RectangleProfile)
    - Spatial.ShapeProfiles.[TaperedProfile](/om_documentation/oM/Dimensional/Spatial/ShapeProfiles/TaperedProfile)
    - Spatial.ShapeProfiles.[TaperFlangeChannelProfile](/om_documentation/oM/Dimensional/Spatial/ShapeProfiles/TaperFlangeChannelProfile)
    - Spatial.ShapeProfiles.[TaperFlangeISectionProfile](/om_documentation/oM/Dimensional/Spatial/ShapeProfiles/TaperFlangeISectionProfile)
    - Spatial.ShapeProfiles.[TSectionProfile](/om_documentation/oM/Dimensional/Spatial/ShapeProfiles/TSectionProfile)
    - Spatial.ShapeProfiles.[TubeProfile](/om_documentation/oM/Dimensional/Spatial/ShapeProfiles/TubeProfile)
    - Spatial.ShapeProfiles.[VoidedISectionProfile](/om_documentation/oM/Dimensional/Spatial/ShapeProfiles/VoidedISectionProfile)
    - Spatial.ShapeProfiles.[ZSectionProfile](/om_documentation/oM/Dimensional/Spatial/ShapeProfiles/ZSectionProfile)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Shape | [ShapeType](/om_documentation/oM/Dimensional/Spatial/ShapeProfiles/ShapeType) | - | - |
| Edges | [ReadOnlyCollection](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1?view=netstandard-2.0)&lt;[ICurve](/om_documentation/oM/Dimensional/Geometry/ICurve)&gt; | Edge curves that matches the dimensions in the global XY-plane. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Area | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the area of an IProfile. This assumes that the outermost curve(s) are solid. Curves inside a solid region are assumed to be openings, and curves within openings are assumed to be solid, etc. Also, for TaperedProfiles, the average area is returned. | [Area](/om_documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |
| Bounds | [BoundingBox](/om_documentation/oM/Dimensional/Geometry/BoundingBox) | Queries the BoundingBox of a Profile. Acts on the profile edges through the Geometry_Engine. | - | Spatial_Engine |
| DescriptionOrName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gets the name from a profile. If null or empty, a default description name is provided instead. | - | Structure_Engine |
| Geometry | [CompositeGeometry](/om_documentation/oM/Dimensional/Geometry/CompositeGeometry) | Queries edge curves from an IProfile. | - | Spatial_Engine |
| ICircularEquivalentDiameter | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the Circular Equivalent Diameter for elements that are non-circular, equivalent in length, fluid resistance and airflow. | - | MEP_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the Profile, based on dimensions. | - | Structure_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if an Profile is null and outputs relevant error message. | - | Spatial_Engine |
| IThickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the thickness of a ShapeProfile. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Spatial_Engine |
| ITorsionalConstant | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculates the torsional constant for the profile. Note that this is not the polar moment of inertia. | [TorsionConstant](/om_documentation/oM/Dimensional/Quantities/Attributes/TorsionConstant) [m⁴] | Structure_Engine |
| IWarpingConstant | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the warping constant for the profile. | [WarpingConstant](/om_documentation/oM/Dimensional/Quantities/Attributes/WarpingConstant) [m⁶] | Structure_Engine |
| VoidArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the void area enclosed by an IProfile. This assumes that the outermost curve(s) are solid. Curves inside a solid region are assumed to be openings, and curves within openings are assumed to be solid, etc. Also, for TaperedProfiles, the average void area is returned. | [Area](/om_documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] | Spatial_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IProfile.cs](https://github.com/BHoM/BHoM/blob/develop/Spatial_oM/ShapeProfiles\IProfile.cs)

All history and changes of the class can be found by inspection the history.
