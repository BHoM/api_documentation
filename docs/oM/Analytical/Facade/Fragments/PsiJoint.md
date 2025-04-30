---
title: PsiJoint
---

# <small>BH.oM.Facade.Fragments.</small>**PsiJoint**

A Psi value representing the linear joint thermal transmittance in W/m2 along the centerline of a frame edge.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PsiJoint is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PsiValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The Psi value for the frame edge. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PsiJoint : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Facade_oM.dll

The class is defined in C#. The class definition is available on github:

- [PsiJoint.cs](https://github.com/BHoM/BHoM/blob/develop/Facade_oM/Fragments\PsiJoint.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Facade_oM/Fragments/PsiJoint.json}
```

The JSON Schema is available on github here:

- [PsiJoint.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Facade_oM/Fragments/PsiJoint.json)
