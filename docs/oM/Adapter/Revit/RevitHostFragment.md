---
title: RevitHostFragment
---

# Revit.RevitHostFragment

Fragment containing the information about the Revit element that hosts the Revit element correspondent to the BHoM object that carries this.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RevitHostFragment in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IFragment](/api_documentation/oM/Framework/Base/IFragment)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Base.[IImmutable](/api_documentation/oM/Framework/Base/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| HostId | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | ElementId of the Revit element that hosts the Revit element correspondent to the BHoM object that carries this. | - |
| LinkDocument | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the link document, if the host Revit element is linked. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [RevitHostFragment.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Misc/RevitHostFragment.cs)

All history and changes of the class can be found by inspection the history.
