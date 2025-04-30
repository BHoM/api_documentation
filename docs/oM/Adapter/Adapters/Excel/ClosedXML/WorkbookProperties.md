---
title: WorkbookProperties
---

# <small>BH.oM.Adapters.Excel.</small>**WorkbookProperties**

Object representing the meta information of the workbook.

## Class structure

### Implemented interfaces and base types

???+ bhom "The WorkbookProperties is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Author | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Author of the workbook. | - |
| Title | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Title of the workbook. | - |
| Subject | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Subject of the workbook. | - |
| Category | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Category of the workbook. | - |
| Keywords | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Keywords related to the workbook. | - |
| Comments | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Comments applied to the workbook. | - |
| Status | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Status of the workbook. | - |
| LastModifiedBy | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Last user that modified the workbook. | - |
| Company | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Company of the last user that modified the workbook. | - |
| Manager | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Manager of the last user that modified the workbook. | - |


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
public class WorkbookProperties : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Excel_oM.dll

The class is defined in C#. The class definition is available on github:

- [WorkbookProperties.cs](https://github.com/BHoM/Excel_Toolkit/blob/develop/Excel_oM/ClosedXML\WorkbookProperties.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Excel_oM/WorkbookProperties.json}
```

The JSON Schema is available on github here:

- [WorkbookProperties.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Excel_oM/WorkbookProperties.json)
