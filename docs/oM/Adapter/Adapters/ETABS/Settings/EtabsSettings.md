---
title: EtabsSettings
---

# <small>BH.oM.Adapters.ETABS.</small>**EtabsSettings**



## Class structure

### Implemented interfaces and base types

???+ bhom "The EtabsSettings is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ReplaceLoads | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Sets whether the loads being pushed should overwrite existing loads on the same object within the same loadcase | - |
| DatabaseSettings | [DatabaseSettings](/api/oM/Adapter/Adapters/ETABS/Settings/DataBaseSettings) |  | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class EtabsSettings : BH.oM.Base.IObject
```

Assembly: ETABS_oM.dll

The class is defined in C#. The class definition is available on github:

- [EtabsSettings.cs](https://github.com/BHoM/ETABS_Toolkit/blob/develop/ETABS_oM/Settings\EtabsSettings.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/ETABS_oM/EtabsSettings.json}
```

The JSON Schema is available on github here:

- [EtabsSettings.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/ETABS_oM/EtabsSettings.json)
