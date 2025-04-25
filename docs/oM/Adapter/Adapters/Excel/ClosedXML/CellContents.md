---
title: CellContents
---

# <small>BH.oM.Adapters.Excel.</small>**CellContents**

Object representing the information stored within a cell: the value and metadata related to it.

## Class structure

### Implemented interfaces and base types

???+ bhom "The CellContents is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[BHoMObject](/api/oM/Framework/Base/BHoMObject)
    -  BH.oM.Base.[IBHoMObject](/api/oM/Framework/Base/Interface/IBHoMObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Comment | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Comment applied to the cell. | - |
| Value | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | Value stored in the cell. | - |
| Address | [CellAddress](/api/oM/Adapter/Adapters/Excel/Address/CellAddress) | Address of the cell. | - |
| DataType | [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=netstandard-2.0) | Data type of the value stored in the cell. Only 5 data types are considered: number, text, Boolean, date/time, and timespan. | - |
| FormulaA1 | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Formula stored in the cell, in standard Excel format (e.g. "=A1"). | - |
| FormulaR1C1 | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Formula stored in the cell, in R1C1 (relative) format. For more information on that format, please search for 'A1 vs R1C1 Notation'. | - |
| HyperLink | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Hyperlink stored in the cell. | - |
| RichText | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Information about rich formatting of the cell content. | - |


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
public class CellContents : BH.oM.Base.BHoMObject, BH.oM.Base.IBHoMObject, BH.oM.Base.IObject
```

Assembly: Excel_oM.dll

The class is defined in C#. The class definition is available on github:

- [CellContents.cs](https://github.com/BHoM/Excel_Toolkit/blob/develop/Excel_oM/ClosedXML\CellContents.cs)

All history and changes of the class can be found by inspection the history.
