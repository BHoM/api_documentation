---
title: TakeoffItem
---

# Physical.Materials.TakeoffItem

Class storing takeoff values of relevant quantities corresponding to a particular material.

## Class structure

### Implemented interfaces and base types

???+ bhom "The TakeoffItem in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Material | [Material](/api_documentation/oM/Physical/Physical/Materials/Material) | Material to which the takeoff values correspond. | - |
| Volume | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total volume of the material. Applicable for most takeoffs. | [Volume](/api_documentation/oM/Dimensional/Quantities/Attributes/Volume) [m³] |
| Mass | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total mass of the material. Applicable for materials with a set density. | [Mass](/api_documentation/oM/Dimensional/Quantities/Attributes/Mass) [kg] |
| Area | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total area of the material. Applicable for takeoffs of 2-dimensional elements or 2-dimensional parts. | [Area](/api_documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] |
| Length | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total length of the material. Applicable for takeoffs of 1-dimensional elements or elements with 1-dimensional parts. | [Length](/api_documentation/oM/Dimensional/Quantities/Attributes/Length) [m] |
| NumberItem | [int](https://learn.microsoft.com/en-us/dotnet/api/System.Int32?view=netstandard-2.0) | Total number of items containing the material in the takeoff. Applicable for most takeoffs. | - |
| ElectricCurrent | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total Electric current associated with the material. Applicable for takeoffs of some electrical equipment elements. | [ElectricCurrent](/api_documentation/oM/Dimensional/Quantities/Attributes/ElectricCurrent) [A] |
| Energy | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total Electric current associated with the material. Applicable for takeoffs of some electrical equipment elements. | [Energy](/api_documentation/oM/Dimensional/Quantities/Attributes/Energy) [J] |
| Power | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total Power or apparent power associated with the material. Applicable for takeoffs of some electrical equipment elements. | [EnergyPerUnitTime](/api_documentation/oM/Dimensional/Quantities/Attributes/EnergyPerUnitTime) [W] |
| VolumetricFlowRate | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Total VolumetricFlowRate associated with the material. Applicable for takeoffs of elements relating to flow of substance through the element. | [VolumetricFlowRate](/api_documentation/oM/Dimensional/Quantities/Attributes/VolumetricFlowRate) [m³/s] |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [TakeoffItem.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/Materials\TakeoffItem.cs)

All history and changes of the class can be found by inspection the history.
