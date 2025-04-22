---
title: GradientOptions
---

# Graphics.Colours.GradientOptions

Defines options for range and centering for a Gradient.

## Class structure

### Implemented interfaces and base types

???+ bhom "The GradientOptions in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[BHoMObject](/api_documentation/oM/Framework/Base/BHoMObject)
    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Name | [string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0) | Name of the GradientOption. Will be displayed for Gradient legends. | - |
| Gradient | [IGradient](/api_documentation/oM/Graphics/Graphics/IGradient) | The Gradient to colour by. | - |
| LowerBound | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The lower bound of the Gradient. Leave empty to allow other methods to set automatically. | - |
| UpperBound | [double](https://learn.microsoft.com/en-us/dotnet/api/System.Double?view=netstandard-2.0) | The upper bound of the Gradient. Leave empty to allow other methods to set automatically. | - |
| GradientCenteringOptions | [GradientCenteringOptions](/api_documentation/oM/Graphics/Graphics/Enums/GradientCenteringOptions) | A GradientCenteringOptions enum to set centering options. Defaults to no centering. | - |


### Inherited properties
The following properties are inherited from the base class of the object

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| BHoM_Guid | [Guid](https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=netstandard-2.0) | - | - |
| Fragments | [FragmentSet](/api_documentation/oM/Framework/Base/FragmentSet) | - | - |
| Tags | [HashSet](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0)&gt; | - | - |
| CustomData | [Dictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2?view=netstandard-2.0)&lt;[string](https://learn.microsoft.com/en-us/dotnet/api/System.String?view=netstandard-2.0), [object](https://learn.microsoft.com/en-us/dotnet/api/System.Object?view=netstandard-2.0)&gt; | - | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| GradientLegend | [Output](/api_documentation/oM/Framework/Base/Output%603)&lt;[RenderMesh](/api_documentation/oM/Graphics/Graphics/RenderMesh), [List](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netstandard-2.0)&lt;[RenderText](/api_documentation/oM/Graphics/Graphics/RenderText)&gt;, [RenderText](/api_documentation/oM/Graphics/Graphics/RenderText)&gt; | Constructs a RenderMesh corresponding to the GradientOption with text markers corresponding to the numbers on the gradient markers. | - | Graphics_Engine |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [GradientOptions.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Colours\GradientOptions.cs)

All history and changes of the class can be found by inspection the history.
