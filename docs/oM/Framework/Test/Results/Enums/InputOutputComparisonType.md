---
title: InputOutputComparisonType
---

# <small>BH.oM.Test.Results.</small>**InputOutputComparisonType**

Type of difference or error of the result.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Equal |  Pulled object is identical to pushed obejct  |
| Exception |  Something in the process went wrong, making it impossible to compare the object before and after. For example an exception  |
| Difference |  Difference between a pushed and pulled property.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum InputOutputComparisonType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Test_oM.dll

The enum is defined in C#. The class definition is available on github:

- [InputOutputComparisonType.cs](https://github.com/BHoM/BHoM/blob/develop/Test_oM/Results\Enums\InputOutputComparisonType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Test_oM/Results/InputOutputComparisonType.json}
```

The JSON Schema is available on github here:

- [InputOutputComparisonType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Test_oM/Results/InputOutputComparisonType.json)
