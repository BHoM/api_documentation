---
title: GraphLink&lt;T&gt;
---

# <small>BH.oM.Data.Collections.</small>**GraphLink&lt;T&gt;**



## Class structure

### Generic parameters

The GraphLink contains the following generic paramters:

#### T

Unconstrained generic type. Can be any type of object.

### Implemented interfaces and base types

???+ bhom "The GraphLink`1 is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Data.Collections.[IDataStructure](/api/oM/Framework/Data/Collections/IDataStructure)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Attributes | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |
| Weight | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| StartNode | [GraphNode](/api/oM/Framework/Data/Collections/GraphNode)&lt;[T](#t)&gt; | - | - |
| EndNode | [GraphNode](/api/oM/Framework/Data/Collections/GraphNode)&lt;[T](#t)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class GraphLink`1 : BH.oM.Data.Collections.IDataStructure, BH.oM.Base.IObject
```

Assembly: Data_oM.dll

The class is defined in C#. The class definition is available on github:

- [GraphLink.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Collections\GraphLink.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Data_oM/Collections/GraphLink`1.json}
```

The JSON Schema is available on github here:

- [GraphLink`1.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Data_oM/Collections/GraphLink`1.json)
