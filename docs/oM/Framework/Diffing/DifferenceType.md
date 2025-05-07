---
title: DifferenceType
---

# <small>BH.oM.Diffing.</small>**DifferenceType**

Specifies various kinds of Differences. It can be useful to mark and filter specific implementations of IPropertyDifferences.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Modified |  Indicates that the difference is a modification.  |
| Removed |  Indicates that the difference is a removal.  |
| Added |  Indicates that the difference is an addition.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum DifferenceType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Diffing_oM.dll

The C# enum definition is available on github:

- [DifferenceType.cs](https://github.com/BHoM/BHoM/blob/develop/Diffing_oM/DifferenceType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Diffing_oM/DifferenceType.json"
}
```

The JSON Schema is available on github here:

- [DifferenceType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Diffing_oM/DifferenceType.json)
