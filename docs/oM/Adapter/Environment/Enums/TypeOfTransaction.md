---
title: TypeOfTransaction
---

# <small>BH.oM.Environment.SAP.</small>**TypeOfTransaction**

.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| MarketedSale |  -  |
| NonMarketedSale |  -  |
| Rental_SocialThisIsForBackwardsCompatibilityOnlyAndShouldNotBeUsed |  -  |
| Rental_PrivateThisIsForBackwardsCompatibilityOnlyAndShouldNotBeUsed |  -  |
| NoneOfTheAbove |  -  |
| NewDwelling |  -  |
| NotRecordedThisIsForBackwardsCompatibilityOnlyAndShouldNotBeUsed |  -  |
| Rental |  -  |
| AssessmentForGreenDeal |  -  |
| FollowingGreenDeal |  -  |
| FitApplication |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum TypeOfTransaction : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: SAP_oM.dll

The C# enum definition is available on github:

- [TypeOfTransaction.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Enums\TypeOfTransaction.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/TypeOfTransaction.json"
}
```

The JSON Schema is available on github here:

- [TypeOfTransaction.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/TypeOfTransaction.json)
