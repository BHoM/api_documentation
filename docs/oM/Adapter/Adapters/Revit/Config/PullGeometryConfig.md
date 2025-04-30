---
title: PullGeometryConfig
---

# <small>BH.oM.Adapters.Revit.</small>**PullGeometryConfig**

Configuration used to specify which geometry should be pulled and passed to RevitGeometry fragment.

## Class structure

### Implemented interfaces and base types

???+ bhom "The PullGeometryConfig is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| PullEdges | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, edges of elements will be pulled and stored under Revit_edges in RevitGeometry fragment. | - |
| PullSurfaces | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, surfaces of elements will be pulled and stored under Revit_surfaces in RevitGeometry fragment. | - |
| PullMeshes | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, meshed surfaces of elements will be pulled and stored under Revit_meshes in RevitGeometry fragment. | - |
| MeshDetailLevel | [DetailLevel](/api/oM/Adapter/Adapters/Revit/Enums/DetailLevel) | Detail level of mesh to be pulled, correspondent to level of detail in Revit. | - |
| IncludeNonVisible | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Invisible element parts will be pulled and passed to RevitGeometry fragment if true. PullEdges or PullSurfaces switched to true needed for this to activate. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PullGeometryConfig : BH.oM.Base.IObject
```

Assembly: Revit_oM.dll

The class is defined in C#. The class definition is available on github:

- [PullGeometryConfig.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Config\PullGeometryConfig.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Revit_oM/PullGeometryConfig.json}
```

The JSON Schema is available on github here:

- [PullGeometryConfig.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Revit_oM/PullGeometryConfig.json)
