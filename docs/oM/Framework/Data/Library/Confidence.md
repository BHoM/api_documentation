---
title: Confidence
---

# <small>BH.oM.Data.Library.</small>**Confidence**

Level of confidence for the serialized DataSet, outlining both the reliability of the source and the fidelity of the dataset to that source.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  Default value - assume no fidelity and no source.  |
| None |  The Dataset may not have a reliable source and/or fidelity to the source has not been tested  |
| Low |  The Dataset comes from an unreliable source and matches the source based on initial checks.  |
| Medium |  The Dataset comes from a reliable source and matches the source based on initial checks.  |
| High |  The Dataset comes from a reliable source and matches the source based on extensive review and testing.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum Confidence : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Data_oM.dll

The enum is defined in C#. The class definition is available on github:

- [Confidence.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Library\Confidence.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Data_oM/Library/Confidence.json}
```

The JSON Schema is available on github here:

- [Confidence.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Data_oM/Library/Confidence.json)
