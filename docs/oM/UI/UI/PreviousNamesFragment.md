---
title: PreviousNamesFragment
---

# <small>BH.oM.UI.</small>**PreviousNamesFragment**



## Class structure

### Implemented interfaces and base types

???+ bhom "The PreviousNamesFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| OldNames | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PreviousNamesFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: UI_oM.dll

The class is defined in C#. The class definition is available on github:

- [PreviousNamesFragment.cs](https://github.com/BHoM/BHoM_UI/blob/develop/UI_oM/PreviousNamesFragment.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/UI_oM/PreviousNamesFragment.json}
```

The JSON Schema is available on github here:

- [PreviousNamesFragment.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/UI_oM/PreviousNamesFragment.json)
