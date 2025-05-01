---
title: IAcousticParameter
---

# <small>BH.oM.Acoustic.</small>**IAcousticParameter**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IAcousticParameter is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Acoustic.[Rasti](/api/oM/Analytical/Acoustic/Parameters/Rasti)
    - BH.oM.Acoustic.[RT60](/api/oM/Analytical/Acoustic/Parameters/RT60)
    - BH.oM.Acoustic.[SnRatio](/api/oM/Analytical/Acoustic/Parameters/SnRatio)
    - BH.oM.Acoustic.[SoundLevel](/api/oM/Analytical/Acoustic/Parameters/SoundLevel)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Value | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| ReceiverID | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |
| SpeakerID | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |
| Frequency | [Frequency](/api/oM/Analytical/Acoustic/Frequency) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IAcousticParameter : BH.oM.Base.IObject
```

Assembly: Acoustic_oM.dll

The C# interface definition is available on github:

- [IAcousticParameter.cs](https://github.com/BHoM/BHoM/blob/develop/Acoustic_oM/Parameters\IAcousticParameter.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Acoustic_oM/IAcousticParameter.json"
}
```

The JSON Schema is available on github here:

- [IAcousticParameter.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Acoustic_oM/IAcousticParameter.json)
