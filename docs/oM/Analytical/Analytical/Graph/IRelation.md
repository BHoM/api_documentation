---
title: IRelation
---

# Analytical.Graph.IRelation

Interface common to all Relation objects.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IRelation in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Analytical.Graph.[Relation](/documentation/oM/Analytical/Analytical/Graph/Relation)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Source | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Target | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Subgraph | [Graph](/documentation/oM/Analytical/Analytical/Graph/Graph) | - | - |
| Weight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| Curve | [ICurve](/documentation/oM/Dimensional/Geometry/ICurve) | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| RelationArrow | [CompositeGeometry](/documentation/oM/Dimensional/Geometry/CompositeGeometry) | Returns arrow geometry used to represent a Relation. | - | Analytical_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IRelation.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Graph\IRelation.cs)

All history and changes of the class can be found by inspection the history.
