---
title: ResultType
---

# <small>BH.oM.Environment.Results.</small>**ResultType**



## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| AtmosphericPressure |  -  |
| DewPointTemperature |  -  |
| DiffuseHorizontalRadiation |  -  |
| DirectNormalRadiation |  -  |
| DryBulbTemperature |  -  |
| Enthalpy |  -  |
| GlobalHorizontalRadiation |  -  |
| HumidityRatio |  -  |
| Illuminance |  -  |
| Insolation |  -  |
| MeanRadiantTemperature |  -  |
| Power |  -  |
| RelativeHumidity |  -  |
| SkyTemperature |  -  |
| SurfaceTemperature |  -  |
| UniversalThermalClimateIndex |  -  |
| WetBulbTemperature |  -  |
| WindDirection |  -  |
| WindSpeed |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum ResultType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Environment_oM.dll

The enum is defined in C#. The class definition is available on github:

- [ResultType.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/Results\Enums\ResultType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Environment_oM/Results/ResultType.json}
```

The JSON Schema is available on github here:

- [ResultType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Environment_oM/Results/ResultType.json)
