---
title: IInstance
---

# <small>BH.oM.Adapters.Revit.Elements.</small>**IInstance**

A base interface for BHoM wrapper classes that can wrap Revit elements.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IInstance is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.Revit.Elements.[DraftingInstance](/api/oM/Adapter/Adapters/Revit/Elements/DraftingInstance)
    - BH.oM.Adapters.Revit.Elements.[ModelInstance](/api/oM/Adapter/Adapters/Revit/Elements/ModelInstance)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Properties | [InstanceProperties](/api/oM/Adapter/Adapters/Revit/Properties/InstanceProperties) | Information about family type of the instance. | - |
| Location | [IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry) | Location of the instance in space. | - |
| Orientation | [Basis](/api/oM/Dimensional/Geometry/Vector/Basis) | Orientation of the instance in 2 or 3 dimensional space (depending on dimensionality of the instance). Applicable only to point-based instances. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IInstance : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Revit_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IInstance.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Elements\IInstance.cs)

All history and changes of the class can be found by inspection the history.
