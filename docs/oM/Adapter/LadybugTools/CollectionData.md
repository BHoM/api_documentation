---
title: CollectionData
---

# LadybugTools.CollectionData



## Class structure

### Implemented interfaces and base types

???+ bhom "The CollectionData in inheriting from the following base type(s) and implements the following interfaces:"

    -  LadybugTools.[ISimulationData](/api_documentation/oM/Adapter/LadybugTools/ISimulationData)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| HighestValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The maximum value in the collection. | - |
| LowestValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The minimum value in the collection. | - |
| HighestIndex | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | The date and time at which the maximum value occurs. | - |
| LowestIndex | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/System.DateTime?view=netstandard-2.0) | The date and time at which the minimum value occurs. | - |
| MedianValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The median (50 percentile) value in the collection. | - |
| MeanValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The mean value of the collection. | - |
| MonthlyMeans | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)&gt; | The mean values for each month. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [CollectionData.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/MetaData/CollectionData.cs)

All history and changes of the class can be found by inspection the history.
