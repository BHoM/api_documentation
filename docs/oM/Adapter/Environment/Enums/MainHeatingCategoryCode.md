---
title: MainHeatingCategoryCode
---

# <small>BH.oM.Environment.SAP.</small>**MainHeatingCategoryCode**

Codes used to indicate a category of main heating system.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| None |  -  |
| BoilerWRadiatorsOrUnderfloor |  -  |
| MicroCogeneration |  -  |
| HeatPumpWRadiatorsOrUnderfloor |  -  |
| HeatPumpWWarmAirDistribution |  -  |
| CommunityHeatingSystem |  -  |
| ElectricStorageHeaters |  -  |
| ElectricUnderfloorHeating |  -  |
| WarmAirSystem |  -  |
| RoomHeaters |  -  |
| OtherSystem |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum MainHeatingCategoryCode : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: SAP_oM.dll

The C# enum definition is available on github:

- [MainHeatingCategoryCode.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Enums\MainHeatingCategoryCode.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/MainHeatingCategoryCode.json"
}
```

The JSON Schema is available on github here:

- [MainHeatingCategoryCode.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/MainHeatingCategoryCode.json)
