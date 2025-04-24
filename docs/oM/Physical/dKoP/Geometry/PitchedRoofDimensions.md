---
title: PitchedRoofDimensions
---

# <small>BH.oM.</small>**PitchedRoofDimensions**



## Class structure

### Implemented interfaces and base types

???+ bhom "The PitchedRoofDimensions is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKopObject](/api/oM/Physical/dKoP/IdKopObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Width | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| Span | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| Pitch | [Pitch](/api/oM/Physical/dKoP/Geometry/Enums/Pitch) | - | - |
| Overhang | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |
| HeightAtFascia | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Overall buildup. | - |
| InternalSpandrelPanel | [InternalSpandrelPanel](/api/oM/Physical/dKoP/Geometry/InternalSpandrelPanel) | - | - |
| GableEndPanel | [GableEndPanel](/api/oM/Physical/dKoP/Geometry/GableEndPanel) | - | - |
| ConfirmationGeometryRequirementsAreMet | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class PitchedRoofDimensions : BH.oM.dKoP.IdKopObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [PitchedRoofDimensions.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Geometry\PitchedRoofDimensions.cs)

All history and changes of the class can be found by inspection the history.
