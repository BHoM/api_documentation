---
title: Graph&lt;T&gt;
---

# <small>BH.oM.Data.</small>**Graph&lt;T&gt;**



## Class structure

### Generic parameters

The Graph contains the following generic paramters:

#### T

Unconstrained generic type. Can be any type of object.

### Implemented interfaces and base types

???+ bhom "The Graph`1 is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Data.Collections.[IDataStructure](/api/oM/Framework/Data/Collections/IDataStructure)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Nodes | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[GraphNode](/api/oM/Framework/Data/Collections/GraphNode)&lt;[T](#t)&gt;&gt; | - | - |
| Links | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[GraphLink](/api/oM/Framework/Data/Collections/GraphLink)&lt;[T](#t)&gt;&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Graph`1 : BH.oM.Data.Collections.IDataStructure, BH.oM.Base.IObject
```

Assembly: Data_oM.dll

The class is defined in C#. The class definition is available on github:

- [Graph.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Collections\Graph.cs)

All history and changes of the class can be found by inspection the history.
