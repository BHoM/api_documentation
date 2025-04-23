---
title: ExcelPushConfig
---

# Adapters.Excel.ExcelPushConfig

Configuration used for adapter interaction with Excel on Push action.

## Class structure

### Implemented interfaces and base types

???+ bhom "The ExcelPushConfig in inheriting from the following base type(s) and implements the following interfaces:"

    -  Adapter.[ActionConfig](/api/oM/Framework/Adapter/ActionConfig)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Worksheet | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the worksheet to write to. | - |
| StartingCell | [CellAddress](/api/oM/Adapter/Adapters/Excel/CellAddress) | The first cell that will be filled with the pushed objects, i.e. top-left cell of the populated space in the spreadsheet. | - |
| ObjectProperties | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | List of object properties to push to the table. Those will form the columns of the created table. | - |
| PropertiesToIgnore | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | List of object properties that shouldn't be added to the table. | - |
| GoDeepInProperties | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, non-primitive properties will be divided in multiple column. | - |
| TransposeObjectTable | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, transpose the table so that each column is a separate object and each row is a different property. | - |
| IncludePropertyNames | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, the property names will be shown as the first row (or column if transposed) | - |
| WorkbookProperties | [WorkbookProperties](/api/oM/Adapter/Adapters/Excel/WorkbookProperties) | Properties to apply to workbook and contents. If not null, the meta information of the workbook will be updated on push. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| WrapNonBHoMObjects | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true, the Push action wraps any non-BHoM type into a BH.oM.Adapter.ObjectWrapper, allowing them to make use of the full Adapter workflow. | - |
| AllowHashForComparing | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | If true and if no specific EqualityComparer is found for the type, Diffing hashes are computed and used to compare the objects. | - |
| DiffingConfig | [DiffingConfig](/api/oM/Framework/Diffing/DiffingConfig) | Configurations for the Diffing hashing. Requires `AllowHashForComparing` to be set to true. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [ExcelPushConfig.cs](https://github.com/BHoM/Excel_Toolkit/blob/develop/Excel_oM/Config/ExcelPushConfig.cs)

All history and changes of the class can be found by inspection the history.
