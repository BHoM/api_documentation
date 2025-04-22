---
title: ComparisonInclusion
---

# Base.ComparisonInclusion

Information about how an object's property should be included or not in a comparison (i.e. when computing an object's Hash or Diffing).A ComparisonInclusion object is returned by the extension method of the same name (which is invoked automatically when Hashing or Diffing).The ComparisonInclusion() method can be implemented in specific Toolkits/namespaces to customise the comparison (i.e. with Toolkit-specific information which would be otherwise unavailable to the base Hash/Diffing).See the wiki for examples of this.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ComparisonInclusion in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Include | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Whether the current property should be included or not in the comparison (i.e. Hash or Diffing). | - |
| DisplayName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | A custom DisplayName can be set so changes detected will be displayed with this name instead of the default Property Name. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [ComparisonInclusion.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/ComparisonInclusion.cs)

All history and changes of the class can be found by inspection the history.
