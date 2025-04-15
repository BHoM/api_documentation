---
title: IShapeCode
---

# Physical.Reinforcement.IShapeCode

Base interface for all ShapeCode objects.

## Interface structure

### Implemented interfaces and base types

???+ bhom "The IShapeCode in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Physical.Reinforcement.BS8666.[ShapeCode00](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode00)
    - Physical.Reinforcement.BS8666.[ShapeCode11](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode11)
    - Physical.Reinforcement.BS8666.[ShapeCode12](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode12)
    - Physical.Reinforcement.BS8666.[ShapeCode13](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode13)
    - Physical.Reinforcement.BS8666.[ShapeCode14](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode14)
    - Physical.Reinforcement.BS8666.[ShapeCode15](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode15)
    - Physical.Reinforcement.BS8666.[ShapeCode21](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode21)
    - Physical.Reinforcement.BS8666.[ShapeCode22](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode22)
    - Physical.Reinforcement.BS8666.[ShapeCode23](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode23)
    - Physical.Reinforcement.BS8666.[ShapeCode24](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode24)
    - Physical.Reinforcement.BS8666.[ShapeCode25](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode25)
    - Physical.Reinforcement.BS8666.[ShapeCode26](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode26)
    - Physical.Reinforcement.BS8666.[ShapeCode27](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode27)
    - Physical.Reinforcement.BS8666.[ShapeCode28](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode28)
    - Physical.Reinforcement.BS8666.[ShapeCode29](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode29)
    - Physical.Reinforcement.BS8666.[ShapeCode31](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode31)
    - Physical.Reinforcement.BS8666.[ShapeCode32](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode32)
    - Physical.Reinforcement.BS8666.[ShapeCode33](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode33)
    - Physical.Reinforcement.BS8666.[ShapeCode34](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode34)
    - Physical.Reinforcement.BS8666.[ShapeCode35](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode35)
    - Physical.Reinforcement.BS8666.[ShapeCode36](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode36)
    - Physical.Reinforcement.BS8666.[ShapeCode41](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode41)
    - Physical.Reinforcement.BS8666.[ShapeCode44](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode44)
    - Physical.Reinforcement.BS8666.[ShapeCode46](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode46)
    - Physical.Reinforcement.BS8666.[ShapeCode47](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode47)
    - Physical.Reinforcement.BS8666.[ShapeCode48](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode48)
    - Physical.Reinforcement.BS8666.[ShapeCode51](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode51)
    - Physical.Reinforcement.BS8666.[ShapeCode52](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode52)
    - Physical.Reinforcement.BS8666.[ShapeCode56](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode56)
    - Physical.Reinforcement.BS8666.[ShapeCode63](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode63)
    - Physical.Reinforcement.BS8666.[ShapeCode64](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode64)
    - Physical.Reinforcement.BS8666.[ShapeCode67](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode67)
    - Physical.Reinforcement.BS8666.[ShapeCode75](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode75)
    - Physical.Reinforcement.BS8666.[ShapeCode77](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode77)
    - Physical.Reinforcement.BS8666.[ShapeCode98](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode98)
    - Physical.Reinforcement.BS8666.[ShapeCode99](/om_documentation/oM/Physical/Physical/Reinforcement/BS8666/ShapeCode99)


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
| GeneralEndProjection | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the minimum end projection for general bends (bobs) or links where the bend is greater than or equal to 150 degrees.This is based on the diameter of the reinforcement bar and the standard is determined from the ShapeCode namespace. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |
| HookDiameter | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the hook diameter based on the diameter of the reinforcement bar, the shape code and the bend radius. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |
| ICentreline | [ICurve](/om_documentation/oM/Dimensional/Geometry/ICurve) | Computes the centreline for a Reinforcement using the standard as determined by the ShapeCode namespace. The curve will be in the XY Plane - refer to the ShapeCode description for specifics on the orientation. | - | Physical_Engine |
| IIsCompliant | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Verifies the dimensions to the standard as determined by the ShapeCode namespace. | - | Physical_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a ShapeCode is null and outputs relevant error message. | - | Physical_Engine |
| LinksEndProjection | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the minimum end projection for links where the bend is less than 150 degrees.This is based on the diameter of the reinforcement bar and the standard is determined from the ShapeCode namespace. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |
| MaximumRadius | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the maximum radius based on the diameter of the reinforcement bar. The standard is determined from the namespace of the ShapeCode. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |
| ReinforcementStandard | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Gets the standard for reinforcement (e.g. BS 8666) based on the namespace of the ShapeCode. | - | Physical_Engine |
| SchedulingRadius | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the minimum scheduling radius based on the diameter of the reinforcement bar. The standard is determined from the namespace of the ShapeCode. | [Length](/om_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] | Physical_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IShapeCode.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/Reinforcement\IShapeCode.cs)

All history and changes of the class can be found by inspection the history.
