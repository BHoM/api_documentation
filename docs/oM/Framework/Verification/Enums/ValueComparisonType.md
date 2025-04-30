---
title: ValueComparisonType
---

# <small>BH.oM.Verification.</small>**ValueComparisonType**

Specifies the requirement to be met by a value in relation to a reference value to consider the check as passed.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| EqualTo |  -  |
| NotEqualTo |  -  |
| LessThan |  -  |
| LessThanOrEqualTo |  -  |
| GreaterThanOrEqualTo |  -  |
| GreaterThan |  -  |
| Contains |  -  |
| StartsWith |  -  |
| EndsWith |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum ValueComparisonType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Verification_oM.dll

The enum is defined in C#. The class definition is available on github:

- [ValueComparisonType.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Enums\ValueComparisonType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Verification_oM/ValueComparisonType.json}
```

The JSON Schema is available on github here:

- [ValueComparisonType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Verification_oM/ValueComparisonType.json)
