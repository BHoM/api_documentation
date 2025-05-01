---
title: IInitialisationSettings
---

# <small>BH.oM.Base.</small>**IInitialisationSettings**

Toolkit Settings that contain an initialisation method to be ran when the UI starts.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IInitialisationSettings is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IImmutable](/api/oM/Framework/Base/Interface/IImmutable)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| InitialisationMethod | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IInitialisationSettings : BH.oM.Base.IImmutable, BH.oM.Base.IObject
```

Assembly: BHoM.dll

The interface is defined in C#. The class definition is available on github:

- [IInitialisationSettings.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Interface\IInitialisationSettings.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/BHoM/IInitialisationSettings.json"
}
```

The JSON Schema is available on github here:

- [IInitialisationSettings.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/BHoM/IInitialisationSettings.json)
