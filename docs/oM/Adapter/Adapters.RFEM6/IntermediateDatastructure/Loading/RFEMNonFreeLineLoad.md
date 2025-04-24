---
title: RFEMNonFreeLineLoad
---

# <small>BH.oM.Adapters.RFEM6.IntermediateDatastructure.</small>**RFEMNonFreeLineLoad**

Distributed load to be applied over a line.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RFEMNonFreeLineLoad is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Structure.Loads.[GeometricalLineLoad](/api/oM/Analytical/Structure/Loads/GeometricalLineLoad)
    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Structure.Loads.[IElementLoad](/api/oM/Analytical/Structure/Loads/IElementLoad)&lt;BH.oM.Structure.Elements.[IAreaElement](/api/oM/Analytical/Structure/Elements/IAreaElement)&gt;
    -  BH.oM.Structure.Loads.[ILoad](/api/oM/Analytical/Structure/Loads/ILoad)
    -  BH.oM.Adapters.RFEM6.IntermediateDatastructure.Loading.Interfaces.[IRFEMLineLoad](/api/oM/Adapter/Adapters.RFEM6/IntermediateDatastructure/Loading/Interfaces/IRFEMLineLoad)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| geometrialLineLoad | [GeometricalLineLoad](/api/oM/Analytical/Structure/Loads/GeometricalLineLoad) | - | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Loadcase | [Loadcase](/api/oM/Analytical/Structure/Loads/Loadcase) | The Loadcase in which the load is applied. | - |
| Axis | [LoadAxis](/api/oM/Analytical/Structure/Loads/Enums/LoadAxis) | Defines whether the load is applied in local or global coordinates. | - |
| Projected | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true the load is projected to the region. | - |
| ForceA | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Force per unit length at the start of the line. | [ForcePerUnitLength](/api/oM/Dimensional/Quantities/Attributes/ForcePerUnitLength) [N/m] |
| ForceB | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Force per unit length at the end of the line. | [ForcePerUnitLength](/api/oM/Dimensional/Quantities/Attributes/ForcePerUnitLength) [N/m] |
| MomentA | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Moment per unit length at the start of the line. | [MomentPerUnitLength](/api/oM/Dimensional/Quantities/Attributes/MomentPerUnitLength) [N.m/m] |
| MomentB | [Vector](/api/oM/Dimensional/Geometry/Vector/Vector) | Moment per unit length at the end of the line. | [MomentPerUnitLength](/api/oM/Dimensional/Quantities/Attributes/MomentPerUnitLength) [N.m/m] |
| Location | [Line](/api/oM/Dimensional/Geometry/Curve/Line) | Line defining the location of the load. | - |
| Objects | [BHoMGroup](/api/oM/Framework/Base/BHoMGroup)&lt;[IAreaElement](/api/oM/Analytical/Structure/Elements/IAreaElement)&gt; | A collection of IAreaElements (e.g. Panels) to apply the line load to. These are not required for all adapters. | - |
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Load is null and outputs relevant error message. | - | Structure_Engine |
| IVisualize | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry)&gt; | Draws arrows representing the load. Visualisation will depend on the load type. | - | Structure_Engine |
| Visualize | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api/oM/Dimensional/Geometry/Curve/ICurve)&gt; | Draws arrows representing the load along the length of the line of the load. | - | Structure_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RFEMNonFreeLineLoad : BH.oM.Structure.Loads.GeometricalLineLoad,
BH.oM.Base.BHoMObject,
BH.oM.Base.IBHoMObject,
BH.oM.Base.IObject,
BH.oM.Structure.Loads.IElementLoad<BH.oM.Structure.Elements.IAreaElement>,
BH.oM.Structure.Loads.ILoad,
BH.oM.Adapters.RFEM6.IntermediateDatastructure.Loading.Interfaces.IRFEMLineLoad
```

Assembly: RFEM6_oM.dll

The class is defined in C#. The class definition is available on github:

- [RFEMNonFreeLineLoad.cs](https://github.com/BHoM/RFEM6_Toolkit/blob/develop/RFEM6_oM/IntermediateDatastructure\Loading\RFEMNonFreeLineLoad.cs)

All history and changes of the class can be found by inspection the history.
