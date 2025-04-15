---
title: RFEMNonFreeLineLoad
---

# Adapters.RFEM6.IntermediateDatastructure.Geometry.RFEMNonFreeLineLoad

Distributed load to be applied over a line.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RFEMNonFreeLineLoad in inheriting from the following base type(s) and implements the following interfaces:"

    -  Structure.Loads.[GeometricalLineLoad](/documentation/oM/Analytical/Structure/Loads/GeometricalLineLoad)
    -  Base.[BHoMObject](/documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)
    -  Structure.Loads.[IElementLoad](/documentation/oM/Analytical/Structure/Loads/IElementLoad%601)&lt;Structure.Elements.[IAreaElement](/documentation/oM/Analytical/Structure/Elements/IAreaElement)&gt;
    -  Structure.Loads.[ILoad](/documentation/oM/Analytical/Structure/Loads/ILoad)
    -  Adapters.RFEM6.IntermediateDatastructure.Loading.Interfaces.[IRFEMLineLoad](/documentation/oM/Adapter/Adapters/RFEM6/IntermediateDatastructure/Loading/Interfaces/IRFEMLineLoad)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| geometrialLineLoad | [GeometricalLineLoad](/documentation/oM/Analytical/Structure/Loads/GeometricalLineLoad) | - | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Loadcase | [Loadcase](/documentation/oM/Analytical/Structure/Loads/Loadcase) | The Loadcase in which the load is applied. | - |
| Axis | [LoadAxis](/documentation/oM/Analytical/Structure/Loads/LoadAxis) | Defines whether the load is applied in local or global coordinates. | - |
| Projected | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true the load is projected to the region. | - |
| ForceA | [Vector](/documentation/oM/Dimensional/Geometry/Vector) | Force per unit length at the start of the line. | [ForcePerUnitLength](/documentation/oM/Dimensional/Quantities/Attributes/ForcePerUnitLength) [N/m] |
| ForceB | [Vector](/documentation/oM/Dimensional/Geometry/Vector) | Force per unit length at the end of the line. | [ForcePerUnitLength](/documentation/oM/Dimensional/Quantities/Attributes/ForcePerUnitLength) [N/m] |
| MomentA | [Vector](/documentation/oM/Dimensional/Geometry/Vector) | Moment per unit length at the start of the line. | [MomentPerUnitLength](/documentation/oM/Dimensional/Quantities/Attributes/MomentPerUnitLength) [N.m/m] |
| MomentB | [Vector](/documentation/oM/Dimensional/Geometry/Vector) | Moment per unit length at the end of the line. | [MomentPerUnitLength](/documentation/oM/Dimensional/Quantities/Attributes/MomentPerUnitLength) [N.m/m] |
| Location | [Line](/documentation/oM/Dimensional/Geometry/Line) | Line defining the location of the load. | - |
| Objects | [BHoMGroup](/documentation/oM/Framework/Base/BHoMGroup%601)&lt;[IAreaElement](/documentation/oM/Analytical/Structure/Elements/IAreaElement)&gt; | A collection of IAreaElements (e.g. Panels) to apply the line load to. These are not required for all adapters. | - |
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Load is null and outputs relevant error message. | - | Structure_Engine |
| IVisualize | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[IGeometry](/documentation/oM/Dimensional/Geometry/IGeometry)&gt; | Draws arrows representing the load. Visualisation will depend on the load type. | - | Structure_Engine |
| Visualize | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/documentation/oM/Dimensional/Geometry/ICurve)&gt; | Draws arrows representing the load along the length of the line of the load. | - | Structure_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [RFEMNonFreeLineLoad.cs](https://github.com/BHoM/RFEM6_Toolkit/blob/develop/RFEM6_oM/IntermediateDatastructure/Loading/RFEMNonFreeLineLoad.cs)

All history and changes of the class can be found by inspection the history.
