---
title: DataTypeCode
---

# <small>BH.oM.Environment.SAP.</small>**DataTypeCode**

Code which indicates the type of SAP data.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| NewDwellingAsDesigned |  -  |
| NewDwellingAsBuilt |  -  |
| NewExtensionToExistingDwelling |  -  |
| NewDwellingCreatedByChangeOfUse |  -  |
| ExistingDwelling |  -  |
| Other |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum DataTypeCode : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: SAP_oM.dll

The enum is defined in C#. The class definition is available on github:

- [DataTypeCode.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Enums\DataTypeCode.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/DataTypeCode.json"
}
```

The JSON Schema is available on github here:

- [DataTypeCode.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/DataTypeCode.json)
