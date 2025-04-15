---
title: FemModel
---

# Karamba3D.FemModel

Container of the BHoMObjects converted from the Karamba model.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FemModel in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IContainer](/documentation/oM/Framework/Base/IContainer)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Nodes | [IList](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netstandard-2.0)&lt;[Node](/documentation/oM/Analytical/Structure/Elements/Node)&gt; | Nodes converted from the Karamba model. | - |
| Bars | [IList](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netstandard-2.0)&lt;[Bar](/documentation/oM/Analytical/Structure/Elements/Bar)&gt; | Bars converted from the Karamba model. | - |
| Loads | [IList](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netstandard-2.0)&lt;[ILoad](/documentation/oM/Analytical/Structure/Loads/ILoad)&gt; | Loads converted from the Karamba model. | - |
| LoadCases | [IList](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netstandard-2.0)&lt;[Loadcase](/documentation/oM/Analytical/Structure/Loads/Loadcase)&gt; | Load cases converted from the Karamba model. | - |
| CrossSections | [IList](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netstandard-2.0)&lt;[ISectionProperty](/documentation/oM/Analytical/Structure/SectionProperties/ISectionProperty)&gt; | Cross sections converted from the Karamba model. | - |
| Materials | [IList](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netstandard-2.0)&lt;[IMaterialFragment](/documentation/oM/Analytical/Structure/MaterialFragments/IMaterialFragment)&gt; | Materials converted from the Karamba model. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Unpack | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[IObject](/documentation/oM/Framework/Base/IObject)&gt; | Unpacks the contents of the input IContainer. The contents are flattened into a list of objects.The flattening supports properties of IContainer that are Lists, List of Lists, Dictionaries (the values are flattened) and Dictionaries with a Value that is a list (the list is flattened).Any other nested datastructure has its elements returned as-is. | - | BHoM_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [FemModel.cs](https://github.com/BHoM/Karamba3D_Toolkit/blob/develop/Karamba3D_oM/FemModel.cs)

All history and changes of the class can be found by inspection the history.
