---
title: IConstruction
---

# Physical.Constructions.IConstruction



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IConstruction in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Physical.Constructions.[Construction](/api_documentation/oM/Physical/Physical/Constructions/Construction)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IMaterialComposition | [MaterialComposition](/api_documentation/oM/Physical/Physical/Materials/MaterialComposition) | Gets all the Materials a ExplicitBulk is composed of and in which ratios. | [Ratio](/api_documentation/oM/Dimensional/Quantities/Attributes/Ratio) [-] | Physical_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a IConstruction is null and outputs relevant error message. | - | Physical_Engine |
| IThickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Returns the thickness of a generic construction | - | Physical_Engine |
| IVolumePerArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the average thickness of the property for the purpose of calculating solid volume. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |
| UniqueConstructionName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a unique name for a given IConstruction object based on the material names, and the construction name if the flag is set | - | Environment_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IConstruction.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/Constructions\IConstruction.cs)

All history and changes of the class can be found by inspection the history.
