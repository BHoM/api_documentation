---
title: DBSCANObject&lt;T&gt;
---

# <small>BH.oM.Data.Collections.</small>**DBSCANObject&lt;T&gt;**



## Class structure

### Generic parameters

The DBSCANObject contains the following generic paramters:

#### T

Unconstrained generic type. Can be any type of object.

### Implemented interfaces and base types

???+ bhom "The DBSCANObject`1 is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ClusterItem | [T](#t) | - | - |
| ClusterId | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |
| IsVisited | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class DBSCANObject`1 : BH.oM.Base.IObject
```

Assembly: Data_oM.dll

The class is defined in C#. The class definition is available on github:

- [DBSCANObject.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Collections\DBSCANObject.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Data_oM/Collections/DBSCANObject`1.json}
```

The JSON Schema is available on github here:

- [DBSCANObject`1.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Data_oM/Collections/DBSCANObject`1.json)
