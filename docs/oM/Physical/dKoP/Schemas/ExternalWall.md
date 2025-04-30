---
title: ExternalWall
---

# <small>BH.oM.dKoP.</small>**ExternalWall**



## Class structure

### Implemented interfaces and base types

???+ bhom "The ExternalWall is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKoPObject](/api/oM/Physical/dKoP/IdKoPObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| AdministrativeInformation | [AdministrativeInformation](/api/oM/Physical/dKoP/AdministrativeInformation/AdministrativeInformation) | - | - |
| QualityAndCertification | [QualityAndCertification](/api/oM/Physical/dKoP/QualityAndCertification/QualityAndCertification) | - | - |
| HealthAndSafety | [HealthAndSafety](/api/oM/Physical/dKoP/HealthAndSafety/HealthAndSafety) | - | - |
| Geometry | [WallGeometry](/api/oM/Physical/dKoP/Geometry/WallGeometry) | - | - |
| Performance | [ExternalWallPerformance](/api/oM/Physical/dKoP/Perfomance/ExternalWallPerformance) | - | - |
| Assembly | [Assembly](/api/oM/Physical/dKoP/Assembly/Assembly) | - | - |
| Interfaces | [WallInterfaces](/api/oM/Physical/dKoP/Interfaces/WallInterfaces) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ExternalWall : BH.oM.dKoP.IdKoPObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [ExternalWall.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Schemas\ExternalWall.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/ExternalWall.json}
```

The JSON Schema is available on github here:

- [ExternalWall.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/ExternalWall.json)
