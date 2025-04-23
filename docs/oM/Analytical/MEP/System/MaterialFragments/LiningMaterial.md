---
title: LiningMaterial
---

# MEP.System.MaterialFragments.LiningMaterial



## Class structure

### Implemented interfaces and base types

???+ bhom "The LiningMaterial in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  MEP.System.MaterialFragments.[IMEPMaterial](/api/oM/Analytical/MEP/System/MaterialFragments/IMEPMaterial)
    -  MEP.System.MaterialFragments.[IInsulationMaterial](/api/oM/Analytical/MEP/System/MaterialFragments/IInsulationMaterial)
    -  Base.[IFragment](/api/oM/Framework/Base/IFragment)
    -  Physical.Materials.[IMaterialProperties](/api/oM/Physical/Physical/Materials/IMaterialProperties)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| RValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | RValue is the measure of the resistance of conductive heat loss by the lining material. | - |
| KValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | KValue is the measure of the lining material's ability to conduct heat (W/m*K), the lower the KValue the better the ability to conduct heat. | - |
| Roughness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Roughness is a measure of the irregularities on the surface of the lining. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [LiningMaterial.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/System\MaterialFragments\LiningMaterial.cs)

All history and changes of the class can be found by inspection the history.
