---
title: WindSpeedCategory
---

# <small>BH.oM.LifeCycleAssessment.</small>**WindSpeedCategory**

Wind speed category is in reference to the Beaufort Scale of wind speeds, and are used only to represent an average site-based, wind condition. Specific information on categorisation can be found at https://www.spc.noaa.gov/faq/tornado/beaufort.html

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| Calm |  -  |
| FreshBreeze |  -  |
| Gale |  -  |
| GentleBreeze |  -  |
| Hurricane |  -  |
| LightAir |  -  |
| LightBreeze |  -  |
| ModerateBreeze |  -  |
| NearGale |  -  |
| Storm |  -  |
| StrongBreeze |  -  |
| StrongGale |  -  |
| ViolentStorm |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum WindSpeedCategory : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: LifeCycleAssessment_oM.dll

The C# enum definition is available on github:

- [WindSpeedCategory.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/Enums\WindSpeedCategory.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LifeCycleAssessment_oM/WindSpeedCategory.json"
}
```

The JSON Schema is available on github here:

- [WindSpeedCategory.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LifeCycleAssessment_oM/WindSpeedCategory.json)
