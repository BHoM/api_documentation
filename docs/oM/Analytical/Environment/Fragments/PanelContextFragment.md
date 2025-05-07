---
title: PanelContextFragment
---

# <small>BH.oM.Environment.Fragments.</small>**PanelContextFragment**

Fragment containing thermal boundary context, colour, and surface direction properties

## Class structure

### Implemented interfaces and base types

???+ bhom "The PanelContextFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| IsAir | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Defines whether the panel is an air panel (e.g. air wall or hole) | - |
| IsGround | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Defines whether the panel is a ground panel | - |
| Colour | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Reversed | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Defines whether the panel surface direction is reversed | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PanelContextFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Environment_oM.dll

The C# class definition is available on github:

- [PanelContextFragment.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/Fragments\PanelContextFragment.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Environment_oM/Fragments/PanelContextFragment.json"
}
```

The JSON Schema is available on github here:

- [PanelContextFragment.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Environment_oM/Fragments/PanelContextFragment.json)
