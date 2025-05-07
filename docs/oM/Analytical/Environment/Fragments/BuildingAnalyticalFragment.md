---
title: BuildingAnalyticalFragment
---

# <small>BH.oM.Environment.Fragments.</small>**BuildingAnalyticalFragment**

This fragment is used to define the north angle, GMT offset and year of construction for a building

## Class structure

### Implemented interfaces and base types

???+ bhom "The BuildingAnalyticalFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| NorthAngle | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| GMTOffset | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| Year | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class BuildingAnalyticalFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Environment_oM.dll

The C# class definition is available on github:

- [BuildingAnalyticalFragment.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/Fragments\BuildingAnalyticalFragment.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Environment_oM/Fragments/BuildingAnalyticalFragment.json"
}
```

The JSON Schema is available on github here:

- [BuildingAnalyticalFragment.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Environment_oM/Fragments/BuildingAnalyticalFragment.json)
