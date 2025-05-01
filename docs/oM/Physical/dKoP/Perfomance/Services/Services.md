---
title: Services
---

# <small>BH.oM.dKoP.</small>**Services**



## Class structure

### Implemented interfaces and base types

???+ bhom "The Services is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKoPObject](/api/oM/Physical/dKoP/IdKoPObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Electrical | [Electrical](/api/oM/Physical/dKoP/Perfomance/Services/Electrical) | - | - |
| Data | [Data](/api/oM/Physical/dKoP/Perfomance/Services/Data) | - | - |
| Heating | [Heating](/api/oM/Physical/dKoP/Perfomance/Services/Heating) | - | - |
| Water | [Water](/api/oM/Physical/dKoP/Perfomance/Services/Water) | - | - |
| Drainage | [Drainage](/api/oM/Physical/dKoP/Perfomance/Services/Drainage) | - | - |
| Gas | [Gas](/api/oM/Physical/dKoP/Perfomance/Services/Gas) | - | - |
| Ventilation | [Ventilation](/api/oM/Physical/dKoP/Perfomance/Services/Ventilation) | - | - |
| ServicesIntegrationConfirmation | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Services : BH.oM.dKoP.IdKoPObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [Services.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Perfomance\Services\Services.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/Services.json"
}
```

The JSON Schema is available on github here:

- [Services.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/Services.json)
