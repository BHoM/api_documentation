---
title: PolylineData
---

# <small>BH.oM.PowerPoint.</small>**PolylineData**

Data corresponding to polylinear data and style properties.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PolylineData is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Path | [Polyline](/api/oM/Dimensional/Geometry/Curve/Polyline) | Shape to be updated. | - |
| Thickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Thickness of the path. | - |
| EdgeColour | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Colour of the edge of the path. No colour change will be made if left empty. | - |
| FillColour | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Fill colour for the shape. If left empty, no fill will be applied. | - |
| FillOpacity | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Opacity of the fill where 1 means full opacity and 0 means full transperency. | - |
| IsDashed | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Toggles if the line should be dashed or not. | - |


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
public class PolylineData : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: PowerPoint_oM.dll

The C# class definition is available on github:

- [PolylineData.cs](https://github.com/BHoM/PowerPoint_Toolkit/blob/develop/PowerPoint_oM/Update\PolylineData.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/PowerPoint_oM/PolylineData.json"
}
```

The JSON Schema is available on github here:

- [PolylineData.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/PowerPoint_oM/PolylineData.json)
