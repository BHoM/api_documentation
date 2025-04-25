---
title: GBXMLUnitSetUp
---

# <small>BH.oM.Adapters.XML.</small>**GBXMLUnitSetUp**



## Class structure

### Implemented interfaces and base types

???+ bhom "The GBXMLUnitSetUp is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| TemperatureUnit | [TemperatureUnit](/api/oM/Adapter/Adapters/XML/GBXML/Enums/TemperatureUnit) | - | - |
| LengthUnit | [LengthUnit](/api/oM/Adapter/Adapters/XML/GBXML/Enums/LengthUnit) | - | - |
| AreaUnit | [AreaUnit](/api/oM/Adapter/Adapters/XML/GBXML/Enums/AreaUnit) | - | - |
| VolumeUnit | [VolumeUnit](/api/oM/Adapter/Adapters/XML/GBXML/Enums/VolumeUnit) | - | - |


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
public class GBXMLUnitSetUp : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: XML_oM.dll

The class is defined in C#. The class definition is available on github:

- [GBXMLUnitSetUp.cs](https://github.com/BHoM/XML_Toolkit/blob/develop/XML_oM/GBXML\GBXMLUnitSetUp.cs)

All history and changes of the class can be found by inspection the history.
