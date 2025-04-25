---
title: RevitHostFragment
---

# <small>BH.oM.Revit.</small>**RevitHostFragment**

Fragment containing the information about the Revit element that hosts the Revit element correspondent to the BHoM object that carries this.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RevitHostFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| HostId | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | ElementId of the Revit element that hosts the Revit element correspondent to the BHoM object that carries this. | - |
| LinkDocument | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the link document, if the host Revit element is linked. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RevitHostFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject, BH.oM.Base.IImmutable
```

Assembly: Revit_oM.dll

The class is defined in C#. The class definition is available on github:

- [RevitHostFragment.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Misc\RevitHostFragment.cs)

All history and changes of the class can be found by inspection the history.
