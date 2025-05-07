---
title: RFEM5Settings
---

# <small>BH.oM.Adapters.RFEM5.</small>**RFEM5Settings**

This Config can be specified in the `ActionConfig` input of any Adapter Action (e.g. Push).

## Class structure

### Implemented interfaces and base types

???+ bhom "The RFEM5Settings is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Is2DModel | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| ZIsUp | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RFEM5Settings : BH.oM.Base.IObject
```

Assembly: RFEM5_oM.dll

The C# class definition is available on github:

- [RFEM5Settings.cs](https://github.com/BHoM/RFEM5_Toolkit/blob/develop/RFEM5_oM/RFEM5Settings.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/RFEM5_oM/RFEM5Settings.json"
}
```

The JSON Schema is available on github here:

- [RFEM5Settings.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/RFEM5_oM/RFEM5Settings.json)
