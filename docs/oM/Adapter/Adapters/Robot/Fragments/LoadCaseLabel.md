---
title: LoadCaseLabel
---

# <small>BH.oM.Adapters.Robot.</small>**LoadCaseLabel**



## Class structure

### Implemented interfaces and base types

???+ bhom "The LoadCaseLabel is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Label | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class LoadCaseLabel : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Robot_oM.dll

The class is defined in C#. The class definition is available on github:

- [LoadCaseLabel.cs](https://github.com/BHoM/Robot_Toolkit/blob/develop/Robot_oM/Fragments\LoadCaseLabel.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Robot_oM/LoadCaseLabel.json"
}
```

The JSON Schema is available on github here:

- [LoadCaseLabel.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Robot_oM/LoadCaseLabel.json)
