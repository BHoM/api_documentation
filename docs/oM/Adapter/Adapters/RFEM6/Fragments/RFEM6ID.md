---
title: RFEM6ID
---

# <small>BH.oM.Adapters.RFEM6.</small>**RFEM6ID**



## Class structure

### Implemented interfaces and base types

???+ bhom "The RFEM6ID is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IAdapterId](/api/oM/Framework/Base/Interface/IAdapterId)
    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Id | [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RFEM6ID : BH.oM.Base.IAdapterId, BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: RFEM6_oM.dll

The C# class definition is available on github:

- [RFEM6ID.cs](https://github.com/BHoM/RFEM6_Toolkit/blob/develop/RFEM6_oM/Fragments\RFEM6ID.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/RFEM6_oM/RFEM6ID.json"
}
```

The JSON Schema is available on github here:

- [RFEM6ID.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/RFEM6_oM/RFEM6ID.json)
