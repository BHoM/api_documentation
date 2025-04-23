---
title: DraftingInstance
---

# Adapters.Revit.Elements.DraftingInstance

A generic wrapper BHoM type corresponding to any view-specific Revit element (drafting elements e.g. lines and hatches, tags, text notes etc.).

## Class structure

### Implemented interfaces and base types

???+ bhom "The DraftingInstance in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  Adapters.Revit.Elements.[IInstance](/api/oM/Adapter/Adapters/Revit/Elements/IInstance)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Properties | [InstanceProperties](/api/oM/Adapter/Adapters/Revit/Properties/InstanceProperties) | Information about Revit family type or graphic type of the instance. | - |
| Location | [IGeometry](/api/oM/Dimensional/Geometry/IGeometry) | Location of the instance in three dimensional space. | - |
| Orientation | [Basis](/api/oM/Dimensional/Geometry/Basis) | Orientation of the instance in 2 dimensional space (only X and Y vectors are relevant). Applicable only to point-based DraftingInstances. If null, a default orientation will be applied. | - |
| ViewName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of Revit view to which the instance belongs. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [DraftingInstance.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Elements/DraftingInstance.cs)

All history and changes of the class can be found by inspection the history.
