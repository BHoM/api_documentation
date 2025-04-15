---
title: IRFEMLineLoad
---

# Adapters.RFEM6.IntermediateDatastructure.Loading.Interfaces.IRFEMLineLoad



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IRFEMLineLoad in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.RFEM6.IntermediateDatastructure.Geometry.[RFEMFreeLineLoad](/om_documentation/oM/Adapter/Adapters/RFEM6/IntermediateDatastructure/Geometry/RFEMFreeLineLoad)
    - Adapters.RFEM6.IntermediateDatastructure.Geometry.[RFEMNonFreeLineLoad](/om_documentation/oM/Adapter/Adapters/RFEM6/IntermediateDatastructure/Geometry/RFEMNonFreeLineLoad)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| geometrialLineLoad | [GeometricalLineLoad](/om_documentation/oM/Analytical/Structure/Loads/GeometricalLineLoad) | - | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IRFEMLineLoad.cs](https://github.com/BHoM/RFEM6_Toolkit/blob/develop/RFEM6_oM/IntermediateDatastructure/Loading/Interfaces/IRFEMLineLoad.cs)

All history and changes of the class can be found by inspection the history.
