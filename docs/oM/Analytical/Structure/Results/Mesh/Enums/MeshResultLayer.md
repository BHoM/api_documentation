---
title: MeshResultLayer
---

# <small>BH.oM.Structure.Results.</small>**MeshResultLayer**

Specifies which layer the results are extracted from or if it is a maxima/minima of the layers.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Lower |  Lower surface/extreme fibre of the panel/mesh element.  |
| Middle |  Middle layer of the panel/mesh element.  |
| Upper |  Upper surface/extreme fibre of the panel/mesh element.  |
| Minimum |  The minimum value of all layers in the panel/mesh element.  |
| Maximum |  The maximum value of all layers in the panel/mesh element.  |
| AbsoluteMaximum |  The absolute maximum value of all layers in the panel/mesh element.  |
| Arbitrary |  An arbitrary position within the thickness of the element.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum MeshResultLayer : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Structure_oM.dll

The enum is defined in C#. The class definition is available on github:

- [MeshResultLayer.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Results\Mesh\Enums\MeshResultLayer.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/Results/MeshResultLayer.json"
}
```

The JSON Schema is available on github here:

- [MeshResultLayer.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/Results/MeshResultLayer.json)
