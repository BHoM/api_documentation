---
title: OpeningSchedule
---

# Environment.SAP.Excel.OpeningSchedule

The details of roofs from the users excel input.

## Class structure

### Implemented interfaces and base types

???+ bhom "The OpeningSchedule in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| OpeningType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The type of the opening. | - |
| UValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The uvalue of the opening. | - |
| GValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The gvalue of the opening. | - |
| TypeOfGlazing | [TypeOfGlazing](/documentation/oM/Adapter/Environment/SAP/TypeOfGlazing) | The type of glazing. | - |
| GlazingGap | [GlazingGap](/documentation/oM/Adapter/Environment/SAP/GlazingGap) | The glazing gap. | - |
| FrameFactor | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The frame factor of the opening. | - |
| FrameType | [TypeOfFrame](/documentation/oM/Adapter/Environment/SAP/TypeOfFrame) | The type of frame. | - |
| ArgonFilled | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If the opening is argon filled. | - |
| KryptonFilled | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If the opening is krypton filled. | - |
| DataSource | [OpeningDataSource](/documentation/oM/Adapter/Environment/SAP/OpeningDataSource) | The data source for the opening. | - |
| FloorIntersection | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Does the opening intersect with the floor? | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [OpeningSchedule.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Excel/OpeningSchedule.cs)

All history and changes of the class can be found by inspection the history.
