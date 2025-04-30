---
title: Encodings
---

# <small>BH.oM.Adapters.File.</small>**Encodings**



## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| FromFile |  -  |
| ASCII |  -  |
| Unicode |  -  |
| UTF7 |  -  |
| UTF8 |  -  |
| UTF32 |  -  |
| BigEndianUnicode |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum Encodings : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: File_oM.dll

The enum is defined in C#. The class definition is available on github:

- [Encodings.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/enums\Encodings.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/File_oM/Encodings.json}
```

The JSON Schema is available on github here:

- [Encodings.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/File_oM/Encodings.json)
