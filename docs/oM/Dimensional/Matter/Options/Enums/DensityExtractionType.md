---
title: DensityExtractionType
---

# <small>BH.oM.Matter.Options.</small>**DensityExtractionType**

Specifies how the density should be extracted from a list of IDensityProvider.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| AllMatching |  Require all densities across all IDensityProviders extracted to be equal within tolerance. If within tolerance, the average is computed.  |
| Average |  Compute and return the average value of all densities found, independent of difference between them.  |
| Maximum |  Return the maximum value of all densities found.  |
| Minimum |  Return the minimum value of all densities found.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum DensityExtractionType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Matter_oM.dll

The enum is defined in C#. The class definition is available on github:

- [DensityExtractionType.cs](https://github.com/BHoM/BHoM/blob/develop/Matter_oM/Options\Enums\DensityExtractionType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Matter_oM/Options/DensityExtractionType.json"
}
```

The JSON Schema is available on github here:

- [DensityExtractionType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Matter_oM/Options/DensityExtractionType.json)
