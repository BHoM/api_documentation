---
title: IPhysical
---

# Physical.IPhysical



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IPhysical in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Physical.Elements.[IFramingElement](/api/oM/Physical/Physical/Elements/IFramingElement)
    - Physical.Elements.[IOpening](/api/oM/Physical/Physical/Elements/IOpening)
    - Physical.Elements.[ISolid](/api/oM/Physical/Physical/Elements/ISolid)
    - Physical.Elements.[ISurface](/api/oM/Physical/Physical/Elements/ISurface)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Physical.Materials.[Material](/api/oM/Physical/Physical/Materials/Material)
    - Physical.Materials.[MaterialComposition](/api/oM/Physical/Physical/Materials/MaterialComposition)
    - Physical.Materials.[VolumetricMaterialTakeoff](/api/oM/Physical/Physical/Materials/VolumetricMaterialTakeoff)
    - Physical.Elements.[Beam](/api/oM/Physical/Physical/Elements/Beam)
    - Physical.Elements.[Bracing](/api/oM/Physical/Physical/Elements/Bracing)
    - Physical.Elements.[Cable](/api/oM/Physical/Physical/Elements/Cable)
    - Physical.Elements.[Column](/api/oM/Physical/Physical/Elements/Column)
    - Physical.Elements.[Door](/api/oM/Physical/Physical/Elements/Door)
    - Physical.Elements.[Floor](/api/oM/Physical/Physical/Elements/Floor)
    - Physical.Elements.[MeshElement](/api/oM/Physical/Physical/Elements/MeshElement)
    - Physical.Elements.[PadFoundation](/api/oM/Physical/Physical/Elements/PadFoundation)
    - Physical.Elements.[Pile](/api/oM/Physical/Physical/Elements/Pile)
    - Physical.Elements.[Roof](/api/oM/Physical/Physical/Elements/Roof)
    - Physical.Elements.[SolidBulk](/api/oM/Physical/Physical/Elements/SolidBulk)
    - Physical.Elements.[Void](/api/oM/Physical/Physical/Elements/Void)
    - Physical.Elements.[Wall](/api/oM/Physical/Physical/Elements/Wall)
    - Physical.Elements.[Window](/api/oM/Physical/Physical/Elements/Window)
    - Physical.Constructions.[Construction](/api/oM/Physical/Physical/Constructions/Construction)
    - Physical.Constructions.[Layer](/api/oM/Physical/Physical/Constructions/Layer)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| ExternalPolyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api/oM/Dimensional/Geometry/Polyline)&gt; | Returns the External Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| InternalPolyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api/oM/Dimensional/Geometry/Polyline)&gt; | Returns the Internal Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| Polyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api/oM/Dimensional/Geometry/Polyline)&gt; | Returns a Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IPhysical.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/IPhysical.cs)

All history and changes of the class can be found by inspection the history.
