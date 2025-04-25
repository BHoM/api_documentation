---
title: FemModel
---

# <small>BH.oM.Karamba3D.</small>**FemModel**

Container of the BHoMObjects converted from the Karamba model.

## Class structure

### Implemented interfaces and base types

???+ bhom "The FemModel is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IContainer](/api/oM/Framework/Base/Interface/IContainer)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Nodes | [IList](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netstandard-2.0)&lt;[Node](/api/oM/Analytical/Structure/Elements/Node)&gt; | Nodes converted from the Karamba model. | - |
| Bars | [IList](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netstandard-2.0)&lt;[Bar](/api/oM/Analytical/Structure/Elements/Bar)&gt; | Bars converted from the Karamba model. | - |
| Loads | [IList](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netstandard-2.0)&lt;[ILoad](/api/oM/Analytical/Structure/Loads/ILoad)&gt; | Loads converted from the Karamba model. | - |
| LoadCases | [IList](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netstandard-2.0)&lt;[Loadcase](/api/oM/Analytical/Structure/Loads/Loadcase)&gt; | Load cases converted from the Karamba model. | - |
| CrossSections | [IList](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netstandard-2.0)&lt;[ISectionProperty](/api/oM/Analytical/Structure/SectionProperties/ISectionProperty)&gt; | Cross sections converted from the Karamba model. | - |
| Materials | [IList](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netstandard-2.0)&lt;[IMaterialFragment](/api/oM/Analytical/Structure/MaterialFragments/IMaterialFragment)&gt; | Materials converted from the Karamba model. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Unpack | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[IObject](/api/oM/Framework/Base/Interface/IObject)&gt; | Unpacks the contents of the input IContainer. The contents are flattened into a list of objects.The flattening supports properties of IContainer that are Lists, List of Lists, Dictionaries (the values are flattened) and Dictionaries with a Value that is a list (the list is flattened).Any other nested datastructure has its elements returned as-is. | - | BHoM_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class FemModel : BH.oM.Base.IContainer, BH.oM.Base.IObject
```

Assembly: Karamba3D_oM.dll

The class is defined in C#. The class definition is available on github:

- [FemModel.cs](https://github.com/BHoM/Karamba3D_Toolkit/blob/develop/Karamba3D_oM/FemModel.cs)

All history and changes of the class can be found by inspection the history.
