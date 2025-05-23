---
title: Layer
---

# <small>BH.oM.Structure.SurfaceProperties.</small>**Layer**

A layer object with a given material, orientation, and thickness.

## Class structure

### Implemented interfaces and base types

???+ bhom "The Layer is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Material | [IMaterialFragment](/api/oM/Analytical/Structure/MaterialFragments/IMaterialFragment) | The material this layer is made of. | - |
| Orientation | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The orientation of the material in this layer. Orthotropic materials will be oriented with Z parallel to the panel normal direction, and X rotated counterclockwise about the panel normal by this angle from the panel X axis. Not relevant for isotropic materials. | [Angle](/api/oM/Dimensional/Quantities/Attributes/Angle) [rad] |
| Thickness | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The thickness of this material layer. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |


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
public class Layer : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Structure_oM.dll

The C# class definition is available on github:

- [Layer.cs](https://github.com/BHoM/BHoM/blob/develop/Structure_oM/SurfaceProperties\Layer.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Structure_oM/SurfaceProperties/Layer.json"
}
```

The JSON Schema is available on github here:

- [Layer.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Structure_oM/SurfaceProperties/Layer.json)
