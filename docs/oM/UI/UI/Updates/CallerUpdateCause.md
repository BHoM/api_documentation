---
title: CallerUpdateCause
---

# <small>BH.oM.UI.</small>**CallerUpdateCause**

Possible cause that can trigger the update of a UI component.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Unknown |  -  |
| ItemSelected |  -  |
| ReadFromSave |  -  |
| InputSelection |  -  |
| OutputSelection |  -  |
| UpgradedVersion |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum CallerUpdateCause : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: UI_oM.dll

The C# enum definition is available on github:

- [CallerUpdateCause.cs](https://github.com/BHoM/BHoM_UI/blob/develop/UI_oM/Updates\CallerUpdateCause.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/UI_oM/CallerUpdateCause.json"
}
```

The JSON Schema is available on github here:

- [CallerUpdateCause.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/UI_oM/CallerUpdateCause.json)
