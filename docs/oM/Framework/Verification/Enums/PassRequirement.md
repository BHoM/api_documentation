---
title: PassRequirement
---

# <small>BH.oM.Verification.</small>**PassRequirement**

To consider an object as `passed`, should it satisfy All Specification or just one is enough?

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| AllMustPass |  -  |
| AtLeastOnePasses |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum PassRequirement : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Verification_oM.dll

The enum is defined in C#. The class definition is available on github:

- [PassRequirement.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Enums\PassRequirement.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Verification_oM/PassRequirement.json"
}
```

The JSON Schema is available on github here:

- [PassRequirement.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Verification_oM/PassRequirement.json)
