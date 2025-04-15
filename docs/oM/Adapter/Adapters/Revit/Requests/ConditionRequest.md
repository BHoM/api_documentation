---
title: ConditionRequest
---

# Adapters.Revit.Requests.ConditionRequest

IRequest that filters all elements that meet a given condition.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ConditionRequest in inheriting from the following base type(s) and implements the following interfaces:"

    -  Data.Requests.[IRequest](/om_documentation/oM/Framework/Data/Requests/IRequest)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Condition | [ICondition](/om_documentation/oM/Framework/Verification/Conditions/ICondition) | Condition for the elements to be met in order not to be filtered out. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/om_documentation/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| FilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given ConditionRequest request. | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [ConditionRequest.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Requests/ConditionRequest.cs)

All history and changes of the class can be found by inspection the history.
