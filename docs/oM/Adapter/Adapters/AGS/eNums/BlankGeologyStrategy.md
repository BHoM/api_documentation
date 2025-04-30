---
title: BlankGeologyStrategy
---

# <small>BH.oM.Adapters.AGS.</small>**BlankGeologyStrategy**

Different approaches for the AGS_Toolkit to handle blank geology.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Replace |  Replace any entries of blank geology with a specificed string.  |
| Description |  Replace any entries of blank geology using the description attribute (GEOL_DESC) with words in CAPS.  |
| Legend |  Replace any entries of blank geology using the legend (GEOL_LEG).  |
| Lexicon |  Replace any entries of blank geology using the lexicon code (GEOL_BGS).  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum BlankGeologyStrategy : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: AGS_oM.dll

The enum is defined in C#. The class definition is available on github:

- [BlankGeologyStrategy.cs](https://github.com/BHoM/AGS_Toolkit/blob/develop/AGS_oM/eNums\BlankGeologyStrategy.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/AGS_oM/BlankGeologyStrategy.json}
```

The JSON Schema is available on github here:

- [BlankGeologyStrategy.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/AGS_oM/BlankGeologyStrategy.json)
