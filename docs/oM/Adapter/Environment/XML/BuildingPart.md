---
title: BuildingPart
---

# <small>BH.oM.Environment.SAP.</small>**BuildingPart**



## Class structure

### Implemented interfaces and base types

???+ bhom "The BuildingPart is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Identifier | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Identifier for the Building part - generally only required if there are more that one Building Parts of the same type. | - |
| BuildingPartNumber | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | An integer value which uniquely identifies the building part in the property.  The value "1" must be assigned to the main dwelling. | - |
| ConstructionYear | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The year when this building part was constructed.  Not used if 'Construction-Age-Band' is used. | - |
| ConstructionAgeBand | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The age band when this building part was constructed.  Not used if 'Construction-Year' is used. | - |
| FloorDimensions | [FloorDimensions](/api/oM/Adapter/Environment/XML/FloorDimensions) | Storeys that make up a particular Building-Part. | - |
| Openings | [Openings](/api/oM/Adapter/Environment/XML/Openings) | Exposed openings that make up a particular Building-Part. | - |
| Roofs | [Roofs](/api/oM/Adapter/Environment/XML/Roofs) | Exposed roofs that make up a particular Building - Part. | - |
| Walls | [Walls](/api/oM/Adapter/Environment/XML/Walls) | Exposed walls that make up a particular Storey. | - |
| ThermalBridges | [ThermalBridges](/api/oM/Adapter/Environment/XML/ThermalBridges) | Thermal bridges that make up a particular Building-Part. | - |


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
public class BuildingPart : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: SAP_oM.dll

The class is defined in C#. The class definition is available on github:

- [BuildingPart.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/XML\BuildingPart.cs)

All history and changes of the class can be found by inspection the history.
