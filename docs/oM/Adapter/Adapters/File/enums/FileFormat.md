---
title: FileFormat
---

# <small>BH.oM.Adapters.File.</small>**FileFormat**



## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| JSON |  -  |
| BSON |  -  |
| XML |  -  |
| byteArray |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum FileFormat : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: File_oM.dll

The C# enum definition is available on github:

- [FileFormat.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/enums\FileFormat.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/File_oM/FileFormat.json"
}
```

The JSON Schema is available on github here:

- [FileFormat.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/File_oM/FileFormat.json)
