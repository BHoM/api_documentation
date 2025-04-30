---
title: RenderMeshOptions
---

# <small>BH.oM.Graphics.</small>**RenderMeshOptions**

Defines options for the Meshing of BHoM Objects.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RenderMeshOptions is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| RepresentationOptions | [RepresentationOptions](/api/oM/Graphics/Graphics/Render/RepresentationOptions) | Regulate how the Representation of the objects is computed. | - |
| Element1DRefinement | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Regulates the refinement of Pipe meshes for 1DElements, i.e. the number of faces of the Pipes. | - |
| Element2DRefinement | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Regulates the refinement of surface meshes for 2DElements. | - |
| CustomDataColorKey | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The key of the BHoMObjects' CustomData dictionary where colour information might be found. | - |


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
public class RenderMeshOptions : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Graphics_oM.dll

The class is defined in C#. The class definition is available on github:

- [RenderMeshOptions.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Render\RenderMeshOptions.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Graphics_oM/RenderMeshOptions.json}
```

The JSON Schema is available on github here:

- [RenderMeshOptions.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Graphics_oM/RenderMeshOptions.json)
