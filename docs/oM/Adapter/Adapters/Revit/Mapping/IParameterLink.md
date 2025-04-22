---
title: IParameterLink
---

# Adapters.Revit.Mapping.IParameterLink

An interface for classes defining the relationship between property names of an object (or names of RevitParameters attached to it) and sets of their correspondent Revit parameter names.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IParameterLink in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.Revit.Mapping.[ElementParameterLink](/api_documentation/oM/Adapter/Adapters/Revit/Mapping/ElementParameterLink)
    - Adapters.Revit.Mapping.[ElementTypeParameterLink](/api_documentation/oM/Adapter/Adapters/Revit/Mapping/ElementTypeParameterLink)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PropertyName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the property (or RevitParameter) to be linked with Revit parameters. | - |
| ParameterNames | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | A collecation of Revit parameter names to be linked with the type property. | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IParameterLink.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Mapping/IParameterLink.cs)

All history and changes of the class can be found by inspection the history.
