---
title: ISurface
---

# Analytical.Elements.ISurface



## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISurface in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)
    -  Analytical.[IAnalytical](/documentation/oM/Analytical/Analytical/IAnalytical)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Structure.Elements.[Surface](/documentation/oM/Analytical/Structure/Elements/Surface)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Extents | [ISurface](/documentation/oM/Dimensional/Geometry/ISurface) | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Geometry | [IGeometry](/documentation/oM/Dimensional/Geometry/IGeometry) | Gets the geometry of a analytical ISurface at its centre. Method required for automatic display in UI packages. | - | Analytical_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [ISurface.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Elements\ISurface.cs)

All history and changes of the class can be found by inspection the history.
