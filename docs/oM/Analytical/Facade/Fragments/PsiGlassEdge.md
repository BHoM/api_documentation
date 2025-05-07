---
title: PsiGlassEdge
---

# <small>BH.oM.Facade.Fragments.</small>**PsiGlassEdge**

A Psi value representing the linear thermal bridging value in W/m2 at a glass to frame edge interface.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PsiGlassEdge is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PsiValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The Psi value for the interface. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PsiGlassEdge : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Facade_oM.dll

The C# class definition is available on github:

- [PsiGlassEdge.cs](https://github.com/BHoM/BHoM/blob/develop/Facade_oM/Fragments\PsiGlassEdge.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Facade_oM/Fragments/PsiGlassEdge.json"
}
```

The JSON Schema is available on github here:

- [PsiGlassEdge.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Facade_oM/Fragments/PsiGlassEdge.json)
