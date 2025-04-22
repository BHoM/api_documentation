---
title: IsRigidConstraint
---

# Adapters.GSA.IsRigidConstraint

A fragment to identify whether the RigidLink is a Constraint or Link (i.e. element) in GSA.

## Class structure

### Implemented interfaces and base types

???+ bhom "The IsRigidConstraint in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IFragment](/api_documentation/oM/Framework/Base/IFragment)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| RigidConstraint | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | True means the RigidLink will be treated as a Rigid Constraint in GSA, false means it will be treated as a Link. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [IsRigidConstraint.cs](https://github.com/BHoM/GSA_Toolkit/blob/develop/GSA_oM/Fragments/IsRigidConstraint.cs)

All history and changes of the class can be found by inspection the history.
