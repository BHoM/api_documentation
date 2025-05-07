---
title: MeshResultSmoothingType
---

# <small>BH.oM.Structure.Results.</small>**MeshResultSmoothingType**

Defines the smoothing used for the Meshresults, i.e. if and how any result averaging should be done per nodes/face.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| None |  -  |
| ByPanel |  -  |
| BySelection |  -  |
| Global |  -  |
| ByFiniteElementCentres |  -  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum MeshResultSmoothingType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Structure_oM.dll

The C# enum definition is available on github:

- [MeshResultSmoothingType.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Results\Mesh\Enums\MeshResultSmoothingType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/Results/MeshResultSmoothingType.json"
}
```

The JSON Schema is available on github here:

- [MeshResultSmoothingType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/Results/MeshResultSmoothingType.json)
