---
title: IDependencyFragment
---

# <small>BH.oM.Analytical.Fragments.</small>**IDependencyFragment**

Interface common to all DependencyFragments.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IDependencyFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Analytical.Fragments.[SourcesDependencyFragment](/api/oM/Analytical/Analytical/Fragments/SourcesDependencyFragment)
    - BH.oM.Analytical.Fragments.[TargetsDependencyFragment](/api/oM/Analytical/Analytical/Fragments/TargetsDependencyFragment)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IDependencyFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Analytical_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IDependencyFragment.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Fragments\IDependencyFragment.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Analytical_oM/Fragments/IDependencyFragment.json}
```

The JSON Schema is available on github here:

- [IDependencyFragment.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Analytical_oM/Fragments/IDependencyFragment.json)
