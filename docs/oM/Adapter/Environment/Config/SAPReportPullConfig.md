---
title: SAPReportPullConfig
---

# <small>BH.oM.Environment.SAP.</small>**SAPReportPullConfig**

Configurations specific for an Adapter Action (Push, Pull, etc).
Consider that your tookit might have a more specific implementation available. Try to look for [your toolkit name]ActionConfig.

## Class structure

### Implemented interfaces and base types

???+ bhom "The SAPReportPullConfig is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[ActionConfig](/api/oM/Framework/Adapter/Settings-Config/ActionConfig)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Environment.SAP.[ISAPPullConfig](/api/oM/Adapter/Environment/Config/ISAPPullConfig)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SAPReportFile | [FileSettings](/api/oM/Framework/Adapter/FileSettings) | Set the location of the SAP XML Report file. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| WrapNonBHoMObjects | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, the Push action wraps any non-BHoM type into a BH.oM.Adapter.ObjectWrapper, allowing them to make use of the full Adapter workflow. | - |
| AllowHashForComparing | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true and if no specific EqualityComparer is found for the type, Diffing hashes are computed and used to compare the objects. | - |
| DiffingConfig | [DiffingConfig](/api/oM/Framework/Diffing/DiffingConfig) | Configurations for the Diffing hashing. Requires `AllowHashForComparing` to be set to true. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class SAPReportPullConfig : BH.oM.Adapter.ActionConfig, BH.oM.Base.IObject, BH.oM.Environment.SAP.ISAPPullConfig
```

Assembly: SAP_oM.dll

The class is defined in C#. The class definition is available on github:

- [SAPReportPullConfig.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Config\SAPReportPullConfig.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/SAPReportPullConfig.json}
```

The JSON Schema is available on github here:

- [SAPReportPullConfig.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/SAPReportPullConfig.json)
