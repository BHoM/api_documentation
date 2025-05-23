---
title: EmbodiedCarbon
---

# <small>BH.oM.dKoP.</small>**EmbodiedCarbon**



## Class structure

### Implemented interfaces and base types

???+ bhom "The EmbodiedCarbon is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKoPObject](/api/oM/Physical/dKoP/IdKoPObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| A1toA3 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |
| A4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |
| A5 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |
| B1toB5 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |
| C1toC4 | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |
| D | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | [ClimateChange](/api/oM/Dimensional/Quantities/Attributes/ClimateChange) [kg CO2 eq] |


## Code and Schema

### C# implementation

``` C# title="C#"
public class EmbodiedCarbon : BH.oM.dKoP.IdKoPObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The C# class definition is available on github:

- [EmbodiedCarbon.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Performance\Sustainability\EmbodiedCarbon.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/EmbodiedCarbon.json"
}
```

The JSON Schema is available on github here:

- [EmbodiedCarbon.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/EmbodiedCarbon.json)
