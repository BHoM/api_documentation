---
title: RHIExistingDwelling
---

# <small>BH.oM.Environment.SAP.XML.</small>**RHIExistingDwelling**



## Class structure

### Implemented interfaces and base types

???+ bhom "The RHIExistingDwelling is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SpaceHeatingExistingDwelling | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Space heating requirement for existing dwelling. | - |
| SpaceHeatingWithLoftInsulation | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | For backwards compatibility only, do not use. | - |
| SpaceHeatingWithCavityInsulation | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | For backwards compatibility only, do not use. | - |
| SpaceHeatingWithLoftAndCavityInsulation | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | For backwards compatibility only, do not use. | - |
| WaterHeating | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Water heating requirement. | - |
| ImpactOfLoftInsulation | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Reduction in space heating requirement with loft insulation. | - |
| ImpactOfCavityInsulation | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Reduction in space heating requirement with cavity insulation. | - |
| ImpactOfSolidWallInsulation | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Reduction in space heating requirement with solid wall insulation. | - |


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
public class RHIExistingDwelling : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: SAP_oM.dll

The class is defined in C#. The class definition is available on github:

- [RHIExistingDwelling.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/XML\RHIExistingDwelling.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/XML/RHIExistingDwelling.json}
```

The JSON Schema is available on github here:

- [RHIExistingDwelling.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/XML/RHIExistingDwelling.json)
