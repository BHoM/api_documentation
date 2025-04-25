---
title: IContainer
---

# <small>BH.oM.Base.</small>**IContainer**

Identifies Container objects that can contain other interrelated objects in multiple properties. The container can be unpacked to get all of its objects as a flat list.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IContainer is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Karamba3D.[FemModel](/api/oM/Adapter/Karamba3D/FemModel)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Unpack | [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netstandard-2.0)&lt;[IObject](/api/oM/Framework/Base/Interface/IObject)&gt; | Unpacks the contents of the input IContainer. The contents are flattened into a list of objects.The flattening supports properties of IContainer that are Lists, List of Lists, Dictionaries (the values are flattened) and Dictionaries with a Value that is a list (the list is flattened).Any other nested datastructure has its elements returned as-is. | - | BHoM_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IContainer : BH.oM.Base.IObject
```

Assembly: BHoM.dll

The interface is defined in C#. The class definition is available on github:

- [IContainer.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Interface\IContainer.cs)

All history and changes of the class can be found by inspection the history.
