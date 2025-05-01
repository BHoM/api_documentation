---
title: IIteration
---

# <small>BH.oM.Environment.SAP.</small>**IIteration**

Interface to group iteration objects together for producing parametric studies within the SAP context.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IIteration is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Environment.SAP.[IOpeningTypeIteration](/api/oM/Adapter/Environment/Iteration/IOpeningTypeIteration)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Environment.SAP.[OpeningIteration](/api/oM/Adapter/Environment/Iteration/OpeningIteration)
    - BH.oM.Environment.SAP.[OpeningTypeGValueIteration](/api/oM/Adapter/Environment/Iteration/OpeningTypeGValueIteration)
    - BH.oM.Environment.SAP.[OpeningTypeUValueIteration](/api/oM/Adapter/Environment/Iteration/OpeningTypeUValueIteration)
    - BH.oM.Environment.SAP.[OrientationIteration](/api/oM/Adapter/Environment/Iteration/OrientationIteration)
    - BH.oM.Environment.SAP.[RoofIteration](/api/oM/Adapter/Environment/Iteration/RoofIteration)
    - BH.oM.Environment.SAP.[ThermalBridgeIteration](/api/oM/Adapter/Environment/Iteration/ThermalBridgeIteration)
    - BH.oM.Environment.SAP.[WallIteration](/api/oM/Adapter/Environment/Iteration/WallIteration)
    - BH.oM.Environment.SAP.XML.[AirPermeabilityIteration](/api/oM/Adapter/Environment/Iteration/AirPermeabilityIteration)
    - BH.oM.Environment.SAP.XML.[FloorIteration](/api/oM/Adapter/Environment/Iteration/FloorIteration)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Prefix | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IIteration : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: SAP_oM.dll

The C# interface definition is available on github:

- [IIteration.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Iteration\IIteration.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/IIteration.json"
}
```

The JSON Schema is available on github here:

- [IIteration.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/IIteration.json)
