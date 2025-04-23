---
title: IProperty
---

# Structure.IProperty

Base interface for all structural properties.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IProperty in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/api/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Structure.SurfaceProperties.[ISurfaceProperty](/api/oM/Analytical/Structure/SurfaceProperties/ISurfaceProperty)
    - Structure.SectionProperties.[IGeometricalSection](/api/oM/Analytical/Structure/SectionProperties/IGeometricalSection)
    - Structure.SectionProperties.[ISectionProperty](/api/oM/Analytical/Structure/SectionProperties/ISectionProperty)
    - Structure.SectionProperties.[ISteelSection](/api/oM/Analytical/Structure/SectionProperties/ISteelSection)
    - Structure.MaterialFragments.[IIsotropic](/api/oM/Analytical/Structure/MaterialFragments/IIsotropic)
    - Structure.MaterialFragments.[IMaterialFragment](/api/oM/Analytical/Structure/MaterialFragments/IMaterialFragment)
    - Structure.MaterialFragments.[IOrthotropic](/api/oM/Analytical/Structure/MaterialFragments/IOrthotropic)
    - Structure.MaterialFragments.[ITimber](/api/oM/Analytical/Structure/MaterialFragments/ITimber)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.GSA.SurfaceProperties.[FabricPanelProperty](/api/oM/Adapter/Adapters/GSA/SurfaceProperties/FabricPanelProperty)
    - Adapters.GSA.SpacerProperties.[SpacerProperty](/api/oM/Adapter/Adapters/GSA/SpacerProperties/SpacerProperty)
    - Adapters.GSA.MaterialFragments.[Fabric](/api/oM/Adapter/Adapters/GSA/MaterialFragments/Fabric)
    - Adapters.GSA.FormFindingProperties.[SoapStress1D](/api/oM/Adapter/Adapters/GSA/FormFindingProperties/SoapStress1D)
    - Adapters.GSA.FormFindingProperties.[SoapStress2D](/api/oM/Adapter/Adapters/GSA/FormFindingProperties/SoapStress2D)
    - Structure.SurfaceProperties.[BiDirectionalVoided](/api/oM/Analytical/Structure/SurfaceProperties/BiDirectionalVoided)
    - Structure.SurfaceProperties.[BuiltUpDoubleRibbed](/api/oM/Analytical/Structure/SurfaceProperties/BuiltUpDoubleRibbed)
    - Structure.SurfaceProperties.[BuiltUpRibbed](/api/oM/Analytical/Structure/SurfaceProperties/BuiltUpRibbed)
    - Structure.SurfaceProperties.[Cassette](/api/oM/Analytical/Structure/SurfaceProperties/Cassette)
    - Structure.SurfaceProperties.[ConstantThickness](/api/oM/Analytical/Structure/SurfaceProperties/ConstantThickness)
    - Structure.SurfaceProperties.[CorrugatedDeck](/api/oM/Analytical/Structure/SurfaceProperties/CorrugatedDeck)
    - Structure.SurfaceProperties.[HollowCore](/api/oM/Analytical/Structure/SurfaceProperties/HollowCore)
    - Structure.SurfaceProperties.[Layered](/api/oM/Analytical/Structure/SurfaceProperties/Layered)
    - Structure.SurfaceProperties.[LoadingPanelProperty](/api/oM/Analytical/Structure/SurfaceProperties/LoadingPanelProperty)
    - Structure.SurfaceProperties.[OneDirectionalVoided](/api/oM/Analytical/Structure/SurfaceProperties/OneDirectionalVoided)
    - Structure.SurfaceProperties.[Ribbed](/api/oM/Analytical/Structure/SurfaceProperties/Ribbed)
    - Structure.SurfaceProperties.[SlabOnDeck](/api/oM/Analytical/Structure/SurfaceProperties/SlabOnDeck)
    - Structure.SurfaceProperties.[ToppedSlab](/api/oM/Analytical/Structure/SurfaceProperties/ToppedSlab)
    - Structure.SurfaceProperties.[Waffle](/api/oM/Analytical/Structure/SurfaceProperties/Waffle)
    - Structure.SectionProperties.[AluminiumSection](/api/oM/Analytical/Structure/SectionProperties/AluminiumSection)
    - Structure.SectionProperties.[CableSection](/api/oM/Analytical/Structure/SectionProperties/CableSection)
    - Structure.SectionProperties.[CellularSection](/api/oM/Analytical/Structure/SectionProperties/CellularSection)
    - Structure.SectionProperties.[CompositeSection](/api/oM/Analytical/Structure/SectionProperties/CompositeSection)
    - Structure.SectionProperties.[ConcreteSection](/api/oM/Analytical/Structure/SectionProperties/ConcreteSection)
    - Structure.SectionProperties.[ExplicitSection](/api/oM/Analytical/Structure/SectionProperties/ExplicitSection)
    - Structure.SectionProperties.[GenericSection](/api/oM/Analytical/Structure/SectionProperties/GenericSection)
    - Structure.SectionProperties.[SteelSection](/api/oM/Analytical/Structure/SectionProperties/SteelSection)
    - Structure.SectionProperties.[TimberSection](/api/oM/Analytical/Structure/SectionProperties/TimberSection)
    - Structure.Offsets.[Offset](/api/oM/Analytical/Structure/Offsets/Offset)
    - Structure.MaterialFragments.[Aluminium](/api/oM/Analytical/Structure/MaterialFragments/Aluminium)
    - Structure.MaterialFragments.[Concrete](/api/oM/Analytical/Structure/MaterialFragments/Concrete)
    - Structure.MaterialFragments.[GenericIsotropicMaterial](/api/oM/Analytical/Structure/MaterialFragments/GenericIsotropicMaterial)
    - Structure.MaterialFragments.[GenericOrthotropicMaterial](/api/oM/Analytical/Structure/MaterialFragments/GenericOrthotropicMaterial)
    - Structure.MaterialFragments.[Glulam](/api/oM/Analytical/Structure/MaterialFragments/Glulam)
    - Structure.MaterialFragments.[LaminatedVeneerLumberCrossbands](/api/oM/Analytical/Structure/MaterialFragments/LaminatedVeneerLumberCrossbands)
    - Structure.MaterialFragments.[LaminatedVeneerLumberParallel](/api/oM/Analytical/Structure/MaterialFragments/LaminatedVeneerLumberParallel)
    - Structure.MaterialFragments.[SawnTimber](/api/oM/Analytical/Structure/MaterialFragments/SawnTimber)
    - Structure.MaterialFragments.[Steel](/api/oM/Analytical/Structure/MaterialFragments/Steel)
    - Structure.MaterialFragments.[Timber](/api/oM/Analytical/Structure/MaterialFragments/Timber)
    - Structure.Constraints.[BarRelease](/api/oM/Analytical/Structure/Constraints/BarRelease)
    - Structure.Constraints.[Constraint3DOF](/api/oM/Analytical/Structure/Constraints/Constraint3DOF)
    - Structure.Constraints.[Constraint4DOF](/api/oM/Analytical/Structure/Constraints/Constraint4DOF)
    - Structure.Constraints.[Constraint6DOF](/api/oM/Analytical/Structure/Constraints/Constraint6DOF)
    - Structure.Constraints.[LinkConstraint](/api/oM/Analytical/Structure/Constraints/LinkConstraint)


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
