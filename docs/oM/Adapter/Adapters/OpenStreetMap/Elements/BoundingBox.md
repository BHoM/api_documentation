---
title: BoundingBox
---

# <small>BH.oM.Adapters.OpenStreetMap.</small>**BoundingBox**

A BoundingBox defines a region for searches using the cardinal limits.

## Class structure

### Implemented interfaces and base types

???+ bhom "The BoundingBox is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Adapters.OpenStreetMap.[IOpenStreetMapRegion](/api/oM/Adapter/Adapters/OpenStreetMap/Elements/IOpenStreetMapRegion)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| North | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The maximum Latitude of the BoundingBox, in the range -90.0 to 90.0 with up to 7 decimal places. | - |
| South | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The minimum Latitude of the BoundingBox, in the range -90.0 to 90.0 with up to 7 decimal places. | - |
| East | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The maximum Longitude of the BoundingBox, in the range -180.0 to 180.0 with up to 7 decimal places. | - |
| West | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The minimum Longitude of the BoundingBox, in the range -180.0 to 180.0 with up to 7 decimal places. | - |


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
public class BoundingBox : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Adapters.OpenStreetMap.IOpenStreetMapRegion
```

Assembly: OpenStreetMap_oM.dll

The C# class definition is available on github:

- [BoundingBox.cs](https://github.com/BHoM/OpenStreetMap_Toolkit/blob/develop/OpenStreetMap_oM/Elements\BoundingBox.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/OpenStreetMap_oM/BoundingBox.json"
}
```

The JSON Schema is available on github here:

- [BoundingBox.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/OpenStreetMap_oM/BoundingBox.json)
