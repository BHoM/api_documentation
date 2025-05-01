---
title: UValueGlassEdge
---

# <small>BH.oM.Facade.Fragments.</small>**UValueGlassEdge**

A U-Value representing the effective U-Value of the edge region of an opening.

## Class structure

### Implemented interfaces and base types

???+ bhom "The UValueGlassEdge is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| UValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The U-Value of the edge region of this opening. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class UValueGlassEdge : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Facade_oM.dll

The class is defined in C#. The class definition is available on github:

- [UValueGlassEdge.cs](https://github.com/BHoM/BHoM/blob/develop/Facade_oM/Fragments\UValueGlassEdge.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Facade_oM/Fragments/UValueGlassEdge.json"
}
```

The JSON Schema is available on github here:

- [UValueGlassEdge.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Facade_oM/Fragments/UValueGlassEdge.json)
