---
title: ZoneComponentLoadSummary
---

# <small>BH.oM.XML.EnergyPlus.</small>**ZoneComponentLoadSummary**



## Class structure

### Implemented interfaces and base types

???+ bhom "The ZoneComponentLoadSummary is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.XML.EnergyPlus.[EnergyPlusObject](/api/oM/Adapter/XML/EnergyPlus/EnergyPlusObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| For | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| EstimatedCoolingPeakLoadComponent | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[EstimatedCoolingPeakLoadComponent](/api/oM/Adapter/XML/EnergyPlus/EstimatedCoolingPeakLoadComponent)&gt; | - | - |
| CoolingPeakConditions | [CoolingPeakCondition](/api/oM/Adapter/XML/EnergyPlus/CoolingPeakCondition) | - | - |
| HeatingPeakConditions | [HeatingPeakCondition](/api/oM/Adapter/XML/EnergyPlus/HeatingPeakCondition) | - | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class ZoneComponentLoadSummary : BH.oM.XML.EnergyPlus.EnergyPlusObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: XML_oM.dll

The class is defined in C#. The class definition is available on github:

- [ZoneComponentLoadSummary.cs](https://github.com/BHoM/XML_Toolkit/blob/develop/XML_oM/EnergyPlus\ZoneComponentLoadSummary.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/XML_oM/EnergyPlus/ZoneComponentLoadSummary.json}
```

The JSON Schema is available on github here:

- [ZoneComponentLoadSummary.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/XML_oM/EnergyPlus/ZoneComponentLoadSummary.json)
