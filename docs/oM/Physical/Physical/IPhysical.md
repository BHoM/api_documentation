---
title: IPhysical
---

# Physical.IPhysical



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IPhysical in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Physical.Elements.[IFramingElement](/api_documentation/oM/Physical/Physical/Elements/IFramingElement)
    - Physical.Elements.[IOpening](/api_documentation/oM/Physical/Physical/Elements/IOpening)
    - Physical.Elements.[ISolid](/api_documentation/oM/Physical/Physical/Elements/ISolid)
    - Physical.Elements.[ISurface](/api_documentation/oM/Physical/Physical/Elements/ISurface)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Physical.Materials.[Material](/api_documentation/oM/Physical/Physical/Materials/Material)
    - Physical.Materials.[MaterialComposition](/api_documentation/oM/Physical/Physical/Materials/MaterialComposition)
    - Physical.Materials.[VolumetricMaterialTakeoff](/api_documentation/oM/Physical/Physical/Materials/VolumetricMaterialTakeoff)
    - Physical.Elements.[Beam](/api_documentation/oM/Physical/Physical/Elements/Beam)
    - Physical.Elements.[Bracing](/api_documentation/oM/Physical/Physical/Elements/Bracing)
    - Physical.Elements.[Cable](/api_documentation/oM/Physical/Physical/Elements/Cable)
    - Physical.Elements.[Column](/api_documentation/oM/Physical/Physical/Elements/Column)
    - Physical.Elements.[Door](/api_documentation/oM/Physical/Physical/Elements/Door)
    - Physical.Elements.[Floor](/api_documentation/oM/Physical/Physical/Elements/Floor)
    - Physical.Elements.[MeshElement](/api_documentation/oM/Physical/Physical/Elements/MeshElement)
    - Physical.Elements.[PadFoundation](/api_documentation/oM/Physical/Physical/Elements/PadFoundation)
    - Physical.Elements.[Pile](/api_documentation/oM/Physical/Physical/Elements/Pile)
    - Physical.Elements.[Roof](/api_documentation/oM/Physical/Physical/Elements/Roof)
    - Physical.Elements.[SolidBulk](/api_documentation/oM/Physical/Physical/Elements/SolidBulk)
    - Physical.Elements.[Void](/api_documentation/oM/Physical/Physical/Elements/Void)
    - Physical.Elements.[Wall](/api_documentation/oM/Physical/Physical/Elements/Wall)
    - Physical.Elements.[Window](/api_documentation/oM/Physical/Physical/Elements/Window)
    - Physical.Constructions.[Construction](/api_documentation/oM/Physical/Physical/Constructions/Construction)
    - Physical.Constructions.[Layer](/api_documentation/oM/Physical/Physical/Constructions/Layer)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| ExternalPolyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api_documentation/oM/Dimensional/Geometry/Polyline)&gt; | Returns the External Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| InternalPolyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api_documentation/oM/Dimensional/Geometry/Polyline)&gt; | Returns the Internal Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |
| Polyline | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Polyline](/api_documentation/oM/Dimensional/Geometry/Polyline)&gt; | Returns a Polyline representation of a physical object (e.g. wall or window). | - | Physical_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IPhysical.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/IPhysical.cs)

All history and changes of the class can be found by inspection the history.
