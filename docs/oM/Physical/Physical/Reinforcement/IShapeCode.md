---
title: IShapeCode
---

# Physical.Reinforcement.IShapeCode

Base interface for all ShapeCode objects.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IShapeCode in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/api/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Physical.Reinforcement.BS8666.[ShapeCode00](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode00)
    - Physical.Reinforcement.BS8666.[ShapeCode11](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode11)
    - Physical.Reinforcement.BS8666.[ShapeCode12](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode12)
    - Physical.Reinforcement.BS8666.[ShapeCode13](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode13)
    - Physical.Reinforcement.BS8666.[ShapeCode14](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode14)
    - Physical.Reinforcement.BS8666.[ShapeCode15](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode15)
    - Physical.Reinforcement.BS8666.[ShapeCode21](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode21)
    - Physical.Reinforcement.BS8666.[ShapeCode22](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode22)
    - Physical.Reinforcement.BS8666.[ShapeCode23](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode23)
    - Physical.Reinforcement.BS8666.[ShapeCode24](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode24)
    - Physical.Reinforcement.BS8666.[ShapeCode25](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode25)
    - Physical.Reinforcement.BS8666.[ShapeCode26](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode26)
    - Physical.Reinforcement.BS8666.[ShapeCode27](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode27)
    - Physical.Reinforcement.BS8666.[ShapeCode28](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode28)
    - Physical.Reinforcement.BS8666.[ShapeCode29](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode29)
    - Physical.Reinforcement.BS8666.[ShapeCode31](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode31)
    - Physical.Reinforcement.BS8666.[ShapeCode32](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode32)
    - Physical.Reinforcement.BS8666.[ShapeCode33](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode33)
    - Physical.Reinforcement.BS8666.[ShapeCode34](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode34)
    - Physical.Reinforcement.BS8666.[ShapeCode35](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode35)
    - Physical.Reinforcement.BS8666.[ShapeCode36](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode36)
    - Physical.Reinforcement.BS8666.[ShapeCode41](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode41)
    - Physical.Reinforcement.BS8666.[ShapeCode44](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode44)
    - Physical.Reinforcement.BS8666.[ShapeCode46](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode46)
    - Physical.Reinforcement.BS8666.[ShapeCode47](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode47)
    - Physical.Reinforcement.BS8666.[ShapeCode48](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode48)
    - Physical.Reinforcement.BS8666.[ShapeCode51](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode51)
    - Physical.Reinforcement.BS8666.[ShapeCode52](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode52)
    - Physical.Reinforcement.BS8666.[ShapeCode56](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode56)
    - Physical.Reinforcement.BS8666.[ShapeCode63](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode63)
    - Physical.Reinforcement.BS8666.[ShapeCode64](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode64)
    - Physical.Reinforcement.BS8666.[ShapeCode67](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode67)
    - Physical.Reinforcement.BS8666.[ShapeCode75](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode75)
    - Physical.Reinforcement.BS8666.[ShapeCode77](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode77)
    - Physical.Reinforcement.BS8666.[ShapeCode98](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode98)
    - Physical.Reinforcement.BS8666.[ShapeCode99](/api/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode99)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Diameter | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The diameter of the reinforcement bar. | - |
| BendRadius | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Bend radius used for any discontinuities in the CentreCurve. | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| GeneralEndProjection | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the minimum end projection for general bends (bobs) or links where the bend is greater than or equal to 150 degrees.This is based on the diameter of the reinforcement bar and the standard is determined from the ShapeCode namespace. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |
| HookDiameter | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the hook diameter based on the diameter of the reinforcement bar, the shape code and the bend radius. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |
| ICentreline | [ICurve](/api/oM/Dimensional/Geometry/ICurve) | Computes the centreline for a Reinforcement using the standard as determined by the ShapeCode namespace. The curve will be in the XY Plane - refer to the ShapeCode description for specifics on the orientation. | - | Physical_Engine |
| IIsCompliant | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Verifies the dimensions to the standard as determined by the ShapeCode namespace. | - | Physical_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a ShapeCode is null and outputs relevant error message. | - | Physical_Engine |
| LinksEndProjection | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the minimum end projection for links where the bend is less than 150 degrees.This is based on the diameter of the reinforcement bar and the standard is determined from the ShapeCode namespace. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |
| MaximumRadius | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the maximum radius based on the diameter of the reinforcement bar. The standard is determined from the namespace of the ShapeCode. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |
| ReinforcementStandard | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gets the standard for reinforcement (e.g. BS 8666) based on the namespace of the ShapeCode. | - | Physical_Engine |
| SchedulingRadius | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the minimum scheduling radius based on the diameter of the reinforcement bar. The standard is determined from the namespace of the ShapeCode. | [Length](/api/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IShapeCode.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/Reinforcement\IShapeCode.cs)

All history and changes of the class can be found by inspection the history.
