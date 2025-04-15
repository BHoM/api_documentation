---
title: OrientationIteration
---

# Environment.SAP.OrientationIteration

Describe a single iteration for the orientation of the dwellings within the SAP Report. If both a mirror and a rotation are provided, the dwelling will be first mirrored and then rotated clockwise based on the rotation.

## Class structure

### Implemented interfaces and base types

???+ bhom "The OrientationIteration in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/om_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)
    -  Environment.SAP.[IIteration](/om_documentation/oM/Adapter/Environment/SAP/IIteration)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Mirror | [Mirror](/om_documentation/oM/Adapter/Environment/SAP/Mirror) | Mirror the dwelling straight down a mirror line of the 8 compass points. If no mirror rotation is provided, then no changes to orientation will be made from it (i.e. leave blank to not mirror the dwellings). | - |
| Rotation | [Rotation](/om_documentation/oM/Adapter/Environment/SAP/Rotation) | What rotation to provide to the dwelling in a clockwise direction? Rotation is scaled 1-8 based on the rotation provided. If no rotation is provided, then no changes to orientation will be made. | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Provide the name of this iteration. The name should be unique across all iterations in your model, and should match any coordination with other models (over heating, daylighting, etc.) you may be running parametrics on. | - |
| Prefix | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | What value should be used to prefix the name of this iteration when combining with other iterations. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/om_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [OrientationIteration.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Iteration/OrientationIteration.cs)

All history and changes of the class can be found by inspection the history.
