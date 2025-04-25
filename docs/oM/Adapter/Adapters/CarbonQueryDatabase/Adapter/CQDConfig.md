---
title: CQDConfig
---

# <small>BH.oM.Adapters.CarbonQueryDatabase.</small>**CQDConfig**

This Config can be specified in the `ActionConfig` input of any Adapter Action (e.g. Push).

## Class structure

### Implemented interfaces and base types

???+ bhom "The CQDConfig is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[ActionConfig](/api/oM/Framework/Adapter/Settings-Config/ActionConfig)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Type | [EPDType](/api/oM/Analytical/LifeCycleAssessment/Enums/EPDType) | The Type of Environmental Product Declaration | - |
| Id | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Specifies ID to search and return objects for in CarbonQueryDatabase. If this is specified it supersedes other input parameters. | - |
| Count | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Sets maximum amount of items to return from CarbonQueryDatabase | - |
| NameLike | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Specifies string to search and return objects for in CarbonQueryDatabase, ie RedBuilt RedLam LVL | - |
| PlantName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Specifies plant name to search and return objects for in CarbonQueryDatabase, ie Dupont | - |


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
public class CQDConfig : BH.oM.Adapter.ActionConfig, BH.oM.Base.IObject
```

Assembly: CarbonQueryDatabase_oM.dll

The class is defined in C#. The class definition is available on github:

- [CQDConfig.cs](https://github.com/BHoM/CarbonQueryDatabase_Toolkit/blob/develop/CarbonQueryDatabase_oM/Adapter\CQDConfig.cs)

All history and changes of the class can be found by inspection the history.
