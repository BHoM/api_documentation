---
title: PitchedRoof
---

# <small>BH.oM.dKoP.</small>**PitchedRoof**



## Class structure

### Implemented interfaces and base types

???+ bhom "The PitchedRoof is inheriting from the following base type(s) and implements the following interfaces:"

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
| Geometry | [PitchedRoofGeometry](/api/oM/Physical/dKoP/Geometry/PitchedRoofGeometry) | - | - |
| Performance | [RoofPerformance](/api/oM/Physical/dKoP/Perfomance/RoofPerformance) | - | - |
| Assembly | [Assembly](/api/oM/Physical/dKoP/Assembly/Assembly) | - | - |
| Interfaces | [FloorAndRoofInterfaces](/api/oM/Physical/dKoP/Interfaces/FloorAndRoofInterfaces) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PitchedRoof : BH.oM.dKoP.IdKoPObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [PitchedRoof.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Schemas\PitchedRoof.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/PitchedRoof.json"
}
```

The JSON Schema is available on github here:

- [PitchedRoof.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/PitchedRoof.json)
