---
title: ITimber
---

# Structure.MaterialFragments.ITimber

Base interface for all Timber Materials.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The ITimber in inheriting from the following base type(s) and implements the following interfaces:"

    -  Structure.MaterialFragments.[IOrthotropic](/api/oM/Analytical/Structure/MaterialFragments/IOrthotropic)
    -  Structure.MaterialFragments.[IMaterialFragment](/api/oM/Analytical/Structure/MaterialFragments/IMaterialFragment)
    -  Base.[IFragment](/api/oM/Framework/Base/IFragment)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  Physical.Materials.[IMaterialProperties](/api/oM/Physical/Physical/Materials/IMaterialProperties)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Structure.[IProperty](/api/oM/Analytical/Structure/IProperty)
    -  Physical.Materials.[IDensityProvider](/api/oM/Physical/Physical/Materials/IDensityProvider)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Structure.MaterialFragments.[Glulam](/api/oM/Analytical/Structure/MaterialFragments/Glulam)
    - Structure.MaterialFragments.[LaminatedVeneerLumberCrossbands](/api/oM/Analytical/Structure/MaterialFragments/LaminatedVeneerLumberCrossbands)
    - Structure.MaterialFragments.[LaminatedVeneerLumberParallel](/api/oM/Analytical/Structure/MaterialFragments/LaminatedVeneerLumberParallel)
    - Structure.MaterialFragments.[SawnTimber](/api/oM/Analytical/Structure/MaterialFragments/SawnTimber)
    - Structure.MaterialFragments.[Timber](/api/oM/Analytical/Structure/MaterialFragments/Timber)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| DensityCharacteristic | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Characteristic Density. Used to calculate other mechanical properties (not mass). Called ρk in Eurocode. | [Density](/api/oM/Dimensional/Quantities/Attributes/Density) [kg/m³] |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the material based on its properties. | - | Structure_Engine |
| DescriptionOrName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gets the name from a IProperty. If null or empty, a default description name is provided instead. | - | Structure_Engine |
| IDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Generates a default description for the IProperty, based on its properties. | - | Structure_Engine |
| IMaterialType | [MaterialType](/api/oM/Analytical/Structure/MaterialFragments/MaterialType) | Gets the material type from the MaterialFragment. | - | Structure_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a MaterialFragment is null and outputs relevant error message. | - | Structure_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [ITimber.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/MaterialFragments\ITimber.cs)

All history and changes of the class can be found by inspection the history.
