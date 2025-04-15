---
title: ExternalComfort
---

# LadybugTools.ExternalComfort



## Class structure

### Implemented interfaces and base types

???+ bhom "The ExternalComfort in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/om_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)
    -  LadybugTools.[ILadybugTools](/om_documentation/oM/Adapter/LadybugTools/ILadybugTools)
    -  Base.[IImmutable](/om_documentation/oM/Framework/Base/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SimulationResult | [SimulationResult](/om_documentation/oM/Adapter/LadybugTools/SimulationResult) | The SimulationResult associated with this object. | - |
| Typology | [Typology](/om_documentation/oM/Adapter/LadybugTools/Typology) | The typology in the processing of this object. | - |
| DryBulbTemperature | [HourlyContinuousCollection](/om_documentation/oM/Adapter/LadybugTools/HourlyContinuousCollection) | The calculated dry bulb temperature. | - |
| RelativeHumidity | [HourlyContinuousCollection](/om_documentation/oM/Adapter/LadybugTools/HourlyContinuousCollection) | The calculated relative humidity. | - |
| WindSpeed | [HourlyContinuousCollection](/om_documentation/oM/Adapter/LadybugTools/HourlyContinuousCollection) | The calculated wind speed. | - |
| MeanRadiantTemperature | [HourlyContinuousCollection](/om_documentation/oM/Adapter/LadybugTools/HourlyContinuousCollection) | The calculated mean radiant temperature. | - |
| UniversalThermalClimateIndex | [HourlyContinuousCollection](/om_documentation/oM/Adapter/LadybugTools/HourlyContinuousCollection) | The calculated universal thermal climate index. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/om_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [ExternalComfort.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/Simulation/ExternalComfort.cs)

All history and changes of the class can be found by inspection the history.
