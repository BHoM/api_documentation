---
title: LadybugConfig
---

# LadybugTools.LadybugConfig

The action config for the LadybugTools Adapter.

## Class structure

### Implemented interfaces and base types

???+ bhom "The LadybugConfig in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapter.[ActionConfig](/api_documentation/oM/Framework/Adapter/ActionConfig)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| JsonFile | [FileSettings](/api_documentation/oM/Framework/Adapter/FileSettings) | File settings for the json file to pull/push to. | - |
| CacheFileMaximumAge | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | The amount of time (in days) any files that have been created by the adapter for caching purposes should exist before being removed/recreated. <br> Files are only deleted/updated . <br> Set to 0 to force a recompute of a simulation that has a stored cache. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| WrapNonBHoMObjects | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, the Push action wraps any non-BHoM type into a BH.oM.Adapter.ObjectWrapper, allowing them to make use of the full Adapter workflow. | - |
| AllowHashForComparing | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true and if no specific EqualityComparer is found for the type, Diffing hashes are computed and used to compare the objects. | - |
| DiffingConfig | [DiffingConfig](/api_documentation/oM/Framework/Diffing/DiffingConfig) | Configurations for the Diffing hashing. Requires `AllowHashForComparing` to be set to true. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [LadybugConfig.cs](https://github.com/BHoM/LadybugTools_Toolkit/blob/develop/LadybugTools_oM/Config/LadybugConfig.cs)

All history and changes of the class can be found by inspection the history.
