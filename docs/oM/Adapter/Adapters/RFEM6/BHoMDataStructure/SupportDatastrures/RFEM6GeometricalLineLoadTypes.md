---
title: RFEM6GeometricalLineLoadTypes
---

# <small>BH.oM.Adapters.RFEM6.BHoMDataStructure.SupportDatastrures.</small>**RFEM6GeometricalLineLoadTypes**



## Class structure

### Implemented interfaces and base types

???+ bhom "The RFEM6GeometricalLineLoadTypes is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| geometrialLineLoadType | [GeometricalLineLoadTypesEnum](/api/oM/Adapter/Adapters/RFEM6/Fragments/Enums/GeometricalLineLoadTypesEnum) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RFEM6GeometricalLineLoadTypes : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: RFEM6_oM.dll

The class is defined in C#. The class definition is available on github:

- [RFEM6GeometricalLineLoadTypes.cs](https://github.com/BHoM/RFEM6_Toolkit/blob/develop/RFEM6_oM/BHoMDataStructure\SupportDatastrures\RFEM6GeometricalLineLoadTypes.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/RFEM6_oM/BHoMDataStructure/SupportDatastrures/RFEM6GeometricalLineLoadTypes.json"
}
```

The JSON Schema is available on github here:

- [RFEM6GeometricalLineLoadTypes.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/RFEM6_oM/BHoMDataStructure/SupportDatastrures/RFEM6GeometricalLineLoadTypes.json)
