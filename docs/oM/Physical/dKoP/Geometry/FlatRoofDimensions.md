---
title: FlatRoofDimensions
---

# <small>BH.oM.dKoP.</small>**FlatRoofDimensions**



## Class structure

### Implemented interfaces and base types

???+ bhom "The FlatRoofDimensions is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKoPObject](/api/oM/Physical/dKoP/IdKoPObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Width | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Length | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Fall | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| Overhang | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| HeightAtFascia | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Overall buildup. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] |
| ConfirmationGeometryRequirementsAreMet | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class FlatRoofDimensions : BH.oM.dKoP.IdKoPObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The C# class definition is available on github:

- [FlatRoofDimensions.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Geometry\FlatRoofDimensions.cs)

All history and changes of the class can be found by inspection the history.
### JSON Schema implementation

The object is defined as a JSON schema. You can validate a JSON instance against this schema by reference. To do this, use the schema reference below in a validator like [this one](https://www.jsonschemavalidator.net/).

``` json title="JSON Schema"
{
 "$ref" : "https://raw.githubusercontent.com/BHoM/BHoM_JSONSchema/develop/dKoP_oM/FlatRoofDimensions.json"
}
```

The JSON Schema is available on github here:

- [FlatRoofDimensions.json](https://github.com/BHoM/BHoM_JSONSchema/blob/develop/dKoP_oM/FlatRoofDimensions.json)
