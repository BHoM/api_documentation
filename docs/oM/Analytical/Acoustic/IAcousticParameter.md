---
title: IAcousticParameter
---

# Acoustic.IAcousticParameter



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IAcousticParameter in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Acoustic.[Rasti](/documentation/oM/Analytical/Acoustic/Rasti)
    - Acoustic.[RT60](/documentation/oM/Analytical/Acoustic/RT60)
    - Acoustic.[SnRatio](/documentation/oM/Analytical/Acoustic/SnRatio)
    - Acoustic.[SoundLevel](/documentation/oM/Analytical/Acoustic/SoundLevel)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Value | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| ReceiverID | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |
| SpeakerID | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |
| Frequency | [Frequency](/documentation/oM/Analytical/Acoustic/Frequency) | - | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IAcousticParameter.cs](https://github.com/BHoM/BHoM/blob/develop/Acoustic_oM/Parameters/IAcousticParameter.cs)

All history and changes of the class can be found by inspection the history.
