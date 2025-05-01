---
title: DwellingSchedule
---

# <small>BH.oM.Environment.SAP.Excel.</small>**DwellingSchedule**

The details of roofs from the users excel input.

## Class structure

### Implemented interfaces and base types

???+ bhom "The DwellingSchedule is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| DwellingTypeName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The name of the dwelling the roof is located in. | - |
| Count | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | The type of roof | - |
| DwellingOrientation | [OrientationCode](/api/oM/Adapter/Environment/Enums/OrientationCode) | The storey the roof is located on. | - |
| FileName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Heating file name, eg HeatingFile.xml . | - |
| Level | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Indication of where a flat is located in a building. | - |
| Storeys | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Count of number of storeys present in the block of for this dwelling. | - |
| ConstructionYear | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The year the dwelling was constructed. | - |
| PropertyType | [TypeOfProperty](/api/oM/Adapter/Environment/Enums/TypeOfProperty) | The type of property for this dwelling. | - |
| ConstructionType | [DataTypeCode](/api/oM/Adapter/Environment/Enums/DataTypeCode) | The type of construction for this dwelling (new build, refurb, etc.). | - |
| WetRooms | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The number of wet rooms this dwelling has. | - |
| ShelteredSides | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | The number of sheltered sides this dwelling has. | - |


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
public class DwellingSchedule : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: SAP_oM.dll

The class is defined in C#. The class definition is available on github:

- [DwellingSchedule.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Excel\DwellingSchedule.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SAP_oM/SAP/Excel/DwellingSchedule.json"
}
```

The JSON Schema is available on github here:

- [DwellingSchedule.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SAP_oM/SAP/Excel/DwellingSchedule.json)
