---
title: AdministrativeInformation
---

# <small>BH.oM.dKoP.</small>**AdministrativeInformation**



## Class structure

### Implemented interfaces and base types

???+ bhom "The AdministrativeInformation is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKoPObject](/api/oM/Physical/dKoP/IdKoPObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Overview | [Overview](/api/oM/Physical/dKoP/AdministrativeInformation/Overview) | - | - |
| CrossReference | [CrossReference](/api/oM/Physical/dKoP/AdministrativeInformation/CrossReference) | - | - |
| ProjectIdentification | [ProjectIdentification](/api/oM/Physical/dKoP/AdministrativeInformation/ProjectIdentification) | - | - |
| ProjectTeam | [ProjectTeam](/api/oM/Physical/dKoP/AdministrativeInformation/ProjectTeam) | - | - |
| PartIdentification | [PartIdentification](/api/oM/Physical/dKoP/AdministrativeInformation/PartIdentification) | - | - |
| ProductDetails | [ProductDetails](/api/oM/Physical/dKoP/AdministrativeInformation/ProductDetails) | - | - |
| ManufacturerDetails | [ManufacturerDetails](/api/oM/Physical/dKoP/AdministrativeInformation/ManufacturerDetails) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class AdministrativeInformation : BH.oM.dKoP.IdKoPObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [AdministrativeInformation.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/AdministrativeInformation\AdministrativeInformation.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/AdministrativeInformation.json}
```

The JSON Schema is available on github here:

- [AdministrativeInformation.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/AdministrativeInformation.json)
