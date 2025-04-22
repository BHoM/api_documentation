---
title: IResultRequest
---

# Data.Requests.IResultRequest



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IResultRequest in inheriting from the following base type(s) and implements the following interfaces:"

    -  Data.Requests.[IRequest](/api_documentation/oM/Framework/Data/Requests/IRequest)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - Structure.Requests.[IStructuralResultRequest](/api_documentation/oM/Analytical/Structure/Requests/IStructuralResultRequest)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.ETABS.Requests.[PierAndSpandrelForceRequest](/api_documentation/oM/Adapter/Adapters/ETABS/Requests/PierAndSpandrelForceRequest)
    - Adapters.SAP2000.Requests.[SteelUtilisationRequest](/api_documentation/oM/Adapter/Adapters/SAP2000/Requests/SteelUtilisationRequest)
    - Structure.Requests.[BarResultRequest](/api_documentation/oM/Analytical/Structure/Requests/BarResultRequest)
    - Structure.Requests.[GlobalResultRequest](/api_documentation/oM/Analytical/Structure/Requests/GlobalResultRequest)
    - Structure.Requests.[MeshResultRequest](/api_documentation/oM/Analytical/Structure/Requests/MeshResultRequest)
    - Structure.Requests.[NodeResultRequest](/api_documentation/oM/Analytical/Structure/Requests/NodeResultRequest)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ObjectIds | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |
| Cases | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Discipline | [Nullable](https://learn.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netstandard-2.0)&lt;[Discipline](/api_documentation/oM/Adapter/Adapters/Revit/Enums/Discipline)&gt; | Gets discipline enforced by the Request. If the result is different than defaultDiscipline and neither of two is Undefined, null is returned (the result discipline is conflicting with defaultDiscipline). | - | Revit_Engine |
| IFilterDescription | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Returns a description of the filter represented by the given IRequest. | - | Revit_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IResultRequest.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Requests\IResultRequest.cs)

All history and changes of the class can be found by inspection the history.
