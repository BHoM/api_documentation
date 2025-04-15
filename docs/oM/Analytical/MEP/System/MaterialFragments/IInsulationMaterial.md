---
title: IInsulationMaterial
---

# MEP.System.MaterialFragments.IInsulationMaterial

Insulation is the material surrounding a duct, pipe or wire which mitigates the loss of the internal conditions of the fluid within the object.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IInsulationMaterial in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IFragment](/om_documentation/oM/Framework/Base/IFragment)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)
    -  Physical.Materials.[IMaterialProperties](/om_documentation/oM/Physical/Physical/Materials/IMaterialProperties)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - MEP.System.MaterialFragments.[InsulationMaterial](/om_documentation/oM/Analytical/MEP/System/MaterialFragments/InsulationMaterial)
    - MEP.System.MaterialFragments.[LiningMaterial](/om_documentation/oM/Analytical/MEP/System/MaterialFragments/LiningMaterial)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| RValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | RValue is the measure of the resistance of conductive heat loss by the insulation material. | - |
| KValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | KValue is the measure of the insulation material's ability to conduct heat (W/m*K), the lower the KValue the better the ability to conduct heat. | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IInsulationMaterial.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/System\MaterialFragments\IInsulationMaterial.cs)

All history and changes of the class can be found by inspection the history.
