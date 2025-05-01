---
title: Mirror
---

# <small>BH.oM.Environment.SAP.</small>**Mirror**

Code indication a line to mirror across.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| None |  -  |
| NorthToSouth |  -  |
| NorthEastToSouthWest |  -  |
| EastToWest |  -  |
| NorthWestToSouthEast |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum Mirror : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: SAP_oM.dll

The C# enum definition is available on github:

- [Mirror.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Enums\Mirror.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/Mirror.json"
}
```

The JSON Schema is available on github here:

- [Mirror.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/Mirror.json)
