---
title: Scope
---

# <small>BH.oM.LifeCycleAssessment.</small>**Scope**

An optional scope tag for any object or collection of objects being evaluated using the Evaluate EPD compute method within the LifeCycleAssessment_Toolkit.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Scope is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ScopeType | [ScopeType](/api/oM/Analytical/LifeCycleAssessment/Enums/ScopeType) | ScopeType used to describe the objects being evaluated. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Scope : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: LifeCycleAssessment_oM.dll

The C# class definition is available on github:

- [Scope.cs](https://github.com/BHoM/BHoM/blob/develop/LifeCycleAssessment_oM/Fragments\Scope.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/LifeCycleAssessment_oM/Scope.json"
}
```

The JSON Schema is available on github here:

- [Scope.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/LifeCycleAssessment_oM/Scope.json)
