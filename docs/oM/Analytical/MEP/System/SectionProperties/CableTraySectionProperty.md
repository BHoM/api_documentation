---
title: CableTraySectionProperty
---

# MEP.System.SectionProperties.CableTraySectionProperty



## Class structure

### Implemented interfaces and base types

???+ bhom "The CableTraySectionProperty in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)
    -  Base.[IImmutable](/documentation/oM/Framework/Base/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Material | [Material](/documentation/oM/Physical/Physical/Materials/Material) | The cable tray material is the primary material that the it is composed of. | - |
| SectionProfile | [SectionProfile](/documentation/oM/Analytical/MEP/System/SectionProperties/SectionProfile) | The section profile of the object that will determine its use within a System. | - |
| ElementSolidArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | This area takes the element's thickness into account to determine the actual area of the 'solid' portion of the ShapeProfile. | - |
| ElementVoidArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The interior area within the element's shapeProfile. This corresponds to the actual open area less any material thickness. | - |


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

- [CableTraySectionProperty.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/System\SectionProperties\CableTraySectionProperty.cs)

All history and changes of the class can be found by inspection the history.
