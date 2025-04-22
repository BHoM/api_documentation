---
title: IRequirement
---

# Verification.Requirements.IRequirement

Top interface for all kinds of Requirements.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IRequirement in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Verification.Requirements.[Requirement](/api_documentation/oM/Framework/Verification/Requirements/Requirement)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Clause | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Human readable identifier to reference the Requirement. | - |
| Source | [Source](/api_documentation/oM/Framework/Data/Library/Source) | Source material for this Requirement. E.g. Codes, best practices, guidelines, etc. | - |
| Comment | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Any additional notes. | - |
| FailureMessage | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | General, human-readable message explaining what does the failure mean to the user. | - |
| Severity | [FailureSeverity](/api_documentation/oM/Framework/Verification/FailureSeverity) | Severity of Requirement failure, originating from the concept that not all conditions are necessarily errors. | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IRequirement.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Requirements/Interfaces/IRequirement.cs)

All history and changes of the class can be found by inspection the history.
