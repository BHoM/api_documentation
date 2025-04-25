---
title: WallIteration
---

# <small>BH.oM.Environment.SAP.</small>**WallIteration**

Describe a single iteration for wall changes within the SAP Context. If values for both UValue and Curtain Wall are provided, both will be applied to the walls specified, i.e. they will not be blended to produce one iteration for the UValue change, one for Curtain Wall change, and one for both.

## Class structure

### Implemented interfaces and base types

???+ bhom "The WallIteration is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Environment.SAP.[IIteration](/api/oM/Adapter/Environment/Iteration/IIteration)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| UValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | New UValue to use for the Wall(s). Must be a positive number. Measured in Watts per Meter Squared Kelvin (W/m2K). | - |
| IsCurtainWall | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0)&gt; | Flag whether this iteration is to consider the wall a Curtain Wall (fully glazed). | - |
| Include | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | A list of Wallnames to make changes to. If this is left blank, then all walls in the SAP Report will be updated to have this UValue. | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Provide the name of this iteration. The name should be unique across all iterations in your model, and should match any coordination with other models (over heating, daylighting, etc.) you may be running parametrics on. | - |
| Prefix | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | What value should be used to prefix the name of this iteration when combining with other iterations. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class WallIteration : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Environment.SAP.IIteration
```

Assembly: SAP_oM.dll

The class is defined in C#. The class definition is available on github:

- [WallIteration.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Iteration\WallIteration.cs)

All history and changes of the class can be found by inspection the history.
