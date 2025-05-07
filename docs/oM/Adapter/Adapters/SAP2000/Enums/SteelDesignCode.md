---
title: SteelDesignCode
---

# <small>BH.oM.Adapters.SAP2000.</small>**SteelDesignCode**

Defines the Design Code used for result extraction.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Undefined |  -  |
| AASHTO_LRFD_2007 |  -  |
| AISC_ASD89 |  -  |
| AISC_360_05 |  -  |
| AISC_360_10 |  -  |
| AISC_360_16 |  -  |
| IBC2006 |  -  |
| AISC_LRFD93 |  -  |
| API_RP2A_LRFD_97 |  -  |
| API_RP2A_WSD2000 |  -  |
| API_RP2A_WSD2014 |  -  |
| AS_4100_1998 |  -  |
| ASCE_10_97 |  -  |
| BS5950_2000 |  -  |
| Chinese_2010 |  -  |
| CSA_S16_14 |  -  |
| CSA_S16_09 |  -  |
| EUROCODE_3_2005 |  -  |
| Indian_IS_800_2007 |  -  |
| Italian_NTC_2008 |  -  |
| Italian_UNI_10011 |  -  |
| KBC_2009 |  -  |
| Norsok_N_004_2013 |  -  |
| NZS_3404_1997 |  -  |
| SP_16_13330_2011 |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum SteelDesignCode : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: SAP2000_oM.dll

The C# enum definition is available on github:

- [SteelDesignCode.cs](https://github.com/BHoM/SAP2000_Toolkit/blob/develop/SAP2000_oM/Enums\SteelDesignCode.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP2000_oM/SteelDesignCode.json"
}
```

The JSON Schema is available on github here:

- [SteelDesignCode.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP2000_oM/SteelDesignCode.json)
