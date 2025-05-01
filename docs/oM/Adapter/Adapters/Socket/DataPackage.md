---
title: DataPackage
---

# <small>BH.oM.Adapters.Socket.</small>**DataPackage**



## Class structure

### Implemented interfaces and base types

???+ bhom "The DataPackage is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Data | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |
| Events | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Event](/api/oM/Framework/Base/Debugging/Event)&gt; | - | - |
| Tag | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class DataPackage : BH.oM.Base.IObject
```

Assembly: Socket_oM.dll

The C# class definition is available on github:

- [DataPackage.cs](https://github.com/BHoM/Socket_Toolkit/blob/develop/Socket_oM/DataPackage.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Socket_oM/DataPackage.json"
}
```

The JSON Schema is available on github here:

- [DataPackage.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Socket_oM/DataPackage.json)
