---
title: IntegrationSlice
---

# <small>BH.oM.Geometry.</small>**IntegrationSlice**

Describes a discrete finite slice of an area. Used for numerical approximation of an integration.

## Class structure

### Implemented interfaces and base types

???+ bhom "The IntegrationSlice is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Width | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| Length | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| Centre | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| Placement | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0)[] | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class IntegrationSlice : BH.oM.Base.IObject
```

Assembly: Geometry_oM.dll

The class is defined in C#. The class definition is available on github:

- [IntegrationSlice.cs](https://github.com/BHoM/BHoM/blob/develop/Geometry_oM/Math\IntegrationSlice.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. To reference the schema in a validator like [this](https://www.jsonschemavalidator.net/) to validate a Json instance, please use the lines below:

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/Geometry_oM/IntegrationSlice.json"
}
```

The JSON Schema is available on github here:

- [IntegrationSlice.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/Geometry_oM/IntegrationSlice.json)
