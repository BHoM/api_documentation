---
title: GeometryGroup
---

# <small>BH.oM.Adapters.STL.</small>**GeometryGroup**

This object can be used to group geometry to push to a specific file. Useful if pushing groups of geometry related to specific representations, for example, a group of panels to one file, and a group of bars to another.

## Class structure

### Implemented interfaces and base types

???+ bhom "The GeometryGroup is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Geometry | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[IGeometry](/api/oM/Dimensional/Geometry/Interface/IGeometry)&gt; | The container of Geometry which is grouped to this file. This can be any BHoM Geometry and can be mixed types. | - |
| FileName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The name of the file which this geometry should be stored (pushed) to. Do not include a directory on this file name, the save directory should be specified on the STLSettings object for the Adapter. Do not provide a file extension either, this will be handled by the Adapter. | - |


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
public class GeometryGroup : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: STL_oM.dll

The C# class definition is available on github:

- [GeometryGroup.cs](https://github.com/BHoM/STL_Toolkit/blob/develop/STL_oM/GeometryGroup.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/STL_oM/GeometryGroup.json"
}
```

The JSON Schema is available on github here:

- [GeometryGroup.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/STL_oM/GeometryGroup.json)
