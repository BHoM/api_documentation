---
title: DiscretePoint
---

# <small>BH.oM.Data.Collections.</small>**DiscretePoint**



## Class structure

### Implemented interfaces and base types

???+ bhom "The DiscretePoint is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Data.Collections.[IDataStructure](/api/oM/Framework/Data/Collections/IDataStructure)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)
    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;BH.oM.Data.Collections.[DiscretePoint](/api/oM/Framework/Data/Collections/DiscretePoint)&gt;


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| X | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |
| Y | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |
| Z | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class DiscretePoint : BH.oM.Data.Collections.IDataStructure, BH.oM.Base.IObject, System.IComparable<BH.oM.Data.Collections.DiscretePoint>
```

Assembly: Data_oM.dll

The class is defined in C#. The class definition is available on github:

- [DiscretePoint.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Collections\DiscretePoint.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Data_oM/Collections/DiscretePoint.json}
```

The JSON Schema is available on github here:

- [DiscretePoint.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Data_oM/Collections/DiscretePoint.json)
