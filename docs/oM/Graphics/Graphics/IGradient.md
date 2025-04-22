---
title: IGradient
---

# Graphics.IGradient



## Interface structure

### Implemented interfaces and base types

???+ bhom "The IGradient in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IBHoMObject](/api_documentation/oM/Framework/Base/IBHoMObject)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)


### Classes implementing this interface

???+ bhom "The following classes are implementing this interface:"

    - Graphics.[Gradient](/api_documentation/oM/Graphics/Graphics/Gradient)
    - Graphics.[SteppedGradient](/api_documentation/oM/Graphics/Graphics/SteppedGradient)


## Properties



### Defining properties

The following properties are defined on the interface

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| Markers | [SortedDictionary](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.Generic.SortedDictionary-2?view=netstandard-2.0)&lt;[decimal](https://learn.microsoft.com/en-us/dotnet/api/System.Decimal?view=netstandard-2.0), [Color](https://learn.microsoft.com/en-us/dotnet/api/System.Drawing.Color?view=netstandard-2.0)&gt; | A SortedDictionary of 'Color's using a 'decimal' between 0 and 1 as Key. Used to get a 'Color' from a value between 0 and 1 | - |


### Derived properties

The following properties are defined as extension methods in one of the BHoM_Engines

| Name             | Type             | Description      | Quantity         | Engine           |
|------------------|------------------|------------------|------------------|------------------|
| IGradientLegend | [RenderMesh](/api_documentation/oM/Graphics/Graphics/RenderMesh) | Constructs a RenderMesh corresponding to the gradient. | - | Graphics_Engine |


## Code and Schema

### C# implementation

The interface is defined in C#. The class definition is available on github:

- [IGradient.cs](https://github.com/BHoM/BHoM/blob/develop/Graphics_oM/Colours/IGradient.cs)

All history and changes of the class can be found by inspection the history.
