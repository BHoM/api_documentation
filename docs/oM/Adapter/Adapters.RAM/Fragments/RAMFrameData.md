---
title: RAMFrameData
---

# <small>BH.oM.Adapters.</small>**RAMFrameData**



## Class structure

### Implemented interfaces and base types

???+ bhom "The RAMFrameData is inheriting from the following base type(s) and implements the following interfaces:"

    -  BH.oM.Base.[IFragment](/api/oM/Framework/Base/Interface/IFragment)
    -  BH.oM.Base.[IObject](/api/oM/Framework/Base/Interface/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Material | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Represents Frame Material as per RAM | - |
| FrameType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Represents Frame Type as per RAM | - |
| FloorType | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Represents Floor Type element is placed on as per RAM | - |
| FrameNumber | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Represents Frame Number per RAM | - |
| IsStubCantilever | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Represents if the element is a stub cantilever in RAM | - |
| StartCantilever | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Represents the start cantilever distance (if applicable) in RAM | - |
| EndCantilever | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Represents the end cantilever distance (if applicable) in RAM | - |
| IsHangingColumn | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Represents if the element is a hanging column in RAM | - |
| Studs | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Number of studs applied to frame | - |
| Camber | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Camber length applied to frame | - |
| DesignCapacityInteraction | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Design Capacity Interaction as per RAM | - |
| CriticalDeflectionInteraction | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Critical Deflection Interaction as per RAM | - |


## Code and Schema

### C# implementation

``` C# title="C#"
public class RAMFrameData : BH.oM.Base.IFragment, BH.oM.Base.IObject
```

Assembly: RAM_oM.dll

The class is defined in C#. The class definition is available on github:

- [RAMFrameData.cs](https://github.com/BHoM/RAM_Toolkit/blob/develop/RAM_oM/Fragments\RAMFrameData.cs)

All history and changes of the class can be found by inspection the history.
