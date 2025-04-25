---
title: SteelUtilisationRequest
---

# <small>BH.oM.Adapters.SAP2000.Requests.</small>**SteelUtilisationRequest**



## Class structure

### Implemented interfaces and base types

???+ bhom "The SteelUtilisationRequest is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Structure.Requests.[IStructuralResultRequest](/api/oM/Analytical/Structure/Requests/IStructuralResultRequest)
    -  BH.oM.Data.Requests.[IResultRequest](/api/oM/Framework/Data/Requests/IResultRequest)
    -  BH.oM.Data.Requests.[IRequest](/api/oM/Framework/Data/Requests/IRequest)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Code | [SteelDesignCode](/api/oM/Adapter/Adapters/SAP2000/Enums/SteelDesignCode) | Defines which code to get steel utilization design results for. | - |
| Cases | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | Defines which cases and/or combinations that results should be extracted for. Can generally be set to either Loadcase or Loadcombination objects, or identifiers matching the software. If nothing is provided, results for all cases will be assumed. | - |
| Modes | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | Defines for which modes results should be extracted. Only applicable for some casetypes. If nothing is provided, results for all modes will be assumed. | - |
| ObjectIds | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | Defines which bars that results should be extracted for. Can generally be set to either pulled bar objects, or identifiers matching the software. If nothing is provided, results for all bars will be assumed. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class SteelUtilisationRequest : BH.oM.Structure.Requests.IStructuralResultRequest,
BH.oM.Data.Requests.IResultRequest,
BH.oM.Data.Requests.IRequest,
BH.oM.Base.IObject
```

Assembly: SAP2000_oM.dll

The class is defined in C#. The class definition is available on github:

- [SteelUtilisationRequest.cs](https://github.com/BHoM/SAP2000_Toolkit/blob/develop/SAP2000_oM/Requests\SteelUtilisationRequest.cs)

All history and changes of the class can be found by inspection the history.
