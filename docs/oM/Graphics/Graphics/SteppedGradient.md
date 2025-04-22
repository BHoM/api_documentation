---
title: SteppedGradient
---

# Graphics.SteppedGradient

Gradient for extracting colours in specific range bands, this is, a single colour for a specific range.

## Class structure

### Implemented interfaces and base types

???+ bhom "The SteppedGradient in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Graphics.[IGradient](/api_documentation/oM/Graphics/Graphics/IGradient)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Markers | [SortedDictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.SortedDictionary-2?view=netstandard-2.0)&lt;[decimal](https://learn.microsoft.com/en-us/dotnet/api/System.Decimal?view=netstandard-2.0), [Color](https://learn.microsoft.com/en-us/dotnet/api/System.Drawing.Color?view=netstandard-2.0)&gt; | A SortedDictionary of 'Color's using a 'decimal' between 0 and 1 as Key. Decimal of marker indicates the lower limit for the range of that colour. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| GradientLegend | [RenderMesh](/api_documentation/oM/Graphics/Graphics/RenderMesh) | Constructs a RenderMesh corresponding to the gradient. | - | Graphics_Engine |
| IGradientLegend | [RenderMesh](/api_documentation/oM/Graphics/Graphics/RenderMesh) | Constructs a RenderMesh corresponding to the gradient. | - | Graphics_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [SteppedGradient.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Colours/SteppedGradient.cs)

All history and changes of the class can be found by inspection the history.
