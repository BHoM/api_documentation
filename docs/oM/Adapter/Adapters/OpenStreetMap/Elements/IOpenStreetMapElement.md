---
title: IOpenStreetMapElement
---

# <small>BH.oM.Adapters.OpenStreetMap.</small>**IOpenStreetMapElement**

Interface for OpenStreetMap elements.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IOpenStreetMapElement is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.OpenStreetMap.[Node](/api/oM/Adapter/Adapters/OpenStreetMap/Elements/Node)
    - BH.oM.Adapters.OpenStreetMap.[Relation](/api/oM/Adapter/Adapters/OpenStreetMap/Elements/Relation)
    - BH.oM.Adapters.OpenStreetMap.[Way](/api/oM/Adapter/Adapters/OpenStreetMap/Elements/Way)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| KeyValues | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | The KeyValue tags describing the geographic attributes of this Element. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IOpenStreetMapElement : BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: OpenStreetMap_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IOpenStreetMapElement.cs](https://github.com/BHoM/OpenStreetMap_Toolkit/blob/develop/OpenStreetMap_oM/Elements\IOpenStreetMapElement.cs)

All history and changes of the class can be found by inspection the history.
