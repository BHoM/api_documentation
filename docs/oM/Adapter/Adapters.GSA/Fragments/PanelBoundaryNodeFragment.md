---
title: PanelBoundaryNodeFragment
---

# <small>BH.oM.Adapters.GSA.</small>**PanelBoundaryNodeFragment**



## Class structure

### Implemented interfaces and base types

???+ bhom "The PanelBoundaryNodeFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ExternalNodes | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Node](/api/oM/Analytical/Structure/Elements/Node)&gt; |  | - |
| OpeningNodes | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Node](/api/oM/Analytical/Structure/Elements/Node)&gt;&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PanelBoundaryNodeFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: GSA_oM.dll

The class is defined in C#. The class definition is available on github:

- [PanelBoundaryNodeFragment.cs](https://github.com/BHoM/GSA_Toolkit/blob/develop/GSA_oM/Fragments\PanelBoundaryNodeFragment.cs)

All history and changes of the class can be found by inspection the history.
