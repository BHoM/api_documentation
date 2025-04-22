---
title: CentreRadius
---

# Adapters.OpenStreetMap.CentreRadius

A CentreRadius defines a region for searches within a radius around Node.

## Class structure

### Implemented interfaces and base types

???+ bhom "The CentreRadius in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Adapters.OpenStreetMap.[IOpenStreetMapRegion](/api_documentation/oM/Adapter/Adapters/OpenStreetMap/IOpenStreetMapRegion)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Centre | [Node](/api_documentation/oM/Adapter/Adapters/OpenStreetMap/Node) | The Node to search around. | - |
| Radius | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The radius to search. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [CentreRadius.cs](https://github.com/BHoM/OpenStreetMap_Toolkit/blob/develop/OpenStreetMap_oM/Elements/CentreRadius.cs)

All history and changes of the class can be found by inspection the history.
