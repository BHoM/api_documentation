---
title: SAP2000PushConfig
---

# <small>BH.oM.Adapters.SAP2000.</small>**SAP2000PushConfig**

This Config can be specified in the `ActionConfig` input of any Adapter Action (e.g. Push).

## Class structure

### Implemented interfaces and base types

???+ bhom "The SAP2000PushConfig is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[ActionConfig](/api/oM/Framework/Adapter/Settings-Config/ActionConfig)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ReplaceLoads | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Sets whether the loads being pushed should overwrite existing loads on the same object within the same loadcase | - |
| UpdateOnlyBarPropAssigns | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, only Bar property assignments will be updated, ignoring changes to property definitions, geometry or other Bar assigns such as offsets, releases, etc. Non-existing objects will still be pushed. | - |


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
public class SAP2000PushConfig : BH.oM.Adapter.ActionConfig, BH.oM.Base.IObject
```

Assembly: SAP2000_oM.dll

The class is defined in C#. The class definition is available on github:

- [SAP2000PushConfig.cs](https://github.com/BHoM/SAP2000_Toolkit/blob/develop/SAP2000_oM/Config\SAP2000PushConfig.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP2000_oM/SAP2000PushConfig.json"
}
```

The JSON Schema is available on github here:

- [SAP2000PushConfig.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP2000_oM/SAP2000PushConfig.json)
