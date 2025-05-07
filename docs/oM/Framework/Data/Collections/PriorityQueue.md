---
title: PriorityQueue&lt;T&gt;
---

# <small>BH.oM.Data.Collections.</small>**PriorityQueue&lt;T&gt;**



## Class structure

### Generic parameters

The PriorityQueue contains the following generic paramters:

#### T

Constrained by the following arguments:

- [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;[T](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0#t)&gt;

### Implemented interfaces and base types

???+ bhom "The PriorityQueue`1 is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Data.Collections.[IDataStructure](/api/oM/Framework/Data/Collections/IDataStructure)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Data | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[T](#t)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PriorityQueue`1 : BH.oM.Data.Collections.IDataStructure, BH.oM.Base.IObject
```

Assembly: Data_oM.dll

The C# class definition is available on github:

- [PriorityQueue.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Collections\PriorityQueue.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Data_oM/Collections/PriorityQueue`1.json"
}
```

The JSON Schema is available on github here:

- [PriorityQueue`1.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Data_oM/Collections/PriorityQueue`1.json)
