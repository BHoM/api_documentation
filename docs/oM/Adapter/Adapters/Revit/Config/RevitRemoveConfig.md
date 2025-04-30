---
title: RevitRemoveConfig
---

# <small>BH.oM.Adapters.Revit.</small>**RevitRemoveConfig**

Configuration used for adapter interaction with Revit on Remove action.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RevitRemoveConfig is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[ActionConfig](/api/oM/Framework/Adapter/Settings-Config/ActionConfig)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SuppressFailureMessages | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, Revit warnings and failure messages will be suppressed (not shown to the user). Whilst this option may speed the pushing process up in case of multiple warnings, it may lead to important issues. | - |
| IncludeClosedWorksets | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Elements from closed worksets will be processed if true. | - |
| RemovePinned | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Pinned elements will be processed if true. | - |


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
public class RevitRemoveConfig : BH.oM.Adapter.ActionConfig, BH.oM.Base.IObject
```

Assembly: Revit_oM.dll

The class is defined in C#. The class definition is available on github:

- [RevitRemoveConfig.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Config\RevitRemoveConfig.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Revit_oM/RevitRemoveConfig.json}
```

The JSON Schema is available on github here:

- [RevitRemoveConfig.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Revit_oM/RevitRemoveConfig.json)
