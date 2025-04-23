---
title: RevitPushConfig
---

# Adapters.Revit.RevitPushConfig

Configuration used for adapter interaction with Revit on Push action.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RevitPushConfig in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapter.[ActionConfig](/api/oM/Framework/Adapter/ActionConfig)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SuppressFailureMessages | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, Revit warnings and failure messages will be suppressed (not shown to the user). Whilst this option may speed the pushing process up in case of multiple warnings, it may lead to important issues. | - |
| IncludeClosedWorksets | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Elements from closed worksets will be processed if true. | - |
| SetLocationOnUpdate | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If false, only parameters of a Revit element will be updated. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| WrapNonBHoMObjects | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, the Push action wraps any non-BHoM type into a BH.oM.Adapter.ObjectWrapper, allowing them to make use of the full Adapter workflow. | - |
| AllowHashForComparing | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true and if no specific EqualityComparer is found for the type, Diffing hashes are computed and used to compare the objects. | - |
| DiffingConfig | [DiffingConfig](/api/oM/Framework/Diffing/DiffingConfig) | Configurations for the Diffing hashing. Requires `AllowHashForComparing` to be set to true. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [RevitPushConfig.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Config/RevitPushConfig.cs)

All history and changes of the class can be found by inspection the history.
