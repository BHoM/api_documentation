---
title: SectionProfile
---

# MEP.System.SectionProperties.SectionProfile



## Class structure

### Implemented interfaces and base types

???+ bhom "The SectionProfile in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/om_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)
    -  Base.[IImmutable](/om_documentation/oM/Framework/Base/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ElementProfile | [IProfile](/om_documentation/oM/Dimensional/Spatial/ShapeProfiles/IProfile) | ShapeProfile of the element itself. This is the base ShapeProfile that determines the overall shape of the IFlow object. | - |
| LiningProfile | [IProfile](/om_documentation/oM/Dimensional/Spatial/ShapeProfiles/IProfile) | ShapeProfile of the element's interior lining. | - |
| InsulationProfile | [IProfile](/om_documentation/oM/Dimensional/Spatial/ShapeProfiles/IProfile) | ShapeProfile of the element's exterior insulation. | - |


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

- [SectionProfile.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/System\SectionProperties\SectionProfile.cs)

All history and changes of the class can be found by inspection the history.
