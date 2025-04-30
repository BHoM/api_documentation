---
title: SectionDatabase
---

# <small>BH.oM.Adapters.ETABS.</small>**SectionDatabase**

The ETABS defined section databases to read sections from if the name of the sections you push share a name with one avalible in the database

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| None |  -  |
| AISC14 |  -  |
| AISC14M |  -  |
| AISC15 |  -  |
| AISC15M |  -  |
| ArcelorMittal_British |  -  |
| ArcelorMittal_BritishHISTAR |  -  |
| ArcelorMittal_Europe |  -  |
| ArcelorMittal_EuropeHISTAR |  -  |
| ArcelorMittal_Japan |  -  |
| ArcelorMittal_Russia |  -  |
| ArcelorMittal_US_ASTM_A913 |  -  |
| ArcelorMittal_US_ASTM_A913M |  -  |
| ArcelorMittal_US_ASTM_A992 |  -  |
| ArcelorMittal_US_ASTM_A992M |  -  |
| Australia_NewZealand |  -  |
| BSShapes2006 |  -  |
| ChineseGB08 |  -  |
| CISC9 |  -  |
| CISC10 |  -  |
| CoreBraceBRB_2016 |  -  |
| Euro |  -  |
| Indian |  -  |
| JIS_G_3192_2014 |  -  |
| Nordic |  -  |
| Russian |  -  |
| SJIJoists |  -  |
| StarSeismicBRB |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum SectionDatabase : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: ETABS_oM.dll

The enum is defined in C#. The class definition is available on github:

- [SectionDatabase.cs](https://github.com/BHoM/ETABS_Toolkit/blob/develop/ETABS_oM/Enums\SectionDatabase.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/ETABS_oM/SectionDatabase.json}
```

The JSON Schema is available on github here:

- [SectionDatabase.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/ETABS_oM/SectionDatabase.json)
