---
title: StoreyCode
---

# <small>BH.oM.Environment.SAP.</small>**StoreyCode**

Code which identifies a particular storey in a building part.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| LowerGround |  -  |
| Ground |  -  |
| First |  -  |
| Second |  -  |
| Third |  -  |
| Fourth |  -  |
| Fifth |  -  |
| Sixth |  -  |
| RoofRooms |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum StoreyCode : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: SAP_oM.dll

The enum is defined in C#. The class definition is available on github:

- [StoreyCode.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Enums\StoreyCode.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/StoreyCode.json"
}
```

The JSON Schema is available on github here:

- [StoreyCode.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/StoreyCode.json)
