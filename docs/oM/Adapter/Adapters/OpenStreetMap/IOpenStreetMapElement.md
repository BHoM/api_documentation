---
title: IOpenStreetMapElement
---

# Adapters.OpenStreetMap.IOpenStreetMapElement

Interface for OpenStreetMap elements.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IOpenStreetMapElement in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Adapters.OpenStreetMap.[Node](/documentation/oM/Adapter/Adapters/OpenStreetMap/Node)
    - Adapters.OpenStreetMap.[Relation](/documentation/oM/Adapter/Adapters/OpenStreetMap/Relation)
    - Adapters.OpenStreetMap.[Way](/documentation/oM/Adapter/Adapters/OpenStreetMap/Way)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| KeyValues | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | The KeyValue tags describing the geographic attributes of this Element. | - |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IOpenStreetMapElement.cs](https://github.com/BHoM/OpenStreetMap_Toolkit/blob/develop/OpenStreetMap_oM/Elements/IOpenStreetMapElement.cs)

All history and changes of the class can be found by inspection the history.
