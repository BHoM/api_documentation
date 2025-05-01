---
title: SortOrder
---

# <small>BH.oM.Adapters.File.</small>**SortOrder**



## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Default |  -  |
| ByName |  -  |
| BySize |  -  |
| ByCreationTime |  -  |
| ByLastModifiedTime |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum SortOrder : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: File_oM.dll

The enum is defined in C#. The class definition is available on github:

- [SortOrder.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/enums\SortOrder.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/File_oM/SortOrder.json"
}
```

The JSON Schema is available on github here:

- [SortOrder.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/File_oM/SortOrder.json)
