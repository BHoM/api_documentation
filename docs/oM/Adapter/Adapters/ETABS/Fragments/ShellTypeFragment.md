---
title: ShellTypeFragment
---

# <small>BH.oM.Adapters.ETABS.Fragments.</small>**ShellTypeFragment**



## Class structure

### Implemented interfaces and base types

???+ bhom "The ShellTypeFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ShellType | [ShellType](/api/oM/Adapter/Adapters/ETABS/Enums/ShellType) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ShellTypeFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: ETABS_oM.dll

The class is defined in C#. The class definition is available on github:

- [ShellTypeFragment.cs](https://github.com/BHoM/ETABS_Toolkit/blob/develop/ETABS_oM/Fragments\ShellTypeFragment.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/ETABS_oM/Fragments/ShellTypeFragment.json}
```

The JSON Schema is available on github here:

- [ShellTypeFragment.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/ETABS_oM/Fragments/ShellTypeFragment.json)
