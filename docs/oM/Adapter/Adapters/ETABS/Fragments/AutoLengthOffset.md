---
title: AutoLengthOffset
---

# <small>BH.oM.Adapters.ETABS.Elements.</small>**AutoLengthOffset**



## Class structure

### Implemented interfaces and base types

???+ bhom "The AutoLengthOffset is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| AutoOffset | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |
| RigidZoneFactor | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Value descibing the factor of the rigid zone. Needs to be between 0 and 1 | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class AutoLengthOffset : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: ETABS_oM.dll

The C# class definition is available on github:

- [AutoLengthOffset.cs](https://github.com/BHoM/ETABS_Toolkit/blob/develop/ETABS_oM/Fragments\AutoLengthOffset.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by refernce. To do this, use the schema reference below in in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/ETABS_oM/Elements/AutoLengthOffset.json"
}
```

The JSON Schema is available on github here:

- [AutoLengthOffset.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/ETABS_oM/Elements/AutoLengthOffset.json)
