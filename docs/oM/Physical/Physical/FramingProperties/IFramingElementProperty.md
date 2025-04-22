---
title: IFramingElementProperty
---

# Physical.FramingProperties.IFramingElementProperty



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IFramingElementProperty in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Physical.FramingProperties.[ConstantFramingProperty](/api_documentation/oM/Physical/Physical/FramingProperties/ConstantFramingProperty)


## Properties

### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IAverageProfileArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the average cross-section area of a IFramingElementProperty in such a way that multiplying with the length of the element would give the volume | [Area](/api_documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] | Physical_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a IFramingElementProperty is null and outputs relevant error message. | - | Physical_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IFramingElementProperty.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/FramingProperties\IFramingElementProperty.cs)

All history and changes of the class can be found by inspection the history.
