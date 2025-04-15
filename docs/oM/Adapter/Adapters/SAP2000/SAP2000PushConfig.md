---
title: SAP2000PushConfig
---

# Adapters.SAP2000.SAP2000PushConfig

This Config can be specified in the `ActionConfig` input of any Adapter Action (e.g. Push).

## Class structure

### Implemented interfaces and base types

???+ bhom "The SAP2000PushConfig in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapter.[ActionConfig](/documentation/oM/Framework/Adapter/ActionConfig)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


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
| DiffingConfig | [DiffingConfig](/documentation/oM/Framework/Diffing/DiffingConfig) | Configurations for the Diffing hashing. Requires `AllowHashForComparing` to be set to true. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [SAP2000PushConfig.cs](https://github.com/BHoM/SAP2000_Toolkit/blob/develop/SAP2000_oM/Config/SAP2000PushConfig.cs)

All history and changes of the class can be found by inspection the history.
