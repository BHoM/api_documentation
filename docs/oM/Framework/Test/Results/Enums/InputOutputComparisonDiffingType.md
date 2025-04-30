---
title: InputOutputComparisonDiffingType
---

# <small>BH.oM.Test.Results.</small>**InputOutputComparisonDiffingType**



## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| DataOnlyAvailableInReference |  -  |
| Deterioration |  -  |
| Difference |  -  |
| Equal |  -  |
| Improvement |  -  |
| InputDataChanged |  -  |
| IntroducedDifference |  -  |
| IntroducedException |  -  |
| NoAvailableReferenceSet |  -  |
| RemovedDifference |  -  |
| RemovedException |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum InputOutputComparisonDiffingType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Test_oM.dll

The enum is defined in C#. The class definition is available on github:

- [InputOutputComparisonDiffingType.cs](https://github.com/BHoM/BHoM/blob/develop/Test_oM/Results\Enums\InputOutputComparisonDiffingType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Test_oM/Results/InputOutputComparisonDiffingType.json}
```

The JSON Schema is available on github here:

- [InputOutputComparisonDiffingType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Test_oM/Results/InputOutputComparisonDiffingType.json)
