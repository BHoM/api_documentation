---
title: SourcesDependencyFragment
---

# Analytical.Fragments.SourcesDependencyFragment

Dependency fragment used to define one or more Relations that originate at the specified sources and use the IBHoMObject owning this fragment as the target.

## Class structure

### Implemented interfaces and base types

???+ bhom "The SourcesDependencyFragment in inheriting from the following base type(s) and implements the following interfaces:"

    -  Analytical.Fragments.[IDependencyFragment](/api_documentation/oM/Analytical/Analytical/Fragments/IDependencyFragment)
    -  Base.[IFragment](/api_documentation/oM/Framework/Base/IFragment)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Sources | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0)&gt; | Collection of Guids of entities that are sources for Relations where the IBHoMObject owning this fragment is the target. | - |
| Curves | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ICurve](/api_documentation/oM/Dimensional/Geometry/ICurve)&gt; | Collection of ICurves used to represent the Relations. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [SourcesDependencyFragment.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Fragments\SourcesDependencyFragment.cs)

All history and changes of the class can be found by inspection the history.
