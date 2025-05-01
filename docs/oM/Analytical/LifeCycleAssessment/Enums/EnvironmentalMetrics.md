---
title: EnvironmentalMetrics
---

# <small>BH.oM.LifeCycleAssessment.</small>**EnvironmentalMetrics**

Enum of all available environmental indicators. Used for filtering metrics and results.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| AbioticDepletionFossilResources |  -  |
| AbioticDepletionMineralsAndMetals |  -  |
| Acidification |  -  |
| ClimateChangeBiogenic |  -  |
| ClimateChangeFossil |  -  |
| ClimateChangeLandUse |  -  |
| ClimateChangeTotal |  -  |
| ClimateChangeTotalNoBiogenic |  -  |
| EutrophicationCML |  -  |
| EutrophicationAquaticFreshwater |  -  |
| EutrophicationAquaticMarine |  -  |
| EutrophicationTerrestrial |  -  |
| EutrophicationTRACI |  -  |
| OzoneDepletion |  -  |
| PhotochemicalOzoneCreation |  -  |
| PhotochemicalOzoneCreationCML |  -  |
| PhotochemicalOzoneCreationTRACI |  -  |
| WaterDeprivation |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum EnvironmentalMetrics : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: LifeCycleAssessment_oM.dll

The enum is defined in C#. The class definition is available on github:

- [EnvironmentalMetrics.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/Enums\EnvironmentalMetrics.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LifeCycleAssessment_oM/EnvironmentalMetrics.json"
}
```

The JSON Schema is available on github here:

- [EnvironmentalMetrics.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LifeCycleAssessment_oM/EnvironmentalMetrics.json)
