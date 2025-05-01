---
title: PipeTypes
---

# <small>BH.oM.MEP.Enums.</small>**PipeTypes**

The type of pipe (e.g. Sanitary, Storm, Domestic Cold Water)

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| ChilledWaterSupply |  -  |
| ChilledWaterReturn |  -  |
| Condensate |  -  |
| CondenserWaterSupply |  -  |
| CondenserWaterReturn |  -  |
| DomesticColdWater |  -  |
| DomesticHotWater |  -  |
| DomesticHotWaterRecirculation |  -  |
| FuelOilSupply |  -  |
| FuelOilReturn |  -  |
| Gas |  -  |
| HeatingHotWaterSupply |  -  |
| HeatingHotWaterReturn |  -  |
| HeatRecoveryWaterSupply |  -  |
| HeatRecoveryWaterReturn |  -  |
| Sanitary |  -  |
| Sprinkler |  -  |
| Storm |  -  |
| Vent |  -  |
| Waste |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum PipeTypes : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: MEP_oM.dll

The C# enum definition is available on github:

- [PipeTypes.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/Enums\PipeTypes.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/MEP_oM/Enums/PipeTypes.json"
}
```

The JSON Schema is available on github here:

- [PipeTypes.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/MEP_oM/Enums/PipeTypes.json)
