---
title: PlumbingLoadingFixtureUnitFragment
---

# <small>BH.oM.MEP.Fragments.</small>**PlumbingLoadingFixtureUnitFragment**



## Class structure

### Implemented interfaces and base types

???+ bhom "The PlumbingLoadingFixtureUnitFragment is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| ColdWaterLoadingFixtureUnits | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The number of cold water fixture or loading units for the plumbing fixture which denote the hydraulic load imposed based on flow rate, time of operation and frequency of use. | - |
| HotWaterLoadingFixtureUnits | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The number of hot water fixture or loading units for the plumbing fixture which denote the hydraulic load imposed based on flow rate, time of operation and frequency of use. | - |
| DrainageLoadingFixtureUnits | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The number of waste/drainage fixture or loading units for the plumbing fixture which denote the hydraulic load imposed based on flow rate, time of operation and frequency of use. | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PlumbingLoadingFixtureUnitFragment : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: MEP_oM.dll

The class is defined in C#. The class definition is available on github:

- [PlumbingLoadingFixtureUnitFragment.cs](https://github.com/BHoM/BHoM/blob/develop/MEP_oM/Fragments\PlumbingLoadingFixtureUnitFragment.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/MEP_oM/Fragments/PlumbingLoadingFixtureUnitFragment.json"
}
```

The JSON Schema is available on github here:

- [PlumbingLoadingFixtureUnitFragment.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/MEP_oM/Fragments/PlumbingLoadingFixtureUnitFragment.json)
