---
title: Overview
---

# <small>BH.oM.dKoP.</small>**Overview**



## Class structure

### Implemented interfaces and base types

???+ bhom "The Overview is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKoPObject](/api/oM/Physical/dKoP/IdKoPObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PartName | [PartName](/api/oM/Physical/dKoP/AdministrativeInformation/Enums/PartNames) | - | - |
| PathReference | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| PartDataTemplateVersion | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| DFMACategory | [DFMACategory](/api/oM/Physical/dKoP/AdministrativeInformation/Enums/DFMACategory) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class Overview : BH.oM.dKoP.IdKoPObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The C# class definition is available on github:

- [Overview.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/AdministrativeInformation\Overview.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/Overview.json"
}
```

The JSON Schema is available on github here:

- [Overview.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/Overview.json)
