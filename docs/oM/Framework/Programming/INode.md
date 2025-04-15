---
title: INode
---

# Programming.INode

Interface common to all syntax nodes

## Interface structure

### Implemented interfaces and base types

???+ bhom "The INode in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Programming.[BlockNode](/documentation/oM/Framework/Programming/BlockNode)
    - Programming.[ClusterNode](/documentation/oM/Framework/Programming/ClusterNode)
    - Programming.[ConstructorNode](/documentation/oM/Framework/Programming/ConstructorNode)
    - Programming.[CustomObjectNode](/documentation/oM/Framework/Programming/CustomObjectNode)
    - Programming.[ExplodeNode](/documentation/oM/Framework/Programming/ExplodeNode)
    - Programming.[GetPropertyNode](/documentation/oM/Framework/Programming/GetPropertyNode)
    - Programming.[InitialiserNode](/documentation/oM/Framework/Programming/InitialiserNode)
    - Programming.[LibraryNode](/documentation/oM/Framework/Programming/LibraryNode)
    - Programming.[LoopNode](/documentation/oM/Framework/Programming/LoopNode)
    - Programming.[MethodNode](/documentation/oM/Framework/Programming/MethodNode)
    - Programming.[ParamNode](/documentation/oM/Framework/Programming/ParamNode)
    - Programming.[SetPropertyNode](/documentation/oM/Framework/Programming/SetPropertyNode)
    - Programming.[TypeNode](/documentation/oM/Framework/Programming/TypeNode)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Inputs | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[ReceiverParam](/documentation/oM/Framework/Programming/ReceiverParam)&gt; | - | - |
| Outputs | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[DataParam](/documentation/oM/Framework/Programming/DataParam)&gt; | - | - |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| IsInline | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| IsDeclaration | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IDataTypePerParam | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0), [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=netstandard-2.0)&gt; | Collect the data type for each parameter in the input syntax node. | - | Programming_Engine |
| IReturnType | TypeSyntax | Get the C# type syntax corresponding to the first output of a node. | - | CSharp_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [INode.cs](https://github.com/BHoM/BHoM/blob/develop/Programming_oM/Nodes/INode.cs)

All history and changes of the class can be found by inspection the history.
