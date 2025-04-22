---
title: IFace
---

# Analytical.Elements.IFace



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IFace in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Analytical.[IAnalytical](/api_documentation/oM/Analytical/Analytical/IAnalytical)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Structure.Elements.[FEMeshFace](/api_documentation/oM/Analytical/Structure/Elements/FEMeshFace)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| NodeListIndices | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Geometry | [Face](/api_documentation/oM/Dimensional/Geometry/Face) | Gets the geometry of a analytical IFace as a geometrical Mesh's Face. A geometrical mesh face only supports 3 and 4 nodes faces, while a FEMeshFace does not have this limitation. For FEMeshFaces with more than 4 nodes or less than 3 this operation is therefore not possible. Method required for automatic display in UI packages. | - | Analytical_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IFace.cs](https://github.com/BHoM/BHoM/blob/develop/Analytical_oM/Elements\IFace.cs)

All history and changes of the class can be found by inspection the history.
