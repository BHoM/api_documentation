---
title: IProperty
---

# Structure.IProperty

Base interface for all structural properties.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IProperty in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Structure.SurfaceProperties.[ISurfaceProperty](/documentation/oM/Analytical/Structure/SurfaceProperties/ISurfaceProperty)
    - Structure.SectionProperties.[IGeometricalSection](/documentation/oM/Analytical/Structure/SectionProperties/IGeometricalSection)
    - Structure.SectionProperties.[ISectionProperty](/documentation/oM/Analytical/Structure/SectionProperties/ISectionProperty)
    - Structure.SectionProperties.[ISteelSection](/documentation/oM/Analytical/Structure/SectionProperties/ISteelSection)
    - Structure.MaterialFragments.[IIsotropic](/documentation/oM/Analytical/Structure/MaterialFragments/IIsotropic)
    - Structure.MaterialFragments.[IMaterialFragment](/documentation/oM/Analytical/Structure/MaterialFragments/IMaterialFragment)
    - Structure.MaterialFragments.[IOrthotropic](/documentation/oM/Analytical/Structure/MaterialFragments/IOrthotropic)
    - Structure.MaterialFragments.[ITimber](/documentation/oM/Analytical/Structure/MaterialFragments/ITimber)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.GSA.SurfaceProperties.[FabricPanelProperty](/documentation/oM/Adapter/Adapters/GSA/SurfaceProperties/FabricPanelProperty)
    - Adapters.GSA.SpacerProperties.[SpacerProperty](/documentation/oM/Adapter/Adapters/GSA/SpacerProperties/SpacerProperty)
    - Adapters.GSA.MaterialFragments.[Fabric](/documentation/oM/Adapter/Adapters/GSA/MaterialFragments/Fabric)
    - Adapters.GSA.FormFindingProperties.[SoapStress1D](/documentation/oM/Adapter/Adapters/GSA/FormFindingProperties/SoapStress1D)
    - Adapters.GSA.FormFindingProperties.[SoapStress2D](/documentation/oM/Adapter/Adapters/GSA/FormFindingProperties/SoapStress2D)
    - Structure.SurfaceProperties.[BiDirectionalVoided](/documentation/oM/Analytical/Structure/SurfaceProperties/BiDirectionalVoided)
    - Structure.SurfaceProperties.[BuiltUpDoubleRibbed](/documentation/oM/Analytical/Structure/SurfaceProperties/BuiltUpDoubleRibbed)
    - Structure.SurfaceProperties.[BuiltUpRibbed](/documentation/oM/Analytical/Structure/SurfaceProperties/BuiltUpRibbed)
    - Structure.SurfaceProperties.[Cassette](/documentation/oM/Analytical/Structure/SurfaceProperties/Cassette)
    - Structure.SurfaceProperties.[ConstantThickness](/documentation/oM/Analytical/Structure/SurfaceProperties/ConstantThickness)
    - Structure.SurfaceProperties.[CorrugatedDeck](/documentation/oM/Analytical/Structure/SurfaceProperties/CorrugatedDeck)
    - Structure.SurfaceProperties.[HollowCore](/documentation/oM/Analytical/Structure/SurfaceProperties/HollowCore)
    - Structure.SurfaceProperties.[Layered](/documentation/oM/Analytical/Structure/SurfaceProperties/Layered)
    - Structure.SurfaceProperties.[LoadingPanelProperty](/documentation/oM/Analytical/Structure/SurfaceProperties/LoadingPanelProperty)
    - Structure.SurfaceProperties.[OneDirectionalVoided](/documentation/oM/Analytical/Structure/SurfaceProperties/OneDirectionalVoided)
    - Structure.SurfaceProperties.[Ribbed](/documentation/oM/Analytical/Structure/SurfaceProperties/Ribbed)
    - Structure.SurfaceProperties.[SlabOnDeck](/documentation/oM/Analytical/Structure/SurfaceProperties/SlabOnDeck)
    - Structure.SurfaceProperties.[ToppedSlab](/documentation/oM/Analytical/Structure/SurfaceProperties/ToppedSlab)
    - Structure.SurfaceProperties.[Waffle](/documentation/oM/Analytical/Structure/SurfaceProperties/Waffle)
    - Structure.SectionProperties.[AluminiumSection](/documentation/oM/Analytical/Structure/SectionProperties/AluminiumSection)
    - Structure.SectionProperties.[CableSection](/documentation/oM/Analytical/Structure/SectionProperties/CableSection)
    - Structure.SectionProperties.[CellularSection](/documentation/oM/Analytical/Structure/SectionProperties/CellularSection)
    - Structure.SectionProperties.[CompositeSection](/documentation/oM/Analytical/Structure/SectionProperties/CompositeSection)
    - Structure.SectionProperties.[ConcreteSection](/documentation/oM/Analytical/Structure/SectionProperties/ConcreteSection)
    - Structure.SectionProperties.[ExplicitSection](/documentation/oM/Analytical/Structure/SectionProperties/ExplicitSection)
    - Structure.SectionProperties.[GenericSection](/documentation/oM/Analytical/Structure/SectionProperties/GenericSection)
    - Structure.SectionProperties.[SteelSection](/documentation/oM/Analytical/Structure/SectionProperties/SteelSection)
    - Structure.SectionProperties.[TimberSection](/documentation/oM/Analytical/Structure/SectionProperties/TimberSection)
    - Structure.Offsets.[Offset](/documentation/oM/Analytical/Structure/Offsets/Offset)
    - Structure.MaterialFragments.[Aluminium](/documentation/oM/Analytical/Structure/MaterialFragments/Aluminium)
    - Structure.MaterialFragments.[Concrete](/documentation/oM/Analytical/Structure/MaterialFragments/Concrete)
    - Structure.MaterialFragments.[GenericIsotropicMaterial](/documentation/oM/Analytical/Structure/MaterialFragments/GenericIsotropicMaterial)
    - Structure.MaterialFragments.[GenericOrthotropicMaterial](/documentation/oM/Analytical/Structure/MaterialFragments/GenericOrthotropicMaterial)
    - Structure.MaterialFragments.[Glulam](/documentation/oM/Analytical/Structure/MaterialFragments/Glulam)
    - Structure.MaterialFragments.[LaminatedVeneerLumberCrossbands](/documentation/oM/Analytical/Structure/MaterialFragments/LaminatedVeneerLumberCrossbands)
    - Structure.MaterialFragments.[LaminatedVeneerLumberParallel](/documentation/oM/Analytical/Structure/MaterialFragments/LaminatedVeneerLumberParallel)
    - Structure.MaterialFragments.[SawnTimber](/documentation/oM/Analytical/Structure/MaterialFragments/SawnTimber)
    - Structure.MaterialFragments.[Steel](/documentation/oM/Analytical/Structure/MaterialFragments/Steel)
    - Structure.MaterialFragments.[Timber](/documentation/oM/Analytical/Structure/MaterialFragments/Timber)
    - Structure.Constraints.[BarRelease](/documentation/oM/Analytical/Structure/Constraints/BarRelease)
    - Structure.Constraints.[Constraint3DOF](/documentation/oM/Analytical/Structure/Constraints/Constraint3DOF)
    - Structure.Constraints.[Constraint4DOF](/documentation/oM/Analytical/Structure/Constraints/Constraint4DOF)
    - Structure.Constraints.[Constraint6DOF](/documentation/oM/Analytical/Structure/Constraints/Constraint6DOF)
    - Structure.Constraints.[LinkConstraint](/documentation/oM/Analytical/Structure/Constraints/LinkConstraint)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| DescriptionOrName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gets the name from a IProperty. If null or empty, a default description name is provided instead. | - | Structure_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the IProperty, based on its properties. | - | Structure_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IProperty.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/IProperty.cs)

All history and changes of the class can be found by inspection the history.
