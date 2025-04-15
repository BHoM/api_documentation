---
title: FrameEdgeProperty
---

# Facade.SectionProperties.FrameEdgeProperty

Frame edge (eg mullion, window jamb, curtain wall sill, etc) property with list of Profile Section properties that make up the mullion construction.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FrameEdgeProperty in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/om_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SectionProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ConstantFramingProperty](/om_documentation/oM/Physical/Physical/FramingProperties/ConstantFramingProperty)&gt; | Collection of profiles that make up the mullion, each containing section geometry and a material. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/om_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Depth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns total depth of a frame edge property | - | Facade_Engine |
| SimpleGeometry | [Polyline](/om_documentation/oM/Dimensional/Geometry/Polyline) | Returns a simple rectangular geometric representation a frame edge property | - | Facade_Engine |
| Width | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns total width of a frame edge property | - | Facade_Engine |
| WidthIntoOpening | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns total width of a frame edge property | - | Facade_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [FrameEdgeProperty.cs](https://github.com/BHoM/BHoM/blob/develop/Facade_oM/SectionProperties\FrameEdgeProperty.cs)

All history and changes of the class can be found by inspection the history.
