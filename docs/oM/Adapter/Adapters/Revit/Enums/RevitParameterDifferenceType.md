---
title: RevitParameterDifferenceType
---

# <small>BH.oM.Adapters.Revit.Enums.</small>**RevitParameterDifferenceType**

Specifies various kinds of Differences found between a pair of RevitParameters.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Modified |  Indicates that a RevitParameter which was already existing on the owner object was modified in its Value.  |
| AddedAssigned |  Indicates that a RevitParameter was added with a non-null Value on the owner object.  |
| AddedUnassigned |  Indicates that a RevitParameter was added with no value assigned (null Value) on the owner object.  |
| RemovedAssigned |  Indicates that a RevitParameter that had a non-null Value was removed from the owner object.  |
| RemovedUnassigned |  Indicates that a RevitParameter which had no value assigned was removed from the owner object.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum RevitParameterDifferenceType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Revit_oM.dll

The enum is defined in C#. The class definition is available on github:

- [RevitParameterDifferenceType.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Enums\RevitParameterDifferenceType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Revit_oM/Enums/RevitParameterDifferenceType.json}
```

The JSON Schema is available on github here:

- [RevitParameterDifferenceType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Revit_oM/Enums/RevitParameterDifferenceType.json)
