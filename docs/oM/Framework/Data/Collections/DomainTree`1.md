---
title: DomainTree&lt;T&gt;
---

# Data.Collections.DomainTree&lt;T&gt;

A data tree which is traversed through DomainBoxes. Each node's DomainBox is assumed to be enclosed by its parent's DomainBox and to enclose its own data. All the tree's data is stored in its leaves.

## Class structure

### Generic parameters

The DomainTree contains the following generic paramters:

#### T

Unconstrained generic type. Can be any type of object.

### Implemented interfaces and base types

???+ bhom "The DomainTree`1 in inheriting from the following base type(s) and implements the following interfaces:"

    -  Data.Collections.[INode](/api_documentation/oM/Framework/Data/Collections/INode%601)&lt;[T](/api_documentation/oM/Framework/Data/Collections/INode%601#t)&gt;
    -  Data.Collections.[IDataStructure](/api_documentation/oM/Framework/Data/Collections/IDataStructure)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Children | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[DomainTree](/api_documentation/oM/Framework/Data/Collections/DomainTree%601)&lt;[T](#t)&gt;&gt; | The child nodes of this node. All child nodes DomainBoxes are assumed to be enclosed by this nodes DomainBox. An empty list indicates this node as a leaf node | - |
| Values | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[T](#t)&gt; | The data values stored on this node. The DomainTree assumes that only nodes with an empty list of children have values. | - |
| DomainBox | [DomainBox](/api_documentation/oM/Framework/Data/Collections/DomainBox) | This nodes DomainBox, enclosing either all the child nodes' DomainBoxes or this node's Values. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [DomainTree.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Collections\DomainTree.cs)

All history and changes of the class can be found by inspection the history.
