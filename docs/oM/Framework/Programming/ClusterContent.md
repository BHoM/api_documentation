---
title: ClusterContent
---

# Programming.ClusterContent

Content of a Cluster syntax node.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ClusterContent in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/om_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| InternalNodes | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[INode](/om_documentation/oM/Framework/Programming/INode)&gt; | - | - |
| NodeGroups | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[NodeGroup](/om_documentation/oM/Framework/Programming/NodeGroup)&gt; | - | - |
| Inputs | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[DataParam](/om_documentation/oM/Framework/Programming/DataParam)&gt; | - | - |
| Outputs | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ReceiverParam](/om_documentation/oM/Framework/Programming/ReceiverParam)&gt; | - | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/om_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Body | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;StatementSyntax&gt; | Get the C# statement syntax corresponding to the content of a cluster. | - | CSharp_Engine |
| DataTypePerParam | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0), [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=netstandard-2.0)&gt; | Collect the data type for each parameter of each syntax node inside the cluster. | - | Programming_Engine |
| ReturnType | TypeSyntax | Get the C# type syntax corresponding to the first output of a cluster content. | - | CSharp_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [ClusterContent.cs](https://github.com/BHoM/BHoM/blob/develop/Programming_oM/Others/ClusterContent.cs)

All history and changes of the class can be found by inspection the history.
