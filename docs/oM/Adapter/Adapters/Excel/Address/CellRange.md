---
title: CellRange
---

# <small>BH.oM.Adapters.Excel.</small>**CellRange**

Object representing an orthogonal range between two cell in the spreadsheet.

## Class structure

### Implemented interfaces and base types

???+ bhom "The CellRange is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| From | [CellAddress](/api/oM/Adapter/Adapters/Excel/Address/CellAddress) | Starting (upper left) cell of the range. | - |
| To | [CellAddress](/api/oM/Adapter/Adapters/Excel/Address/CellAddress) | Ending (bottom right) cell of the range. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IsValid | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks whether given BHoM CellRange is valid for use in Excel adapter and raises errors if not. | - | Excel_Engine |


## Code and Schema

### C# implementation

``` C# title="C#"
public class CellRange : BH.oM.Base.IObject
```

Assembly: Excel_oM.dll

The class is defined in C#. The class definition is available on github:

- [CellRange.cs](https://github.com/BHoM/Excel_Toolkit/blob/develop/Excel_oM/Address\CellRange.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Excel_oM/CellRange.json}
```

The JSON Schema is available on github here:

- [CellRange.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Excel_oM/CellRange.json)
