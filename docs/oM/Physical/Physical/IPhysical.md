---
title: IPhysical
---

# Physical.IPhysical



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IPhysical in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Physical.Elements.[IFramingElement](/documentation/oM/Physical/Physical/Elements/IFramingElement)
    - Physical.Elements.[IOpening](/documentation/oM/Physical/Physical/Elements/IOpening)
    - Physical.Elements.[ISolid](/documentation/oM/Physical/Physical/Elements/ISolid)
    - Physical.Elements.[ISurface](/documentation/oM/Physical/Physical/Elements/ISurface)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Physical.Materials.[Material](/documentation/oM/Physical/Physical/Materials/Material)
    - Physical.Materials.[MaterialComposition](/documentation/oM/Physical/Physical/Materials/MaterialComposition)
    - Physical.Materials.[VolumetricMaterialTakeoff](/documentation/oM/Physical/Physical/Materials/VolumetricMaterialTakeoff)
    - Physical.Elements.[Beam](/documentation/oM/Physical/Physical/Elements/Beam)
    - Physical.Elements.[Bracing](/documentation/oM/Physical/Physical/Elements/Bracing)
    - Physical.Elements.[Cable](/documentation/oM/Physical/Physical/Elements/Cable)
    - Physical.Elements.[Column](/documentation/oM/Physical/Physical/Elements/Column)
    - Physical.Elements.[Door](/documentation/oM/Physical/Physical/Elements/Door)
    - Physical.Elements.[Floor](/documentation/oM/Physical/Physical/Elements/Floor)
    - Physical.Elements.[MeshElement](/documentation/oM/Physical/Physical/Elements/MeshElement)
    - Physical.Elements.[PadFoundation](/documentation/oM/Physical/Physical/Elements/PadFoundation)
    - Physical.Elements.[Pile](/documentation/oM/Physical/Physical/Elements/Pile)
    - Physical.Elements.[Roof](/documentation/oM/Physical/Physical/Elements/Roof)
    - Physical.Elements.[SolidBulk](/documentation/oM/Physical/Physical/Elements/SolidBulk)
    - Physical.Elements.[Void](/documentation/oM/Physical/Physical/Elements/Void)
    - Physical.Elements.[Wall](/documentation/oM/Physical/Physical/Elements/Wall)
    - Physical.Elements.[Window](/documentation/oM/Physical/Physical/Elements/Window)
    - Physical.Constructions.[Construction](/documentation/oM/Physical/Physical/Constructions/Construction)
    - Physical.Constructions.[Layer](/documentation/oM/Physical/Physical/Constructions/Layer)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| ExternalPolyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/documentation/oM/Dimensional/Geometry/Polyline)&gt; | Returns the External Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| InternalPolyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/documentation/oM/Dimensional/Geometry/Polyline)&gt; | Returns the Internal Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| Polyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/documentation/oM/Dimensional/Geometry/Polyline)&gt; | Returns a Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IPhysical.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/IPhysical.cs)

All history and changes of the class can be found by inspection the history.
