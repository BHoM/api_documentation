---
title: CellAddress
---

# <small>BH.oM.Adapters.Excel.</small>**CellAddress**

Object representing a cell address: its column index as string and row index as integer.

## Class structure

### Implemented interfaces and base types

???+ bhom "The CellAddress is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Column | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Column index as string, starting from 'A'. | - |
| Row | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Row index as integer, starting from 1. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether given BHoM CellAddress is valid for use in Excel adapter and raises errors if not. | - | Excel_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class CellAddress : BH.oM.Base.IObject
```

Assembly: Excel_oM.dll

The C# class definition is available on github:

- [CellAddress.cs](https://github.com/BHoM/Excel_Toolkit/blob/develop/Excel_oM/Address\CellAddress.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Excel_oM/CellAddress.json"
}
```

The JSON Schema is available on github here:

- [CellAddress.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Excel_oM/CellAddress.json)
