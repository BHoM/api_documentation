---
title: INodeParam
---

# <small>BH.oM.Programming.</small>**INodeParam**

Interface common to all syntax nodes parameters

## Interface structure

### Implemented interfaces and base types

???+ bhom "The INodeParam is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Programming.[DataParam](/api/oM/Framework/Programming/Params/DataParam)
    - BH.oM.Programming.[ReceiverParam](/api/oM/Framework/Programming/Params/ReceiverParam)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| DataType | [Type](https://learn.microsoft.com/en-us/dotnet/api/System.Type?view=netstandard-2.0) | - | - |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface INodeParam : BH.oM.Base.IObject
```

Assembly: Programming_oM.dll

The interface is defined in C#. The class definition is available on github:

- [INodeParam.cs](https://github.com/BHoM/BHoM/blob/develop/Programming_oM/Params\INodeParam.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Programming_oM/INodeParam.json"
}
```

The JSON Schema is available on github here:

- [INodeParam.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Programming_oM/INodeParam.json)
