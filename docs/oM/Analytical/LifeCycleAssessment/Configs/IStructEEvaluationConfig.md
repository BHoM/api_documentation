---
title: IStructEEvaluationConfig
---

# LifeCycleAssessment.Configs.IStructEEvaluationConfig

Config for evaluation of climate change metrics using methodology from IStructE.

## Class structure

### Implemented interfaces and base types

???+ bhom "The IStructEEvaluationConfig in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)
    -  LifeCycleAssessment.Configs.[IEvaluationConfig](/documentation/oM/Analytical/LifeCycleAssessment/Configs/IEvaluationConfig)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ProjectCost | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total cost of the project. | - |
| FloorArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total floor area for the project. | [Area](/documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] |
| TotalWeight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total mass for the project. | [Mass](/documentation/oM/Dimensional/Quantities/Attributes/Mass) [kg] |
| A5CarbonFactor | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Carbon factor for installation for the project. Gives an additional factor based on project cost and element weight. | [ClimateChangePerQuantity](/documentation/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity) [kg CO2 eq per unit] |
| C1CarbonFactor | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Carbon factor for De-construction Demolition for the project. C1 for each element is computed based on this value and total floor area times elements proportional weight to the total. | [ClimateChangePerQuantity](/documentation/oM/Dimensional/Quantities/Attributes/ClimateChangePerQuantity) [kg CO2 eq per unit] |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [IStructEEvaluationConfig.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/Configs\IStructEEvaluationConfig.cs)

All history and changes of the class can be found by inspection the history.
