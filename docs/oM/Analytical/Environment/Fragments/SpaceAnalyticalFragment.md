---
title: SpaceAnalyticalFragment
---

# <small>BH.oM.Environment.Fragments.</small>**SpaceAnalyticalFragment**

Fragment containing space analytical properties (e.g. domestic hot water supply, daylight factor, heating and cooling sizing method)

## Class structure

### Implemented interfaces and base types

???+ bhom "The SpaceAnalyticalFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| InternalDomesticHotWater | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The amount of internal domestic hot water supply for the space | - |
| DaylightFactor | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| FacadeLength | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The length of the space enclsoure that is adjacent to the outdoors | - |
| FixedConvectionCoefficient | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| SizeCoolingMethod | [SizingMethod](/api/oM/Analytical/Environment/Fragments/Enums/SizingMethod) | The cooling size method of the space. Use SizingMethod enum | - |
| SizeHeatingMethod | [SizingMethod](/api/oM/Analytical/Environment/Fragments/Enums/SizingMethod) | The heating size method of the space. Use SizingMethod enum | - |
| RadiantProportion | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class SpaceAnalyticalFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: Environment_oM.dll

The class is defined in C#. The class definition is available on github:

- [SpaceAnalyticalFragment.cs](https://github.com/BHoM/BHoM/blob/develop/Environment_oM/Fragments\SpaceAnalyticalFragment.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` { .json .copy .select } title="JSON Schema"
{
 "$ref" : https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Environment_oM/Fragments/SpaceAnalyticalFragment.json}
```

The JSON Schema is available on github here:

- [SpaceAnalyticalFragment.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Environment_oM/Fragments/SpaceAnalyticalFragment.json)
