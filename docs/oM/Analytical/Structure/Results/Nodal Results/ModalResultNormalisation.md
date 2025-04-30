---
title: ModalResultNormalisation
---

# <small>BH.oM.Structure.Results.</small>**ModalResultNormalisation**



## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| EigenvectorComponent |  Results normalised so that the absolute value of the maximum component of the mode shape for the mode and case is equal to 1.  |
| EigenvectorTotal |  Results normalised so that the square root sum of squares for the displacement of the mode and case is equal to 1.  |
| MassComponent |  Results normalised so that the absolute value of the maximum component of the mass for the mode and case is equal to 1.  |
| MassTotal |  Results normalised so that the square root sum of squares for mass of the mode and case is equal to 1.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum ModalResultNormalisation : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Structure_oM.dll

The enum is defined in C#. The class definition is available on github:

- [ModalResultNormalisation.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Results\Nodal Results\ModalResultNormalisation.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/Results/ModalResultNormalisation.json}
```

The JSON Schema is available on github here:

- [ModalResultNormalisation.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/Results/ModalResultNormalisation.json)
