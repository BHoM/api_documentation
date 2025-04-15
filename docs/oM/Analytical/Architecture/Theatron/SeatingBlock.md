---
title: SeatingBlock
---

# Architecture.Theatron.SeatingBlock



## Class structure

### Implemented interfaces and base types

???+ bhom "The SeatingBlock in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/om_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Start | [ProfileOrigin](/om_documentation/oM/Analytical/Architecture/Theatron/ProfileOrigin) | - | - |
| Vomitory | [ProfileOrigin](/om_documentation/oM/Analytical/Architecture/Theatron/ProfileOrigin) | - | - |
| End | [ProfileOrigin](/om_documentation/oM/Analytical/Architecture/Theatron/ProfileOrigin) | - | - |
| Sections | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[TierProfile](/om_documentation/oM/Analytical/Architecture/Theatron/TierProfile)&gt; | - | - |
| Floor | [Mesh](/om_documentation/oM/Dimensional/Geometry/Mesh) | - | - |
| Audience | [Audience](/om_documentation/oM/Physical/Humans/ViewQuality/Audience) | - | - |
| FrontRow | [Line](/om_documentation/oM/Dimensional/Geometry/Line) | - | - |
| SeatWidth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| AisleWidth | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| TypeOfSeatingBlock | [SeatingBlockType](/om_documentation/oM/Analytical/Architecture/Theatron/SeatingBlockType) | - | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/om_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [SeatingBlock.cs](https://github.com/BHoM/BHoM/blob/develop/Architecture_oM/Theatron/Elements/SeatingBlock.cs)

All history and changes of the class can be found by inspection the history.
