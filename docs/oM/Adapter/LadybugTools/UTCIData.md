---
title: UTCIData
---

# LadybugTools.UTCIData



## Class structure

### Implemented interfaces and base types

???+ bhom "The UTCIData in inheriting from the following base type(s) and implements the following interfaces:"

    -  LadybugTools.[ISimulationData](/api_documentation/oM/Adapter/LadybugTools/ISimulationData)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ComfortableRatio | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The ratio of comfortable hours to total hours. Comfortable hours are hours between 9 and 26�C. | - |
| HeatStressRatio | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The ratio of heat stress hours to total hours. Heat stress hours are hours greater than 26�C. | - |
| ColdStressRatio | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The ratio of cold stress hours to total hours. Cold stress hours are hours less than 9�C. | - |
| DaytimeComfortableRatio | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The ratio of daytime comfortable hours to daytime hours. Daytime comfortable hours are hours between 9 and 26�C and between 07:00-22:59. | - |
| DaytimeHeatStressRatio | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The ratio of daytime heat stress hours to daytime hours. Daytime heat stress hours are hours greater than 26�C and between 07:00-22:59. | - |
| DaytimeColdStressRatio | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The ratio of daytime cold stress hours to daytime hours. Daytime cold stress hours are hours less than 9�C and between 07:00-22:59. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [UTCIData.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/MetaData/UTCIData.cs)

All history and changes of the class can be found by inspection the history.
