---
title: BarPrestressLoad
---

# Structure.Loads.BarPrestressLoad

Axial prestress load applied to Bars.

## Class structure

### Implemented interfaces and base types

???+ bhom "The BarPrestressLoad in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Structure.Loads.[IElementLoad](/api_documentation/oM/Analytical/Structure/Loads/IElementLoad%601)&lt;Structure.Elements.[Bar](/api_documentation/oM/Analytical/Structure/Elements/Bar)&gt;
    -  Structure.Loads.[ILoad](/api_documentation/oM/Analytical/Structure/Loads/ILoad)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Prestress | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Prestress force to be applied to the Bar. Positive for tension, negative for compression. | [Force](/api_documentation/oM/Dimensional/Quantities/Attributes/Force) [N] |
| Loadcase | [Loadcase](/api_documentation/oM/Analytical/Structure/Loads/Loadcase) | The Loadcase in which the load is applied. | - |
| Objects | [BHoMGroup](/api_documentation/oM/Framework/Base/BHoMGroup%601)&lt;[Bar](/api_documentation/oM/Analytical/Structure/Elements/Bar)&gt; | The group of Bars that the load should be applied to. For most analysis packages the objects added here need to be pulled from the analysis package before being assigned to the load. | - |
| Axis | [LoadAxis](/api_documentation/oM/Analytical/Structure/Loads/LoadAxis) | Defines whether the load is applied in local or global coordinates. | - |
| Projected | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true the load is projected to the element. This means that the load will be reduced when its direction is at an angle to the element. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Load is null and outputs relevant error message. | - | Structure_Engine |
| IVisualize | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[IGeometry](/api_documentation/oM/Dimensional/Geometry/IGeometry)&gt; | Draws arrows representing the load. Visualisation will depend on the load type. | - | Structure_Engine |
| Visualize | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api_documentation/oM/Dimensional/Geometry/ICurve)&gt; | Draws lines representing the Bar load over the length of the Bar elements in the load. | - | Structure_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [BarPrestressLoad.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Loads\BarPrestressLoad.cs)

All history and changes of the class can be found by inspection the history.
