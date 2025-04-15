---
title: FloorDimension
---

# Environment.SAP.XML.FloorDimension



## Class structure

### Implemented interfaces and base types

???+ bhom "The FloorDimension in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/om_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/om_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/om_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | A name describing the floor dimensioned. | - |
| Description | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Descriptive notes about the floor. | - |
| Type | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Type of floor (exposure). | - |
| Storey | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Building storey on which the floor is located. | - |
| StoreyHeight | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Average height of the storey in metres. | - |
| Area | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The total floor area of the storey in square metres. | - |
| UValue | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Heat loss floor U-value. | - |
| HeatLossArea | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | The estimated total heat loss area for the floor in square metres. | - |
| KappaValue | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Heat capacity of floor per unit area in kJ/m�K. | - |
| KappaValueFromBelow | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Heat capacity of ceiling below.  Applies to the non-heat-loss area of an upper floor. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/om_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [FloorDimension.cs](https://github.com/BHoM/SAP_Toolkit/blob/develop/SAP_oM/XML/FloorDimension.cs)

All history and changes of the class can be found by inspection the history.
