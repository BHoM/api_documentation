---
title: Relation
---

# <small>BH.oM.Adapters.OpenStreetMap.</small>**Relation**

A relation is a group of elements (Members) used to model logical (and usually local) or geographic relationships between objects.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Relation is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  BH.oM.Adapters.OpenStreetMap.[IOpenStreetMapElement](/api/oM/Adapter/Adapters/OpenStreetMap/Elements/IOpenStreetMapElement)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| OsmID | [long](https://learn.microsoft.com/en-us/dotnet/api/System.Int64?view=netstandard-2.0) | The unique OpenStreetMap id for the Relation. | - |
| KeyValues | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | The KeyValue tags describing the geographic attributes of this Relation. | - |
| Members | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IOpenStreetMapElement](/api/oM/Adapter/Adapters/OpenStreetMap/Elements/IOpenStreetMapElement)&gt; | The IOpenStreetMapElement that define this Relation. | - |


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
public class Relation : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject, BH.oM.Adapters.OpenStreetMap.IOpenStreetMapElement
```

Assembly: OpenStreetMap_oM.dll

The C# class definition is available on github:

- [Relation.cs](https://github.com/BHoM/OpenStreetMap_Toolkit/blob/develop/OpenStreetMap_oM/Elements\Relation.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/OpenStreetMap_oM/Relation.json"
}
```

The JSON Schema is available on github here:

- [Relation.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/OpenStreetMap_oM/Relation.json)
