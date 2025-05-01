---
title: DOFType
---

# <small>BH.oM.Structure.Constraints.</small>**DOFType**

Enumerator outlining the fixity of a particular degree of freedom. Controls if the DOF should be free, fixed or stiffness based.

## Enum values

| Name            | Description                                                    |
|-----------------|----------------------------------------------------------------|
| Free |  Free to translate or rotate, depending on the DOF.  |
| Fixed |  Fixed in translation or rotation, depending on the DOF.  |
| FixedNegative |  Zero stiffness in the positive direction.  |
| FixedPositive |  Zero stiffness in the negative direction.  |
| Spring |  Linear spring constant.  |
| SpringNegative |  Nonlinear, zero stiffness in the positive direction.  |
| SpringPositive |  Nonlinear, zero stiffness in the negative direction.  |
| SpringRelative |  Spring stiffness between 0-1 relates to the element to which the DOF applies (e.g. bar end stiffness).  |
| SpringRelativeNegative |  Nonlinear, Spring stiffness between 0-1 relates to the element to which the DOF applies (e.g. bar end stiffness), zero stiffness in the positive direction.  |
| SpringRelativePositive |  Nonlinear, Spring stiffness between 0-1 relates to the element to which the DOF applies (e.g. bar end stiffness), zero stiffness in the negative direction.  |
| NonLinear |  Nonlinear spring model.  |
| Friction |  Friction model (relative to the load applied).  |
| Damped |  Damped velocities/accelerations.  |
| Gap |  Gap model.  |


## Code and Schema

### C# implementation

``` C# title="C#"
public enum DOFType : System.Enum, System.ValueType, System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
```

Assembly: Structure_oM.dll

The C# enum definition is available on github:

- [DOFType.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/Constraints\Enums\DOFType.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/Constraints/DOFType.json"
}
```

The JSON Schema is available on github here:

- [DOFType.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/Constraints/DOFType.json)
