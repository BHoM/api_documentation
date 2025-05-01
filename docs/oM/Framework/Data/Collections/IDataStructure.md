---
title: IDataStructure
---

# <small>BH.oM.Data.Collections.</small>**IDataStructure**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IDataStructure is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Interfaces implementing this interface

???+ bhom "The following interfaces are implementing this interface:"

    - BH.oM.Data.Collections.[INode](/api/oM/Framework/Data/Collections/Node)&lt;[T](/api/oM/Framework/Data/Collections/Node#t)&gt;


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Data.Collections.[DiscretePoint](/api/oM/Framework/Data/Collections/DiscretePoint)
    - BH.oM.Data.Collections.[DomainTree](/api/oM/Framework/Data/Collections/DomainTree)&lt;[T](/api/oM/Framework/Data/Collections/DomainTree#t)&gt;
    - BH.oM.Data.Collections.[Graph](/api/oM/Framework/Data/Collections/Graph)&lt;[T](/api/oM/Framework/Data/Collections/Graph#t)&gt;
    - BH.oM.Data.Collections.[GraphLink](/api/oM/Framework/Data/Collections/GraphLink)&lt;[T](/api/oM/Framework/Data/Collections/GraphLink#t)&gt;
    - BH.oM.Data.Collections.[GraphNode](/api/oM/Framework/Data/Collections/GraphNode)&lt;[T](/api/oM/Framework/Data/Collections/GraphNode#t)&gt;
    - BH.oM.Data.Collections.[LocalData](/api/oM/Framework/Data/Collections/LocalData)&lt;[T](/api/oM/Framework/Data/Collections/LocalData#t)&gt;
    - BH.oM.Data.Collections.[PointMatrix](/api/oM/Framework/Data/Collections/PointMatrix)&lt;[T](/api/oM/Framework/Data/Collections/PointMatrix#t)&gt;
    - BH.oM.Data.Collections.[PriorityQueue](/api/oM/Framework/Data/Collections/PriorityQueue)&lt;[T](/api/oM/Framework/Data/Collections/PriorityQueue#t)&gt;
    - BH.oM.Data.Collections.[Tree](/api/oM/Framework/Data/Collections/Tree)&lt;[T](/api/oM/Framework/Data/Collections/Tree#t)&gt;
    - BH.oM.Data.Collections.[VennDiagram](/api/oM/Framework/Data/Collections/VennDiagram)&lt;[T](/api/oM/Framework/Data/Collections/VennDiagram#t)&gt;


## Properties

## Code and Schema

### C# implementation

``` C# title="C#"
public interface IDataStructure : BH.oM.Base.IObject
```

Assembly: Data_oM.dll

The interface is defined in C#. The class definition is available on github:

- [IDataStructure.cs](https://github.com/BHoM/BHoM/blob/develop/Data_oM/Collections\IDataStructure.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Data_oM/Collections/IDataStructure.json"
}
```

The JSON Schema is available on github here:

- [IDataStructure.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Data_oM/Collections/IDataStructure.json)
