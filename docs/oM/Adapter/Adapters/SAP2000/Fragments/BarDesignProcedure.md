---
title: BarDesignProcedure
---

# <small>BH.oM.Adapters.SAP2000.Elements.</small>**BarDesignProcedure**



## Class structure

### Implemented interfaces and base types

???+ bhom "The BarDesignProcedure is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| DesignProcedure | [BarDesignProcedureType](/api/oM/Adapter/Adapters/SAP2000/Enums/BarDesignProcedureType) | Design procedure based on material type. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class BarDesignProcedure : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: SAP2000_oM.dll

The C# class definition is available on github:

- [BarDesignProcedure.cs](https://github.com/BHoM/SAP2000_Toolkit/blob/develop/SAP2000_oM/Fragments\BarDesignProcedure.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP2000_oM/Elements/BarDesignProcedure.json"
}
```

The JSON Schema is available on github here:

- [BarDesignProcedure.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP2000_oM/Elements/BarDesignProcedure.json)
