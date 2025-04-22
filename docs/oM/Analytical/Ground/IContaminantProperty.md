---
title: IContaminantProperty
---

# Ground.IContaminantProperty

Base interface for contaminant properties.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IContaminantProperty in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Ground.[AnalysisProperties](/api_documentation/oM/Analytical/Ground/AnalysisProperties)
    - Ground.[ContaminantReference](/api_documentation/oM/Analytical/Ground/ContaminantReference)
    - Ground.[DetectionProperties](/api_documentation/oM/Analytical/Ground/DetectionProperties)
    - Ground.[ResultProperties](/api_documentation/oM/Analytical/Ground/ResultProperties)
    - Ground.[TestProperties](/api_documentation/oM/Analytical/Ground/TestProperties)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a IContaminantProperty is valid and outputs relevant error message. | - | Ground_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IContaminantProperty.cs](https://github.com/BHoM/BHoM/blob/develop/Ground_oM/ContaminantProperties/IContaminantProperty.cs)

All history and changes of the class can be found by inspection the history.
