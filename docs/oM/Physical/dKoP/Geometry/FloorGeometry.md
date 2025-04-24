---
title: FloorGeometry
---

# <small>BH.oM.</small>**FloorGeometry**



## Class structure

### Implemented interfaces and base types

???+ bhom "The FloorGeometry is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.dKoP.[IdKopObject](/api/oM/Physical/dKoP/IdKopObject)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| SettingOut | [SettingOut](/api/oM/Physical/dKoP/Geometry/SettingOut) | - | - |
| ExternalDimensions | [FloorDimensions](/api/oM/Physical/dKoP/Geometry/FloorDimensions) | - | - |
| Staircases | [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[Staircase](/api/oM/Physical/dKoP/Geometry/Openings/Staircase)&gt; | - | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class FloorGeometry : BH.oM.dKoP.IdKopObject, BH.oM.Base.IObject
```

Assembly: dKoP_oM.dll

The class is defined in C#. The class definition is available on github:

- [FloorGeometry.cs](https://github.com/BHoM/dKoP_Toolkit/blob/develop/dKoP_oM/Geometry\FloorGeometry.cs)

All history and changes of the class can be found by inspection the history.
