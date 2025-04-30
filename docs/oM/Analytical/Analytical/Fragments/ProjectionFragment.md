---
title: ProjectionFragment
---

# <small>BH.oM.Analytical.Fragments.</small>**ProjectionFragment**

Fragment used to define entity projection metadata.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ProjectionFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Analytical.Fragments.[IProjectionFragment](/api/oM/Analytical/Analytical/Fragments/IProjectionFragment)
    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| GroupName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ProjectionFragment : BH.oM.Analytical.Fragments.IProjectionFragment, BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Analytical_oM.dll

The class is defined in C#. The class definition is available on github:

- [ProjectionFragment.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Fragments\ProjectionFragment.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Analytical_oM/Fragments/ProjectionFragment.json}
```

The JSON Schema is available on github here:

- [ProjectionFragment.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Analytical_oM/Fragments/ProjectionFragment.json)
