---
title: IRFEMLineLoad
---

# <small>BH.oM.Adapters.RFEM6.IntermediateDatastructure.Loading.Interfaces.</small>**IRFEMLineLoad**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IRFEMLineLoad is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.RFEM6.IntermediateDatastructure.Geometry.[RFEMFreeLineLoad](/api/oM/Adapter/Adapters/RFEM6/IntermediateDatastructure/Loading/RFEMFreeLineLoad)
    - BH.oM.Adapters.RFEM6.IntermediateDatastructure.Geometry.[RFEMNonFreeLineLoad](/api/oM/Adapter/Adapters/RFEM6/IntermediateDatastructure/Loading/RFEMNonFreeLineLoad)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| geometrialLineLoad | [GeometricalLineLoad](/api/oM/Analytical/Structure/Loads/GeometricalLineLoad) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IRFEMLineLoad : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: RFEM6_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IRFEMLineLoad.cs](https://github.com/BHoM/RFEM6_Toolkit/blob/develop/RFEM6_oM/IntermediateDatastructure\Loading\Interfaces\IRFEMLineLoad.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/RFEM6_oM/IntermediateDatastructure/Loading/Interfaces/IRFEMLineLoad.json}
```

The JSON Schema is available on github here:

- [IRFEMLineLoad.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/RFEM6_oM/IntermediateDatastructure/Loading/Interfaces/IRFEMLineLoad.json)
