---
title: ColourFragment
---

# <small>BH.oM.Graphics.</small>**ColourFragment**

Indicates a colour associable with a BHoMObject.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ColourFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Colour | [Color](https://learn.microsoft.com/en-us/dotnet/api/System.Drawing.Color?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ColourFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Graphics_oM.dll

The class is defined in C#. The class definition is available on github:

- [ColourFragment.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Colours\ColourFragment.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Graphics_oM/ColourFragment.json}
```

The JSON Schema is available on github here:

- [ColourFragment.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Graphics_oM/ColourFragment.json)
