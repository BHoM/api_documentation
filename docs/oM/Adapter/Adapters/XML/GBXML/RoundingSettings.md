---
title: RoundingSettings
---

# <small>BH.oM.Adapters.XML.GBXML.</small>**RoundingSettings**



## Class structure

### Implemented interfaces and base types

???+ bhom "The RoundingSettings is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| GeometricPoints | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Define the number of decimal points to round the geometry coordinates to. Defaults is 4 | - |
| BuildingLocation | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Define the number of decimal points to round the Building Location data to. Default is 5 | - |
| LayerThickness | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Define the number of decimal points to round the Layer Thickness to. Default is 4 | - |
| MaterialConductivity | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Define the number of decimal points to round the Material Conductivity to. Default is 3 | - |
| MaterialDensity | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Define the number of decimal points to round the Material Density to. Default is 3 | - |
| MaterialReflectance | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Define the number of decimal points to round the Material Reflectance to. This is both Solar and Light Reflectance. Default is 3 | - |
| MaterialTransmittance | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Define the number of decimal points to round the Material Transmittance to. This is both Solar and Light Transmittance. Default is 3 | - |
| MaterialEmittance | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Define the number of decimal points to round the Material Emittance to. Default is 3 | - |
| GeometryWidth | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Define the number of decimal points to round the Width of geometry to. Default is 3 | - |
| GeometryHeight | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Define the number of decimal points to round the Height of geometry to. Default is 3 | - |
| GeometryAzimuth | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Define the number of decimal places to round the Azimuth of geometry to. Default is 3 | - |
| GeometryTilt | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Define the number of decimal points to round the Tilt of geometry to. Default is 3 | - |


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
public class RoundingSettings : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: XML_oM.dll

The C# class definition is available on github:

- [RoundingSettings.cs](https://github.com/BHoM/XML_Toolkit/blob/develop/XML_oM/GBXML\RoundingSettings.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/XML_oM/GBXML/RoundingSettings.json"
}
```

The JSON Schema is available on github here:

- [RoundingSettings.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/XML_oM/GBXML/RoundingSettings.json)
