---
title: RevitSettings
---

# <small>BH.oM.Adapters.Revit.Settings.</small>**RevitSettings**

General settings that are applicable to all actions performed by the instance of Revit adapter.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RevitSettings is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ConnectionSettings | [ConnectionSettings](/api/oM/Adapter/Adapters/Revit/Settings/ConnectionSettings) | Socket connection settings (ports, timeout) for the adapter. | - |
| FamilyLoadSettings | [FamilyLoadSettings](/api/oM/Adapter/Adapters/Revit/Settings/FamilyLoadSettings) | Revit family load settings for the adapter. | - |
| MappingSettings | [MappingSettings](/api/oM/Adapter/Adapters/Revit/Settings/MappingSettings) | An entity holding information about the enforced convert relationships between Revit families and BHoM types on Pull as well as mapping between Revit parameters and BHoM object properties on Push/Pull. | - |
| DistanceTolerance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Distance tolerance to be used in geometry processing. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| AngleTolerance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Angle tolerance to be used in geometry processing. | [Angle](/api/oM/Dimensional/Quantities/Attributes/Angle) [rad] |


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
public class RevitSettings : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Revit_oM.dll

The C# class definition is available on github:

- [RevitSettings.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Settings\RevitSettings.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Revit_oM/Settings/RevitSettings.json"
}
```

The JSON Schema is available on github here:

- [RevitSettings.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Revit_oM/Settings/RevitSettings.json)
