---
title: UIExposure
---

# <small>BH.oM.Base.Attributes.Enums.</small>**UIExposure**

Setting to determine whether an element using this enum should be displayed on a User Interface (UI).

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Display |  The associated element will be displayed on any UI exposing BHoM components.  |
| Hidden |  The associated element will NOT be displayed on any UI. The element will be accessible via code only.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum UIExposure : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: BHoM.dll

The enum is defined in C#. The class definition is available on github:

- [UIExposure.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Attributes\Enums\UIExposure.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/BHoM/Attributes/Enums/UIExposure.json}
```

The JSON Schema is available on github here:

- [UIExposure.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/BHoM/Attributes/Enums/UIExposure.json)
