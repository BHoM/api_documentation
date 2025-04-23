---
title: ExternalComfort
---

# LadybugTools.ExternalComfort



## Class structure

### Implemented interfaces and base types

???+ bhom "The ExternalComfort in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)
    -  LadybugTools.[ILadybugTools](/api/oM/Adapter/LadybugTools/ILadybugTools)
    -  Base.[IImmutable](/api/oM/Framework/Base/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SimulationResult | [SimulationResult](/api/oM/Adapter/LadybugTools/SimulationResult) | The SimulationResult associated with this object. | - |
| Typology | [Typology](/api/oM/Adapter/LadybugTools/Typology) | The typology in the processing of this object. | - |
| DryBulbTemperature | [HourlyContinuousCollection](/api/oM/Adapter/LadybugTools/HourlyContinuousCollection) | The calculated dry bulb temperature. | - |
| RelativeHumidity | [HourlyContinuousCollection](/api/oM/Adapter/LadybugTools/HourlyContinuousCollection) | The calculated relative humidity. | - |
| WindSpeed | [HourlyContinuousCollection](/api/oM/Adapter/LadybugTools/HourlyContinuousCollection) | The calculated wind speed. | - |
| MeanRadiantTemperature | [HourlyContinuousCollection](/api/oM/Adapter/LadybugTools/HourlyContinuousCollection) | The calculated mean radiant temperature. | - |
| UniversalThermalClimateIndex | [HourlyContinuousCollection](/api/oM/Adapter/LadybugTools/HourlyContinuousCollection) | The calculated universal thermal climate index. | - |


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

- [ExternalComfort.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/Simulation/ExternalComfort.cs)

All history and changes of the class can be found by inspection the history.
