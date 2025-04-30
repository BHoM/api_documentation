---
title: UValueContinuous
---

# <small>BH.oM.Facade.Fragments.</small>**UValueContinuous**

A U-Value representing the effective U-Value of continuous insulation and/or layers (not affected by thermal bridging due to frame u-value).

## Class structure

### Implemented interfaces and base types

???+ bhom "The UValueContinuous is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| UValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The U-Value of the continuous layers. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class UValueContinuous : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Facade_oM.dll

The class is defined in C#. The class definition is available on github:

- [UValueContinuous.cs](https://github.com/BHoM/BHoM/blob/develop/Facade_oM/Fragments\UValueContinuous.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Facade_oM/Fragments/UValueContinuous.json}
```

The JSON Schema is available on github here:

- [UValueContinuous.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Facade_oM/Fragments/UValueContinuous.json)
