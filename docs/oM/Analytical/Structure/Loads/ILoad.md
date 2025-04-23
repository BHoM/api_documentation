---
title: ILoad
---

# Structure.Loads.ILoad

Base interface implemented by all load classes.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ILoad in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Structure.Loads.[IElementLoad](/api/oM/Analytical/Structure/Loads/IElementLoad%601)&lt;[T](/api/oM/Analytical/Structure/Loads/IElementLoad%601#t)&gt;


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.RFEM6.IntermediateDatastructure.Geometry.[RFEMFreeLineLoad](/api/oM/Adapter/Adapters/RFEM6/IntermediateDatastructure/Geometry/RFEMFreeLineLoad)
    - Adapters.RFEM6.IntermediateDatastructure.Geometry.[RFEMNonFreeLineLoad](/api/oM/Adapter/Adapters/RFEM6/IntermediateDatastructure/Geometry/RFEMNonFreeLineLoad)
    - Structure.Loads.[AreaDifferentialTemperatureLoad](/api/oM/Analytical/Structure/Loads/AreaDifferentialTemperatureLoad)
    - Structure.Loads.[AreaUniformlyDistributedLoad](/api/oM/Analytical/Structure/Loads/AreaUniformlyDistributedLoad)
    - Structure.Loads.[AreaUniformTemperatureLoad](/api/oM/Analytical/Structure/Loads/AreaUniformTemperatureLoad)
    - Structure.Loads.[BarDifferentialTemperatureLoad](/api/oM/Analytical/Structure/Loads/BarDifferentialTemperatureLoad)
    - Structure.Loads.[BarPointLoad](/api/oM/Analytical/Structure/Loads/BarPointLoad)
    - Structure.Loads.[BarPrestressLoad](/api/oM/Analytical/Structure/Loads/BarPrestressLoad)
    - Structure.Loads.[BarUniformlyDistributedLoad](/api/oM/Analytical/Structure/Loads/BarUniformlyDistributedLoad)
    - Structure.Loads.[BarUniformTemperatureLoad](/api/oM/Analytical/Structure/Loads/BarUniformTemperatureLoad)
    - Structure.Loads.[BarVaryingDistributedLoad](/api/oM/Analytical/Structure/Loads/BarVaryingDistributedLoad)
    - Structure.Loads.[ContourLoad](/api/oM/Analytical/Structure/Loads/ContourLoad)
    - Structure.Loads.[GeometricalLineLoad](/api/oM/Analytical/Structure/Loads/GeometricalLineLoad)
    - Structure.Loads.[GravityLoad](/api/oM/Analytical/Structure/Loads/GravityLoad)
    - Structure.Loads.[PointAcceleration](/api/oM/Analytical/Structure/Loads/PointAcceleration)
    - Structure.Loads.[PointDisplacement](/api/oM/Analytical/Structure/Loads/PointDisplacement)
    - Structure.Loads.[PointLoad](/api/oM/Analytical/Structure/Loads/PointLoad)
    - Structure.Loads.[PointVelocity](/api/oM/Analytical/Structure/Loads/PointVelocity)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Loadcase | [Loadcase](/api/oM/Analytical/Structure/Loads/Loadcase) | The Loadcase in which the load is applied. | - |
| Axis | [LoadAxis](/api/oM/Analytical/Structure/Loads/LoadAxis) | Defines whether the load is applied in local or global coordinates. | - |
| Projected | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true the load is projected along to the element. This means that the load will be reduced when its direction is at an angle to the element. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a Load is null and outputs relevant error message. | - | Structure_Engine |
| IVisualize | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[IGeometry](/api/oM/Dimensional/Geometry/IGeometry)&gt; | Draws arrows representing the load. Visualisation will depend on the load type. | - | Structure_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [ILoad.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Loads\ILoad.cs)

All history and changes of the class can be found by inspection the history.
