---
title: IOpeningTypeIteration
---

# <small>BH.oM.Environment.SAP.</small>**IOpeningTypeIteration**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IOpeningTypeIteration is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Environment.SAP.[IIteration](/api/oM/Adapter/Environment/Iteration/IIteration)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Environment.SAP.[OpeningTypeGValueIteration](/api/oM/Adapter/Environment/Iteration/OpeningTypeGValueIteration)
    - BH.oM.Environment.SAP.[OpeningTypeUValueIteration](/api/oM/Adapter/Environment/Iteration/OpeningTypeUValueIteration)


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IOpeningTypeIteration : BH.oM.Environment.SAP.IIteration, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: SAP_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IOpeningTypeIteration.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Iteration\IOpeningTypeIteration.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/IOpeningTypeIteration.json}
```

The JSON Schema is available on github here:

- [IOpeningTypeIteration.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/IOpeningTypeIteration.json)
