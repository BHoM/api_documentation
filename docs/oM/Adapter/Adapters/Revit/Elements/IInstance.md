---
title: IInstance
---

# Adapters.Revit.Elements.IInstance

A base interface for BHoM wrapper classes that can wrap Revit elements.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IInstance in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.Revit.Elements.[DraftingInstance](/api_documentation/oM/Adapter/Adapters/Revit/Elements/DraftingInstance)
    - Adapters.Revit.Elements.[ModelInstance](/api_documentation/oM/Adapter/Adapters/Revit/Elements/ModelInstance)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Properties | [InstanceProperties](/api_documentation/oM/Adapter/Adapters/Revit/Properties/InstanceProperties) | Information about family type of the instance. | - |
| Location | [IGeometry](/api_documentation/oM/Dimensional/Geometry/IGeometry) | Location of the instance in space. | - |
| Orientation | [Basis](/api_documentation/oM/Dimensional/Geometry/Basis) | Orientation of the instance in 2 or 3 dimensional space (depending on dimensionality of the instance). Applicable only to point-based instances. | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IInstance.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Elements/IInstance.cs)

All history and changes of the class can be found by inspection the history.
