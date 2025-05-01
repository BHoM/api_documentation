---
title: IEnum
---

# <small>BH.oM.Base.</small>**IEnum**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IEnum is inheriting from the following base type(s) and implements the following interfaces:"

    -  [IComparable](https://learn.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netstandard-2.0)&lt;BH.oM.Base.[IEnum](/api/oM/Framework/Base/Interface/IEnum)&gt;
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Base.[Enumeration](/api/oM/Framework/Base/Enumeration)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Value | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface IEnum : System.IComparable<BH.oM.Base.IEnum>, BH.oM.Base.IObject
```

Assembly: BHoM.dll

The interface is defined in C#. The class definition is available on github:

- [IEnum.cs](https://github.com/BHoM/BHoM/blob/develop/BHoM/Interface\IEnum.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/BHoM/IEnum.json"
}
```

The JSON Schema is available on github here:

- [IEnum.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/BHoM/IEnum.json)
