---
title: IProjectionFragment
---

# <small>BH.oM.Analytical.Fragments.</small>**IProjectionFragment**

Interface common to all ProjectionFragments.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IProjectionFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Analytical.Fragments.[ProjectionFragment](/api/oM/Analytical/Analytical/Fragments/ProjectionFragment)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IProjectionFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Analytical_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IProjectionFragment.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Fragments\IProjectionFragment.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Analytical_oM/Fragments/IProjectionFragment.json"
}
```

The JSON Schema is available on github here:

- [IProjectionFragment.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Analytical_oM/Fragments/IProjectionFragment.json)
