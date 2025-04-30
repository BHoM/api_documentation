---
title: UTCIData
---

# <small>BH.oM.LadybugTools.</small>**UTCIData**



## Class structure

### Implemented interfaces and base types

???+ bhom "The UTCIData is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.LadybugTools.[ISimulationData](/api/oM/Adapter/LadybugTools/MetaData/ISimulationData)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


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

``` C# title="C#"
public class UTCIData : BH.oM.LadybugTools.ISimulationData, BH.oM.Base.IObject
```

Assembly: LadybugTools_oM.dll

The class is defined in C#. The class definition is available on github:

- [UTCIData.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/MetaData\UTCIData.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LadybugTools_oM/UTCIData.json}
```

The JSON Schema is available on github here:

- [UTCIData.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LadybugTools_oM/UTCIData.json)
