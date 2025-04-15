---
title: SpecificationResult
---

# Verification.Results.SpecificationResult

Object representing result of verification of a Specification.

## Class structure

### Implemented interfaces and base types

???+ bhom "The SpecificationResult in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IImmutable](/documentation/oM/Framework/Base/IImmutable)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Specification | [Specification](/documentation/oM/Framework/Verification/Specifications/Specification) | Specification that was verified. | - |
| ExtractedObjects | [ReadOnlyCollection](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | Objects collected during the extraction stage and checked against the requirements. | - |
| RequirementResults | [ReadOnlyCollection](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1?view=netstandard-2.0)&lt;[RequirementResult](/documentation/oM/Framework/Verification/Results/RequirementResult)&gt; | Collection of verification results of each filtered object against each Requirement contained within the Specification. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [SpecificationResult.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Results\SpecificationResult.cs)

All history and changes of the class can be found by inspection the history.
