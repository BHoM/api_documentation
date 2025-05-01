---
title: TypeOfGlazing
---

# <small>BH.oM.Environment.SAP.</small>**TypeOfGlazing**

Code which indicates the type of glazing; if U-value is from BFRC or manufacturer declaration, give as one of: single, double, triple.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| NotAppicable |  -  |
| Single |  -  |
| Double |  -  |
| DoubleLowEHard02 |  -  |
| DoubleLowEHard015 |  -  |
| DoubleLowESoft01 |  -  |
| DoubleLowESoft005 |  -  |
| Triple |  -  |
| TripleLowEHard02 |  -  |
| TripleLowEHard015 |  -  |
| TripleLowESoft01 |  -  |
| TripleLowESoft005 |  -  |
| SecondaryGlazing |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum TypeOfGlazing : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: SAP_oM.dll

The enum is defined in C#. The class definition is available on github:

- [TypeOfGlazing.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Enums\TypeOfGlazing.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/TypeOfGlazing.json"
}
```

The JSON Schema is available on github here:

- [TypeOfGlazing.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/TypeOfGlazing.json)
