---
title: PushConfig
---

# <small>BH.oM.Adapters.File.</small>**PushConfig**

Configurations specific for an Adapter Action (Push, Pull, etc).
Consider that your tookit might have a more specific implementation available. Try to look for [your toolkit name]ActionConfig.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PushConfig is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[ActionConfig](/api/oM/Framework/Adapter/Settings-Config/ActionConfig)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| UseDatasetSerialization | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | When serialising to JSON, use the Dataset serialization style.<br>This serializes the individual objects, and then concatenates the strings separating with a newline.<br>The obtained format is not valid JSON. You will need to deserialize each individual line.<br>This is the current standard for Datasets. | - |
| SkipUnsupportedTypes | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | By default, certain types cannot be pushed to Json as root-level objects, for example numbers.<br>Set this option to `true` to allow skipping those types. | - |
| BeautifyJson | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, beautify Json files for web display. Works only if UseDatasetSerialization is set to false. | - |
| DisableWarnings | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Keeps the warnings about Deletion off. | - |


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
public class PushConfig : BH.oM.Adapter.ActionConfig, BH.oM.Base.IObject
```

Assembly: File_oM.dll

The class is defined in C#. The class definition is available on github:

- [PushConfig.cs](https://github.com/BHoM/File_Toolkit/blob/develop/File_oM/Config\PushConfig.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/File_oM/PushConfig.json}
```

The JSON Schema is available on github here:

- [PushConfig.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/File_oM/PushConfig.json)
