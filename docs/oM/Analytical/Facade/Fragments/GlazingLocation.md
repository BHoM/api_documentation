---
title: GlazingLocation
---

# <small>BH.oM.Facade.Fragments.</small>**GlazingLocation**

Fragment containing the offset distance from the section property origin to the edge of glazing.

## Class structure

### Implemented interfaces and base types

???+ bhom "The GlazingLocation is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| GlazingOffsetDistance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Offset distance from the section property origin to the edge of glazing | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class GlazingLocation : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Facade_oM.dll

The class is defined in C#. The class definition is available on github:

- [GlazingLocation.cs](https://github.com/BHoM/BHoM/blob/develop/Facade_oM/Fragments\GlazingLocation.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Facade_oM/Fragments/GlazingLocation.json}
```

The JSON Schema is available on github here:

- [GlazingLocation.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Facade_oM/Fragments/GlazingLocation.json)
