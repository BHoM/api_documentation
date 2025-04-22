---
title: RFEMNodalSupport
---

# Adapters.RFEM6.RFEMNodalSupport



## Class structure

### Implemented interfaces and base types

???+ bhom "The RFEMNodalSupport in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Base.[IFragment](/api_documentation/oM/Framework/Base/IFragment)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Constraint | [Constraint6DOF](/api_documentation/oM/Analytical/Structure/Constraints/Constraint6DOF) | - | - |
| nodes | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Node](/api_documentation/oM/Analytical/Structure/Elements/Node)&gt; | - | - |
| nodesIDs | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0)&gt; | - | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [RFEMNodalSupport.cs](https://github.com/BHoM/RFEM6_Toolkit/blob/develop/RFEM6_oM/IntermediateDatastructure/Support/RFEMNodalSupport.cs)

All history and changes of the class can be found by inspection the history.
