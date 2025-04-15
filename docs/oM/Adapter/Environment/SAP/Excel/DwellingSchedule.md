---
title: DwellingSchedule
---

# Environment.SAP.Excel.DwellingSchedule

The details of roofs from the users excel input.

## Class structure

### Implemented interfaces and base types

???+ bhom "The DwellingSchedule in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/om_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| DwellingTypeName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The name of the dwelling the roof is located in. | - |
| Count | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | The type of roof | - |
| DwellingOrientation | [OrientationCode](/om_documentation/oM/Adapter/Environment/SAP/OrientationCode) | The storey the roof is located on. | - |
| FileName | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Heating file name, eg HeatingFile.xml . | - |
| Level | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Indication of where a flat is located in a building. | - |
| Storeys | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Count of number of storeys present in the block of for this dwelling. | - |
| ConstructionYear | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The year the dwelling was constructed. | - |
| PropertyType | [TypeOfProperty](/om_documentation/oM/Adapter/Environment/SAP/TypeOfProperty) | The type of property for this dwelling. | - |
| ConstructionType | [DataTypeCode](/om_documentation/oM/Adapter/Environment/SAP/DataTypeCode) | The type of construction for this dwelling (new build, refurb, etc.). | - |
| WetRooms | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The number of wet rooms this dwelling has. | - |
| ShelteredSides | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | The number of sheltered sides this dwelling has. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/om_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [DwellingSchedule.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/Excel/DwellingSchedule.cs)

All history and changes of the class can be found by inspection the history.
