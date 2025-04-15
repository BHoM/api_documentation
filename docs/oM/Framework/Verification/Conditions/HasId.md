---
title: HasId
---

# Verification.Conditions.HasId

Condition that requires an object to own an AdapterId fragment with a given Id to be considered a pass.

## Class structure

### Implemented interfaces and base types

???+ bhom "The HasId in inheriting from the following base type(s) and implements the following interfaces:"

    -  Verification.Conditions.[ICondition](/documentation/oM/Framework/Verification/Conditions/ICondition)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Ids | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | Collection of ids, one of which needs to be found among object's AdapterId.Id fragment properties for it to pass. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| INestedConditions | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[ICondition](/documentation/oM/Framework/Verification/Conditions/ICondition)&gt; | Extracts the conditions nested inside a given condition, e.g. conditions nested inside logical conditions. | - | Verification_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [HasId.cs](https://github.com/BHoM/BHoM/blob/develop/Verification_oM/Conditions\HasId.cs)

All history and changes of the class can be found by inspection the history.
