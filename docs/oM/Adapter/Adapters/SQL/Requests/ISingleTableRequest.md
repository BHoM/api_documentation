---
title: ISingleTableRequest
---

# <small>BH.oM.Adapters.SQL.</small>**ISingleTableRequest**



## Interface structure

### Implemented interfaces and base types

???+ bhom "The ISingleTableRequest is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - BH.oM.Adapters.SQL.[TableRequest](/api/oM/Adapter/Adapters/SQL/Requests/TableRequest)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Table | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public interface ISingleTableRequest : BH.oM.Base.IObject
```

Assembly: SQL_oM.dll

The interface is defined in C#. The class definition is available on github:

- [ISingleTableRequest.cs](https://github.com/BHoM/SQL_Toolkit/blob/develop/SQL_oM/Requests\ISingleTableRequest.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/SQL_oM/ISingleTableRequest.json"
}
```

The JSON Schema is available on github here:

- [ISingleTableRequest.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/SQL_oM/ISingleTableRequest.json)
