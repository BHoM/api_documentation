---
title: Way
---

# Adapters.OpenStreetMap.Way

A Way is an ordered list of nodes which normally also has at least one tag or is included within a Relation.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Way in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Adapters.OpenStreetMap.[IOpenStreetMapElement](/api_documentation/oM/Adapter/Adapters/OpenStreetMap/IOpenStreetMapElement)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Nodes | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Node](/api_documentation/oM/Adapter/Adapters/OpenStreetMap/Node)&gt; | The list of nodes that define this Way. | - |
| OsmID | [long](https://learn.microsoft.com/en-us/dotnet/api/System.Int64?view=netstandard-2.0) | The unique OpenStreetMap id for the Way. | - |
| NodeOsmIds | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[long](https://learn.microsoft.com/en-us/dotnet/api/System.Int64?view=netstandard-2.0)&gt; | The unique OpenStreetMap ids for the Nodes. | - |
| KeyValues | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | The KeyValue tags describing the geographic attributes of this Way. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| Area | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Calculate the area of an OpenStreetMap way in metres. | - | OpenStreetMap_Engine |
| AverageNode | [Node](/api_documentation/oM/Adapter/Adapters/OpenStreetMap/Node) | Calculate the average node an OpenStreetMap Way. | - | OpenStreetMap_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [Way.cs](https://github.com/BHoM/OpenStreetMap_Toolkit/blob/develop/OpenStreetMap_oM/Elements/Way.cs)

All history and changes of the class can be found by inspection the history.
