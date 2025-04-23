---
title: IView
---

# Adapters.Revit.Elements.IView

A base interface for BHoM wrapper classes that can wrap Revit views.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IView in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.Revit.Elements.[ViewPlan](/api/oM/Adapter/Adapters/Revit/Elements/ViewPlan)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| InstanceProperties | [InstanceProperties](/api/oM/Adapter/Adapters/Revit/Properties/InstanceProperties) | An entity storing the information about Revit view type. | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IView.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Elements/IView.cs)

All history and changes of the class can be found by inspection the history.
