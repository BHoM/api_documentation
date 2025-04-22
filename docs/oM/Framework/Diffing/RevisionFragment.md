---
title: RevisionFragment
---

# Diffing.RevisionFragment

Stores the current and previous Hash of the parent BHoMObject, as assigned after the inclusion in a Revision.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RevisionFragment in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IHashFragment](/api_documentation/oM/Framework/Base/IHashFragment)
    -  Base.[IFragment](/api_documentation/oM/Framework/Base/IFragment)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Base.[IImmutable](/api_documentation/oM/Framework/Base/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Hash | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Current object Hash. | - |
| PreviousHash | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Previous object Hash, typically the one it had in its previous Revision. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [RevisionFragment.cs](https://github.com/BHoM/BHoM/blob/develop/Diffing_oM/RevisionFragment.cs)

All history and changes of the class can be found by inspection the history.
