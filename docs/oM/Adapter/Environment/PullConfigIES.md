---
title: PullConfigIES
---

# <small>BH.oM.Environment.IES.</small>**PullConfigIES**

Create a pull config for IES for use with the IES Adapter.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PullConfigIES is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Adapter.[ActionConfig](/api/oM/Framework/Adapter/Settings-Config/ActionConfig)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Environment.IES.[IIESConfig](/api/oM/Adapter/Environment/IIESConfig)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ShadesAs3D | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Determine whether or not shades should be pulled as 3D spaces or not. | - |
| PullOpenings | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Determine whether or not openings should be pulled from the GEM file when pulling a GEM file. Only valid if pulling Panels which host openings. Default is True, to pull openings when pulling panels. | - |
| AngleTolerance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Set the tolerance to be used in angle calculations or wherever a Geometry method requires an Angle Tolerance to determine a zero number. | - |
| DistanceTolerance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Set the tolerance to be used in distance calculations or wherever a Geometry method requires an Distance Tolerance to determine a zero number. | - |
| File | [FileSettings](/api/oM/Framework/Adapter/FileSettings) | Set the location of the file to pull IES data from. | - |


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
public class PullConfigIES : BH.oM.Adapter.ActionConfig, BH.oM.Base.IObject, BH.oM.Environment.IES.IIESConfig
```

Assembly: IES_oM.dll

The class is defined in C#. The class definition is available on github:

- [PullConfigIES.cs](https://github.com/BHoM/IES_Toolkit/blob/develop/IES_oM/PullConfigIES.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/IES_oM/IES/PullConfigIES.json}
```

The JSON Schema is available on github here:

- [PullConfigIES.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/IES_oM/IES/PullConfigIES.json)
