---
title: ConstantFramingProperty
---

# Physical.FramingProperties.ConstantFramingProperty



## Class structure

### Implemented interfaces and base types

???+ bhom "The ConstantFramingProperty in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/documentation/oM/Framework/Base/IObject)
    -  Physical.FramingProperties.[IFramingElementProperty](/documentation/oM/Physical/Physical/FramingProperties/IFramingElementProperty)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Profile | [IProfile](/documentation/oM/Dimensional/Spatial/ShapeProfiles/IProfile) | - | - |
| Material | [Material](/documentation/oM/Physical/Physical/Materials/Material) | - | - |
| OrientationAngle | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | - | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| AverageProfileArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the average cross-section area of a ConstantFramingProperty in such a way that multiplying with the length of the element would give the volume | [Area](/documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] | Physical_Engine |
| IAverageProfileArea | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | Gets the average cross-section area of a IFramingElementProperty in such a way that multiplying with the length of the element would give the volume | [Area](/documentation/oM/Dimensional/Quantities/Attributes/Area) [m²] | Physical_Engine |
| IsNull | [bool](https://learn.microsoft.com/en-us/dotnet/api/System.Boolean?view=netstandard-2.0) | Checks if a IFramingElementProperty is null and outputs relevant error message. | - | Physical_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [ConstantFramingProperty.cs](https://github.com/BHoM/BHoM/blob/develop/Physical_oM/FramingProperties\ConstantFramingProperty.cs)

All history and changes of the class can be found by inspection the history.
