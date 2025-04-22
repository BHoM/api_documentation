---
title: OpeningTypeGValueIteration
---

# Environment.SAP.OpeningTypeGValueIteration

Describe a single iteration of U and G Values for opening types. If both values are provided, then both values will be updated. This will not blend the iteration (i.e. it will not be one iteration with updated UValue, one iteration with updated GValue, and one iteration with both).

## Class structure

### Implemented interfaces and base types

???+ bhom "The OpeningTypeGValueIteration in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Environment.SAP.[IOpeningTypeIteration](/api_documentation/oM/Adapter/Environment/SAP/IOpeningTypeIteration)
    -  Environment.SAP.[IIteration](/api_documentation/oM/Adapter/Environment/SAP/IIteration)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| GValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | New GValue to use for the Opening Type. Must be a positive number between 0-1 as a ratio of how much of the total light is transmitted through the opening construction. If no value is provided, no changes to GValue will be made. | - |
| Include | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | A list of Opening Types to make changes to. If this is left blank, then all opening types will be updated within the SAP Report for the U and G Values provided. | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Provide the name of this iteration. The name should be unique across all iterations in your model, and should match any coordination with other models (over heating, daylighting, etc.) you may be running parametrics on. | - |
| Prefix | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | What value should be used to prefix the name of this iteration when combining with other iterations. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [OpeningTypeGValueIteration.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Iteration/OpeningTypeGValueIteration.cs)

All history and changes of the class can be found by inspection the history.
