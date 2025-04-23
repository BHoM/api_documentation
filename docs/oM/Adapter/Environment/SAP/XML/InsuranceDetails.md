---
title: InsuranceDetails
---

# Environment.SAP.XML.InsuranceDetails



## Class structure

### Implemented interfaces and base types

???+ bhom "The InsuranceDetails in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Insurer | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The name of the insurance company that underwrites / issued the insurance policy. | - |
| PolicyNo | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The policy number of the insurance policy. | - |
| EffectiveDate | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The date that the insurance policy becomes effective. In the form yyyy-mm-dd | - |
| ExpiryDate | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The date that the insurance policy is supposed to expire. In the form yyyy-mm-dd | - |
| PILimit | [Money](/api/oM/Adapter/Environment/SAP/XML/Money) | The upper limit of the Professional Indemnity cover provided by the insurance policy. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [InsuranceDetails.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/XML/InsuranceDetails.cs)

All history and changes of the class can be found by inspection the history.
