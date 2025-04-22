---
title: RevitRepresentation
---

# Adapters.Revit.RevitRepresentation

Fragment containing the representation extracted from Revit element represented by the BHoM object.

## Class structure

### Implemented interfaces and base types

???+ bhom "The RevitRepresentation in inheriting from the following base type(s) and implements the following interfaces:"

    -  Base.[IFragment](/api_documentation/oM/Framework/Base/IFragment)
    -  Base.[IObject](/api_documentation/oM/Framework/Base/IObject)
    -  Base.[IImmutable](/api_documentation/oM/Framework/Base/IImmutable)


## Properties



### Defining properties

The following properties are defined on the class

| Name             | Type             | Description      | Quantity         |
|------------------|------------------|------------------|------------------|
| RenderMeshes | [ReadOnlyCollection](https://learn.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ReadOnlyCollection-1?view=netstandard-2.0)&lt;[RenderMesh](/api_documentation/oM/Graphics/Graphics/RenderMesh)&gt; | Mesh representation of Revit element represented by the BHoM object carrying this fragment. | - |


## Code and Schema

### C# implementation

The class is defined in C#. The class definition is available on github:

- [RevitRepresentation.cs](https://github.com/BHoM/Revit_Toolkit/blob/develop/Revit_oM/Misc/RevitRepresentation.cs)

All history and changes of the class can be found by inspection the history.
