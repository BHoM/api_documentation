---
title: CvalueSettings
---

# Humans.ViewQuality.CvalueSettings



## Class structure

### Implemented interfaces and base types

???+ bhom "The CvalueSettings in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| FocalMethod | [CvalueFocalMethodEnum](/api_documentation/oM/Physical/Humans/ViewQuality/CvalueFocalMethodEnum) | - | - |
| DefaultCValue | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Value assigned to spectators where Cvalue cannot be calculated, for example on a front row. | - |
| FarClippingPlaneDistance | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The distance from a spectator to the far clipping plane of their view frustum. Spectators in front of this plane will not be used in the Cvalue calculation. | - |
| ViewConeAngle | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Spectator view cone angle in radians. Default is approximately 2.0944 radians or 120 degrees. Field of view for a spectator, within which spectators in front are consider to be effectively blocking the view and used for the Cvalue calcualtion.  | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [CvalueSettings.cs](https://github.com/BHoM/BHoM/blob/develop/Humans_oM/ViewQuality\CvalueSettings.cs)

All history and changes of the class can be found by inspection the history.
