---
title: IsRigidConstraint
---

# <small>BH.oM.Adapters.GSA.</small>**IsRigidConstraint**

A fragment to identify whether the RigidLink is a Constraint or Link (i.e. element) in GSA.

## Class structure

### Implemented interfaces and base types

???+ bhom "The IsRigidConstraint is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| RigidConstraint | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | True means the RigidLink will be treated as a Rigid Constraint in GSA, false means it will be treated as a Link. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class IsRigidConstraint : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: GSA_oM.dll

The class is defined in C#. The class definition is available on github:

- [IsRigidConstraint.cs](https://github.com/BHoM/GSA_Toolkit/blob/develop/GSA_oM/Fragments\IsRigidConstraint.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/GSA_oM/IsRigidConstraint.json"
}
```

The JSON Schema is available on github here:

- [IsRigidConstraint.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/GSA_oM/IsRigidConstraint.json)
