---
title: IMesh&lt;TNode,TFace&gt;
---

# Analytical.Elements.IMesh&lt;TNode,TFace&gt;



## Interface structure

### Generic parameters

The IMesh contains the following generic paramters:

#### TNode

Constrained by the following arguments:

- Analytical.Elements.[INode](/api_documentation/oM/Analytical/Analytical/Elements/INode)

#### TFace

Constrained by the following arguments:

- Analytical.Elements.[IFace](/api_documentation/oM/Analytical/Analytical/Elements/IFace)

### Implemented interfaces and base types

???+ bhom "The IMesh`2 in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Analytical.[IAnalytical](/api_documentation/oM/Analytical/Analytical/IAnalytical)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Structure.Elements.[FEMesh](/api_documentation/oM/Analytical/Structure/Elements/FEMesh)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Nodes | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[TNode](#tnode)&gt; | - | - |
| Faces | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[TFace](#tface)&gt; | - | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IMesh.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Elements\IMesh.cs)

All history and changes of the class can be found by inspection the history.
