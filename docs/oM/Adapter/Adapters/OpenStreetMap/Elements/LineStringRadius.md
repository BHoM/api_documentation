---
title: LineStringRadius
---

# <small>BH.oM.Adapters.OpenStreetMap.</small>**LineStringRadius**

A LineStringRadius defines a region for searches within a radius around polygon.

## Class structure

### Implemented interfaces and base types

???+ bhom "The LineStringRadius is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Adapters.OpenStreetMap.[IOpenStreetMapRegion](/api/oM/Adapter/Adapters/OpenStreetMap/Elements/IOpenStreetMapRegion)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Radius | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The search radius. | - |
| Polygon | [Polygon](/api/oM/Adapter/Adapters/OpenStreetMap/Elements/Polygon) | The polygon to search around. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class LineStringRadius : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Adapters.OpenStreetMap.IOpenStreetMapRegion
```

Assembly: OpenStreetMap_oM.dll

The C# class definition is available on github:

- [LineStringRadius.cs](https://github.com/BHoM/OpenStreetMap_Toolkit/blob/develop/OpenStreetMap_oM/Elements\LineStringRadius.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/OpenStreetMap_oM/LineStringRadius.json"
}
```

The JSON Schema is available on github here:

- [LineStringRadius.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/OpenStreetMap_oM/LineStringRadius.json)
