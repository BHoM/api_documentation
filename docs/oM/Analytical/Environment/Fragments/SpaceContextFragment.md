---
title: SpaceContextFragment
---

# Environment.Fragments.SpaceContextFragment

Fragment containing space context properties (e.g. is external facing, colour, connected elements)

## Class structure

### Implemented interfaces and base types

???+ bhom "The SpaceContextFragment in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IFragment](/api/oM/Framework/Base/IFragment)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| IsExternal | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Defines wheather the space is externally facing | - |
| Colour | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| ConnectedElements | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | A collection of the elements which enclose the space | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [SpaceContextFragment.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/Fragments\SpaceContextFragment.cs)

All history and changes of the class can be found by inspection the history.
