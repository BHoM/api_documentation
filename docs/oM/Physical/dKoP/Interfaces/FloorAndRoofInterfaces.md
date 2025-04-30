---
title: FloorAndRoofInterfaces
---

# <small>BH.oM.dKoP.</small>**FloorAndRoofInterfaces**



## Class structure

### Implemented interfaces and base types

???+ bhom "The FloorAndRoofInterfaces is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKoPObject](/api/oM/Physical/dKoP/IdKoPObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SideA | [FloorAndRoofSideInterface](/api/oM/Physical/dKoP/Interfaces/FloorAndRoofSideInterface) | - | - |
| SideB | [FloorAndRoofSideInterface](/api/oM/Physical/dKoP/Interfaces/FloorAndRoofSideInterface) | - | - |
| SideC | [FloorAndRoofSideInterface](/api/oM/Physical/dKoP/Interfaces/FloorAndRoofSideInterface) | - | - |
| SideD | [FloorAndRoofSideInterface](/api/oM/Physical/dKoP/Interfaces/FloorAndRoofSideInterface) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class FloorAndRoofInterfaces : BH.oM.dKoP.IdKoPObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [FloorAndRoofInterfaces.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Interfaces\FloorAndRoofInterfaces.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/FloorAndRoofInterfaces.json}
```

The JSON Schema is available on github here:

- [FloorAndRoofInterfaces.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/FloorAndRoofInterfaces.json)
